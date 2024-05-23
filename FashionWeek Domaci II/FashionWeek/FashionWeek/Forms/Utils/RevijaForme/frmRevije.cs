using FashionWeek.DTO;
using FashionWeek.Entiteti;
using FashionWeek.Forms.Utils.Revija;
using FashionWeek.Forms.Utils.RevijaForme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FashionWeek.Forms.Utils.Revija;

public partial class frmRevije : Form
{
    public static int? _rbrRevije = null;
    #region Funkcije
    public void EnableButtons()
    {
        btnAzurirajReviju.Enabled = true;
        btnObrisiReviju.Enabled = true;
        btnUcesnici.Enabled = true;
    }

    public void DisableButtons()
    {
        btnAzurirajReviju.Enabled = false;
        btnObrisiReviju.Enabled = false;
        btnUcesnici.Enabled = false;
    }

    public async void UcitajPodatke()
    {
        lvRevije.Items.Clear();
        IList<ModnaRevijaPregled> revije = await DTOManager.VratiModneRevije();
        foreach (var revija in revije)
        {
            ListViewItem item = new ListViewItem(new string[] { revija.RBR.ToString(), revija.Naziv, revija.Mesto?.ToString(), revija.Termin.ToShortDateString() });
            lvRevije.Items.Add(item);
        }
        lvRevije.Refresh();
    }
    #endregion

    public frmRevije()
    {
        InitializeComponent();
    }

    private void frmRevije_Load(object sender, EventArgs e)
    {
        UcitajPodatke();
    }

    private void lvRevije_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lvRevije.SelectedItems.Count > 0)
        {
            _rbrRevije = Int32.Parse(lvRevije.SelectedItems[0].Text);
            EnableButtons();
        }
        else
        {
            DisableButtons();
        }
    }

    private void btnDodajReviju_Click(object sender, EventArgs e)
    {
        frmDodajReviju revija = new frmDodajReviju();
        revija.ShowDialog();
        UcitajPodatke();
    }

    private void btnAzurirajReviju_Click(object sender, EventArgs e)
    {
        frmAzurirajReviju frmAzuriraj = new frmAzurirajReviju();
        frmAzuriraj.ShowDialog();
        UcitajPodatke();
        DisableButtons();
    }

    private async void btnObrisiReviju_Click(object sender, EventArgs e)
    {
        if (await DTOManager.ObrisiReviju(_rbrRevije))
        {
            MessageBox.Show("Uspešno obrisana revija!");
            UcitajPodatke();
            DisableButtons();
        }
    }

    private void btnUcesnici_Click(object sender, EventArgs e)
    {

        frmUcesniciRevije frmUcesniciRevije = new frmUcesniciRevije();
        frmUcesniciRevije.ShowDialog();
        DisableButtons();
    }

    private void btnIzadji_Click(object sender, EventArgs e)
    {
        Close();
    }
}

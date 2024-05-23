using FashionWeek.DTO;
using FashionWeek.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FashionWeek.Forms.Utils.AgencijaForme;

public partial class frmAgencije : Form
{
    public static string? _modnaAgencijaPIB = null;

    #region Funkcije
    public async void EnableButtons()
    {
        btnAzurirajAgenciju.Enabled = true;
        btnObrisiAgenciju.Enabled = true;
        btnPrikaziManekene.Enabled = true;
        if (await DTOManager.IsInostrana(_modnaAgencijaPIB!))
        {
            btnZemljePoslovanja.Enabled = true;
        }
    }

    public void DisableButtons()
    {
        btnAzurirajAgenciju.Enabled = false;
        btnObrisiAgenciju.Enabled = false;
        btnPrikaziManekene.Enabled = false;
        btnZemljePoslovanja.Enabled = false;
    }

    public async void UcitajPodatke()
    {
        lvAgencije.Items.Clear();
        IList<ModnaAgencijaPregled> agencije = await DTOManager.VratiModneAgencije();
        foreach (var agencija in agencije)
        {
            ListViewItem item = new ListViewItem(new string[] { agencija.PIB!, agencija.Naziv!, agencija.Sediste?.ToString(), agencija.DatumOsnivanja.ToShortDateString() });
            lvAgencije.Items.Add(item);
        }
        lvAgencije.Refresh();
    }
    #endregion

    public frmAgencije()
    {
        InitializeComponent();
    }

    private void frmAgencije_Load(object sender, EventArgs e)
    {
        UcitajPodatke();
    }

    private void lvAgencije_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lvAgencije.SelectedItems.Count > 0)
        {
            _modnaAgencijaPIB = lvAgencije.SelectedItems[0].Text;
            EnableButtons();
        }
        else
        {
            DisableButtons();
        }
    }

    private void btnDodajAgenciju_Click(object sender, EventArgs e)
    {
        frmDodajAgenciju frmDodajAgenciju = new frmDodajAgenciju();
        frmDodajAgenciju.ShowDialog();
        UcitajPodatke();
        DisableButtons();
    }

    private void btnAzurirajAgenciju_Click(object sender, EventArgs e)
    {
        frmAzurirajAgenciju frmAzuriraj = new frmAzurirajAgenciju();
        frmAzuriraj.ShowDialog();
        UcitajPodatke();
        DisableButtons();
    }

    private async void btnObrisiAgenciju_Click(object sender, EventArgs e)
    {

        if (await DTOManager.ObrisiModnuAgenciju(_modnaAgencijaPIB!))
        {
            MessageBox.Show("Uspešno obrisana agencija!");
            UcitajPodatke();
            DisableButtons();
        }
    }

    private void btnPrikaziManekene_Click(object sender, EventArgs e)
    {
        frmAgencijaManekeni frmManekeni = new frmAgencijaManekeni();
        frmManekeni.ShowDialog();
    }

    private void btnZemljePoslovanja_Click(object sender, EventArgs e)
    {
        frmNaziviZemaljaAgencije frmZemlje = new frmNaziviZemaljaAgencije();
        frmZemlje.ShowDialog();
    }

    private void btnIzadji_Click(object sender, EventArgs e)
    {
        Close();
    }
}

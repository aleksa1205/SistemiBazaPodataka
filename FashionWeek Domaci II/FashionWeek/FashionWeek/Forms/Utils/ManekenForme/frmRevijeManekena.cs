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

namespace FashionWeek.Forms.Utils.ManekenForme;

public partial class frmRevijeManekena : Form
{
    public frmRevijeManekena()
    {
        InitializeComponent();
    }

    #region Funkcije
    public async void UcitajPodatke()
    {
        lvRevije.Items.Clear();
        IList<ModnaRevijaPregled> listaRevija = await DTOManager.VratiModneRevijaManekena(frmManekeni._manekenMBR!);
        foreach (var revija in listaRevija)
        {
            ListViewItem item = new ListViewItem(new string[] { revija.RBR.ToString(), revija.Naziv, revija.Mesto!.ToString(), revija.Termin.ToShortDateString() });
            lvRevije.Items.Add(item);
        }
        lvRevije.Refresh();
    }
    #endregion

    private void frmRevije_Load(object sender, EventArgs e)
    {

        lblRevije.Text += frmManekeni._imeManekena + ':';
        UcitajPodatke();
    }

    private void lvRevije_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lvRevije.SelectedItems.Count > 0)
        {
            btnObrisiReviju.Enabled = true;
        }
        else
        {
            btnObrisiReviju.Enabled = false;
        }
    }

    private void btnDodajReviju_Click(object sender, EventArgs e)
    {
        frmDodajRevijuManeken frmDodaj = new frmDodajRevijuManeken();
        frmDodaj.ShowDialog();
        UcitajPodatke();
        btnObrisiReviju.Enabled = false;
    }

    private async void btnObrisiReviju_Click(object sender, EventArgs e)
    {
        if(await DTOManager.ObrisiRevijuManekenu(frmManekeni._manekenMBR!, Int32.Parse(lvRevije.SelectedItems[0].Text)))
        {
            MessageBox.Show("Uspešno obrisana revija manekenu!");
            UcitajPodatke();
            btnObrisiReviju.Enabled = false;
        }
    }

    private void btnOdustani_Click(object sender, EventArgs e)
    {
        Close();
    }

}

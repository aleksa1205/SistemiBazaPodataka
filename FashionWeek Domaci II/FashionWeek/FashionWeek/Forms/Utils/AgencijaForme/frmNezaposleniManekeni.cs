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

public partial class frmNezaposleniManekeni : Form
{
    #region Funkcije
    public async void UcitajPodatke()
    {
        lvManekeni.Items.Clear();
        IList<ManekenNezaposlenPregled> manekeni = await DTOManager.VratiNezaposleneManeken();
        foreach (var maneken in manekeni)
        {
            ListViewItem item = new ListViewItem(new string[] { maneken.MBR, maneken.Ime.LicnoIme, maneken.Ime.Prezime, maneken.DatumRodjenja.ToShortDateString(), maneken.Pol.ToString(), maneken.Zanimanje });
            lvManekeni.Items.Add(item);
        }
        lvManekeni.Refresh();
    }
    #endregion

    public frmNezaposleniManekeni()
    {
        InitializeComponent();
    }

    private void frmNezaposleniManekeni_Load(object sender, EventArgs e)
    {
        UcitajPodatke();
    }

    private void lvManekeni_SelectedIndexChanged(object sender, EventArgs e)

    {
        if (lvManekeni.SelectedItems.Count > 0)
        {
            btnZaposliManekena.Enabled = true;
        }
        else
        {
            btnZaposliManekena.Enabled = false;
        }
    }

    private async void btnZaposliManekena_Click(object sender, EventArgs e)
    {
        if (await DTOManager.ZaposliManekena(lvManekeni.SelectedItems[0].Text, frmAgencije._modnaAgencija.PIB))
        {
                MessageBox.Show("Maneken je uspešno zapošljen!");
                UcitajPodatke();
                btnZaposliManekena.Enabled = false;
        }
    }

    private void btnOdustani_Click(object sender, EventArgs e)
    {
        Close();
    }
}

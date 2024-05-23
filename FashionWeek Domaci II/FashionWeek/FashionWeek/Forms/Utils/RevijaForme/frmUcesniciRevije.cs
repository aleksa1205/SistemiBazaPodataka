using FashionWeek.DTO;
using FashionWeek.Entiteti;
using FashionWeek.Forms.Utils.RevijaForme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FashionWeek.Forms.Utils.Revija;

public partial class frmUcesniciRevije : Form
{
    #region Funkcije
    public async void UcitajPodatke()
    {
        lvManekeni.Items.Clear();
        IList<ManekenPregled> manekeni = await DTOManager.VratiManekeneModneRevije(frmRevije._rbrRevije);
        foreach (var maneken in manekeni)
        {
            ListViewItem item = new ListViewItem(new string[] { maneken.MBR, maneken.Ime.LicnoIme, maneken.Ime.Prezime, maneken.DatumRodjenja.ToShortDateString(), maneken.Pol.ToString() });
            lvManekeni.Items.Add(item);
        }
        lvManekeni.Refresh();
    }
    #endregion
    public frmUcesniciRevije()
    {
        InitializeComponent();
    }

    private void frmUcesniciRevije_Load(object sender, EventArgs e)
    {
        //lblRevija.Text += frmRevije._revija.Naziv;
        UcitajPodatke();
    }

    private void lvManekeni_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lvManekeni.SelectedItems.Count > 0)
        {
            btnObrisiManekena.Enabled = true;
        }
        else
        {
            btnObrisiManekena.Enabled = false;
        }
    }

    private void btnDodajManekena_Click(object sender, EventArgs e)
    {
        frmDodajManekenaReviji frmDodajManekena = new frmDodajManekenaReviji();
        frmDodajManekena.ShowDialog();
        UcitajPodatke();
    }

    private async void btnObrisiManekena_Click(object sender, EventArgs e)
    {

        if (await DTOManager.ObrisiRevijuManekenu(lvManekeni.SelectedItems[0].Text, frmRevije._rbrRevije))
        {
            MessageBox.Show("Uspešno obrisan maneken!");
            UcitajPodatke();
        }
    }

    private void btnIzadji_Click(object sender, EventArgs e)
    {
        Close();
    }
}

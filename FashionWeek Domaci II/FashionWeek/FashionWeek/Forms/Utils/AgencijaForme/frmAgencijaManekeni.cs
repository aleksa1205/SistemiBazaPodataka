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

public partial class frmAgencijaManekeni : Form
{
    #region Funkcije
    public async void UcitajPodatke()
    {
        lvManekeni.Items.Clear();
        IList<ManekenPregled> listaManekena = await DTOManager.VratiManekeneModneAgencije(frmAgencije._modnaAgencijaPIB!);
        foreach (var maneken in listaManekena)
        {
            ListViewItem item = new ListViewItem(new string[] { maneken.MBR!, maneken.Ime?.LicnoIme!, maneken.Ime?.Prezime!, maneken.DatumRodjenja.ToShortDateString(), maneken.Pol.ToString() });
            lvManekeni.Items.Add(item);
        }
        lvManekeni.Refresh();
    }
    #endregion

    public frmAgencijaManekeni()
    {
        InitializeComponent();
    }

    private void frmAgencijaManekeni_Load(object sender, EventArgs e)
    {
        //lblListaManekenaAgencije.Text += frmAgencije._modnaAgencija?.Naziv;
        UcitajPodatke();
    }

    private void lvManekeni_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lvManekeni.SelectedItems.Count > 0)
        {
            btnOtpustiManekena.Enabled = true;
        }
        else
        {
            btnOtpustiManekena.Enabled = false;
        }
    }

    private void btnZaposliManekena_Click(object sender, EventArgs e)
    {
        frmNezaposleniManekeni frmNezaposleni = new frmNezaposleniManekeni();
        frmNezaposleni.ShowDialog();
        UcitajPodatke();
        btnOtpustiManekena.Enabled = false;
    }

    private async void btnOtpustiManekena_Click(object sender, EventArgs e)
    {
        if (await DTOManager.DajOtkazManeken(lvManekeni.SelectedItems[0].Text))
        {
            MessageBox.Show("Uspešno otpušten maneken!");
            UcitajPodatke();
            btnOtpustiManekena.Enabled = false;
        }
    }

    private void btnIzadji_Click(object sender, EventArgs e)
    {
        Close();
    }

}

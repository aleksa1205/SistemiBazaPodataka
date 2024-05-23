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
        IList<ManekenPregled> listaManekena = await DTOManager.VratiManekeneModneAgencijePregled(frmAgencije._modnaAgencija!);
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
        lblListaManekenaAgencije.Text += frmAgencije._modnaAgencija?.Naziv;
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

    private async void btnOtpustiManekena_Click(object sender, EventArgs e)
    {
        //PROMENI
        Maneken maneken = await DTOManager.VratiManekena(lvManekeni.SelectedItems[0].Text);
        if (maneken != null)
        {
            if (await DTOManager.DajOtkazManeken(maneken))
            {
                MessageBox.Show($"Uspešno otpušten maneken {maneken.Ime.ToString()}");
                UcitajPodatke();
                btnOtpustiManekena.Enabled = false;
            }
        }
        else
        {
            MessageBox.Show("Greška pri pribavljanju manekena iz baze!");
        }
    }

    private void btnIzadji_Click(object sender, EventArgs e)
    {
        Close();
    }
}

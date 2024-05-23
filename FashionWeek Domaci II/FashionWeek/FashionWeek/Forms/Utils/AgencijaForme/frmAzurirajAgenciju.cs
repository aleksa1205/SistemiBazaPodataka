using FashionWeek.DTO;
using FashionWeek.Entiteti;
using FashionWeek.Entiteti.Helper;
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

public partial class frmAzurirajAgenciju : Form
{
    #region Funkcije
    public void Ucitaj()
    {
        txtPIB.Text = frmAgencije._modnaAgencija?.PIB;
        txtNaziv.Text = frmAgencije._modnaAgencija?.Naziv;
        dtpDatumOsnivanja.Value = frmAgencije._modnaAgencija!.DatumOsnivanja;
        txtDrzava.Text = frmAgencije._modnaAgencija.Sediste?.Drzava;
        txtGrad.Text = frmAgencije._modnaAgencija.Sediste?.Grad;
        txtUlica.Text = frmAgencije._modnaAgencija.Sediste?.Ulica;
        if (frmAgencije._modnaAgencija is InostranaAgencija)
        {
            rbInostrana.Checked = true;
        }
        else
        {
            rbDomaca.Checked = true;
        }
    }

    public void Procitaj(ModnaAgencija agencija)
    {
        agencija.Naziv = txtNaziv.Text;
        agencija.DatumOsnivanja = dtpDatumOsnivanja.Value;
        agencija.Sediste = new Adresa(txtDrzava.Text, txtGrad.Text, txtUlica.Text);
    }
    #endregion

    public frmAzurirajAgenciju()
    {
        InitializeComponent();
    }

    private void frmAzurirajAgenciju_Load(object sender, EventArgs e)
    {
        if (frmAgencije._modnaAgencija != null)
        {
            Ucitaj();
            txtPIB.Enabled = false;
            gbTip.Enabled = false;
        }
        else
        {
            MessageBox.Show("Greška pri učitavanju modne agencije!");
            Close();
        }
    }

    private async void btnSacuvaj_Click(object sender, EventArgs e)
    {
        Procitaj(frmAgencije._modnaAgencija);
        if(await DTOManager.AzurirajModnuAgenciju(frmAgencije._modnaAgencija))
        {
            MessageBox.Show("Uspešno ažurirana modna agencija!");
            Close();
        }
    }

    private void btnOdustani_Click(object sender, EventArgs e)
    {
        Close();
    }
}

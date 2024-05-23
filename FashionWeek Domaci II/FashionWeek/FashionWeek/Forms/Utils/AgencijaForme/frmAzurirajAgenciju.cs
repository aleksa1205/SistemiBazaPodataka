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
    ModnaAgencijaBasic? modnaAgencija = null;
    #region Funkcije
    public async void Ucitaj()
    {
        modnaAgencija = await DTOManager.VratiModnuAgenciju(frmAgencije._modnaAgencijaPIB);
        if (modnaAgencija != null)
        {
            txtPIB.Text = modnaAgencija.PIB;
            txtNaziv.Text = modnaAgencija.Naziv;
            dtpDatumOsnivanja.Value = modnaAgencija.DatumOsnivanja;
            txtDrzava.Text = modnaAgencija.Sediste?.Drzava;
            txtGrad.Text = modnaAgencija.Sediste?.Grad;
            txtUlica.Text = modnaAgencija.Sediste?.Ulica;
            if (modnaAgencija is InostranaAgencijaBasic)
            {
                rbInostrana.Checked = true;
            }
            else
            {
                rbDomaca.Checked = true;
            }
        }
        else
        {
            MessageBox.Show("Greška pri učitavanju modne agencije!");
            Close();
        }
    }

    public void Procitaj()
    {
        modnaAgencija!.Naziv = txtNaziv.Text;
        modnaAgencija.DatumOsnivanja = dtpDatumOsnivanja.Value;
        modnaAgencija.Sediste.Drzava = txtDrzava.Text;
        modnaAgencija.Sediste.Grad = txtGrad.Text;
        modnaAgencija.Sediste.Ulica = txtUlica.Text;

    }
    #endregion

    public frmAzurirajAgenciju()
    {
        InitializeComponent();
    }

    private void frmAzurirajAgenciju_Load(object sender, EventArgs e)
    {

        Ucitaj();
        txtPIB.Enabled = false;
        gbTip.Enabled = false;
    }

    private async void btnSacuvaj_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtNaziv.Text))
        {
            MessageBox.Show("Polje naziv mora biti popunjeno!");
            return;
        }
        Procitaj();
        if(await DTOManager.AzurirajModnuAgenciju(modnaAgencija!))
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

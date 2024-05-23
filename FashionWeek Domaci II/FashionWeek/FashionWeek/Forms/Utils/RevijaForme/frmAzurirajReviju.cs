using FashionWeek.DTO;
using FashionWeek.Entiteti;
using FashionWeek.Entiteti.Helper;
using FashionWeek.Forms.Utils.Revija;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FashionWeek.Forms.Utils.RevijaForme;

public partial class frmAzurirajReviju : Form
{
    public ModnaRevijaBasic? revija = null;
    #region Funkcije
    public async void Ucitaj()
    {
        revija = await DTOManager.VratiModnuReviju(frmRevije._rbrRevije);
        if (revija != null)
        {
            txtRBR.Text = revija.RBR.ToString();
            txtNaziv.Text = revija.Naziv;
            dtpTermin.Value = revija.Termin;
            txtDrzava.Text = revija.Mesto?.Drzava;
            txtGrad.Text = revija.Mesto?.Grad;
            txtUlica.Text = revija.Mesto?.Ulica;
        }
        else
        {
            MessageBox.Show("Greška pri učitavanju modne revije!");
        }
    }

    public void Procitaj()
    {
        revija!.Naziv = txtNaziv.Text;
        revija.Termin = dtpTermin.Value;
        revija.Mesto.Drzava=txtDrzava.Text;
        revija.Mesto.Grad = txtGrad.Text;
        revija.Mesto.Ulica = txtUlica.Text;

    }
    #endregion

    public frmAzurirajReviju()
    {
        InitializeComponent();
    }

    private void frmAzurirajReviju_Load(object sender, EventArgs e)
    {
        if (frmRevije._rbrRevije != null)
        {
            Ucitaj();
        }
        else
        {
            MessageBox.Show("Greška pri učitavanju modne revije!");
            Close();
        }
    }

    private async void btnAzuriraj_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtNaziv.Text))
        {
            MessageBox.Show("Polje naziv ne sme biti prazno!");
            return;
        }
        Procitaj();
        if (await DTOManager.AzurirajReviju(revija))
        {
            MessageBox.Show("Revija uspešno ažurirana!");
            Close();
        }
    }

    private void btnOdustani_Click(object sender, EventArgs e)
    {
        Close();
    }
}

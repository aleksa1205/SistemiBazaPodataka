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

namespace FashionWeek.Forms.Utils.RevijaForme;

public partial class frmDodajReviju : Form
{
    public frmDodajReviju()
    {
        InitializeComponent();
    }

    private async void btnSacuvaj_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtNaziv.Text))
        {
            MessageBox.Show("Polje naziv ne sme biti prazno!");
            return;
        }
        ModnaRevijaBasic revija = new ModnaRevijaBasic()
        {
            Naziv = txtNaziv.Text,
            Termin = dtpTermin.Value,
            Mesto = new Adresa(txtDrzava.Text, txtGrad.Text, txtUlica.Text)
        };
        //revija.Mesto.Drzava = txtDrzava.Text;
        //revija.Mesto.Grad = txtGrad.Text;
        //revija.Mesto.Ulica = txtUlica.Text;

        if (await DTOManager.DodajReviju(revija))
        {
            MessageBox.Show($"Revija {revija.Naziv} je uspešno dodata!");
            Close();
        }
    }

    private void btnOdustani_Click(object sender, EventArgs e)
    {
        Close();
    }
}

using FashionWeek.DTO;
using FashionWeek.Entiteti;
using FashionWeek.Entiteti.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FashionWeek.Forms.Utils.Agencija
{
    public partial class frmDodajAgenciju : Form
    {
        #region Funkcije
        private bool ProveriBrojeve(string numbers)
        {
            foreach (var ch in numbers)
            {
                if (ch <= 0 || ch >= 9)
                {
                    return false;
                }
            }
            return true;
        }

        private bool ProveriPolja()
        {
            bool checker = true;
            StringBuilder stringBuilder = new StringBuilder();
            if (string.IsNullOrEmpty(txtPIB.Text))
            {
                stringBuilder.AppendLine("Polje PIB ne sme biti prazno!");
                checker = false;
            }
            if (string.IsNullOrEmpty(txtNaziv.Text))
            {
                stringBuilder.AppendLine("Polje Naziv ne sme biti prazno!");
                checker = false;
            }
            if (txtPIB.Text.Length != 8)
            {
                stringBuilder.AppendLine("Polje PIB mora biti dužine 8!");
                checker = false;
            }
            if (ProveriBrojeve(txtPIB.Text))
            {
                stringBuilder.AppendLine("U polje PIB mogu biti upisani samo brojevi!");
                checker = false;
            }
            if (!checker)
            {
                MessageBox.Show(stringBuilder.ToString());
            }
            return checker;
        }
        #endregion

        public frmDodajAgenciju()
        {
            InitializeComponent();
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if(!ProveriPolja())
            {
                return;
            }
            ModnaAgencija agencija = await DTOManager.VratiModnuAgenciju(txtPIB.Text);
            if (agencija != null)
            {
                MessageBox.Show($"Modna agencija sa PIB-om {txtPIB.Text} već postoji!");
                return;
            }
            if (rbDomaca.Checked)
            {
                agencija = new DomacaAgencija
                {
                    PIB = txtPIB.Text,
                    Naziv = txtNaziv.Text,
                    Inostrana = 'N',
                    DatumOsnivanja = dtpDatumOsnivanja.Value,
                    Sediste = new Adresa()
                };
            }
            else
            {
                agencija = new InostranaAgencija
                {
                    PIB = txtPIB.Text,
                    Naziv = txtNaziv.Text,
                    Inostrana = 'Y',
                    DatumOsnivanja = dtpDatumOsnivanja.Value,
                    Sediste = new Adresa()
                };
            }
            agencija.Sediste.Drzava = txtDrzava.Text;
            agencija.Sediste.Grad = txtGrad.Text;
            agencija.Sediste.Ulica = txtUlica.Text;

            if (await DTOManager.DodajModnuAgenciju(agencija))
            {
                MessageBox.Show($"Modna agencija {agencija.PIB}: {agencija.Naziv} je uspešno dodata!");
                Close();
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

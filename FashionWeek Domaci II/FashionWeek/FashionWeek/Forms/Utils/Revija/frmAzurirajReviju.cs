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

namespace FashionWeek.Forms.Utils.Revija
{
    public partial class frmAzurirajReviju : Form
    {
        #region Funkcije
        public void Ucitaj()
        {
            txtRBR.Text = frmRevije._revija.RBR.ToString();
            txtNaziv.Text = frmRevije._revija.Naziv;
            dtpTermin.Value = frmRevije._revija.Termin;
            txtDrzava.Text = frmRevije._revija.Mesto?.Drzava;
            txtGrad.Text = frmRevije._revija.Mesto?.Grad;
            txtUlica.Text = frmRevije._revija.Mesto?.Ulica;
        }

        public void Procitaj(ModnaRevija revija)
        {
            revija.Naziv = txtNaziv.Text;
            revija.Termin = dtpTermin.Value;
            revija.Mesto.Drzava = txtDrzava.Text;
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
            if (frmRevije._revija != null)
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
            Procitaj(frmRevije._revija);
            if(await DTOManager.AzurirajReviju(frmRevije._revija))
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
}

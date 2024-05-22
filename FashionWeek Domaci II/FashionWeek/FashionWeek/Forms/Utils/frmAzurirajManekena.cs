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

namespace FashionWeek.Forms.Utils
{
    public partial class frmAzurirajManekena : Form
    {
        public frmAzurirajManekena()
        {
            InitializeComponent();
        }

        #region Funkcije
        private bool ProveriBrojeve(string number)
        {
            foreach (char ch in number)
            {
                if (ch <= 0 && ch >= 9 && ch != '.')
                {
                    return false;
                }
            }
            return true;
        }

        private void ProveriPolja()
        {
            bool checker = true;
            StringBuilder stringBuilder = new StringBuilder();
            if (String.IsNullOrEmpty(txtMBR.Text))
            {
                stringBuilder.AppendLine("Polje MBR mora biti popunjeno!");
                checker = false;
            }
            if (string.IsNullOrEmpty(txtIme.Text))
            {
                stringBuilder.AppendLine("Polje Ime mora biti popunjeno!");
                checker = false;
            }
            if (string.IsNullOrEmpty(txtPrezime.Text))
            {
                stringBuilder.AppendLine("Polje Prezime mora biti popunjeno!");
                checker = false;
            }
            if (cmbPol.SelectedIndex == -1)
            {
                stringBuilder.AppendLine("Mora biti izabran jedan od dva ponuđena pola!");
                checker = false;
            }
            if (txtMBR.Text.Length != 13)
            {
                stringBuilder.AppendLine("MBR mora biti dužine 13!");
                checker = false;
            }
            if (!ProveriBrojeve(txtVisina.Text))
            {
                stringBuilder.AppendLine("U polje za visinu mogu se unositi samo brojevi!");
                checker = false;
            }
            if (!ProveriBrojeve(txtTezina.Text))
            {
                stringBuilder.AppendLine("U polje za težinu mogu se unositi samo brojevi!");
                checker = false;
            }
            if (!checker)
            {
                MessageBox.Show(stringBuilder.ToString());
            }
        }

        public void Ucitaj()
        {
            txtMBR.Text = frmManekeni._maneken.MBR;
            txtIme.Text = frmManekeni._maneken.Ime.LicnoIme;
            txtPrezime.Text = frmManekeni._maneken.Ime.Prezime;
            dtpDatumRodjenja.Value = frmManekeni._maneken.DatumRodjenja;
            //cmbPol.SelectedText = frmManekeni._maneken.Pol.ToString();
            cmbPol.SelectedIndex=cmbPol.FindString(frmManekeni._maneken.Pol.ToString());
            txtVisina.Text = frmManekeni._maneken.Visina.ToString();
            txtTezina.Text = frmManekeni._maneken.Tezina.ToString();
            txtBojaOciju.Text = frmManekeni._maneken.BojaOciju;
            txtBojaKose.Text = frmManekeni._maneken.BojaKose;
            txtKonfBroj.Text = frmManekeni._maneken.KonfekcijskiBroj;
            txtZanimanje.Text = frmManekeni._maneken.Zanimanje;
        }

        public void Procitaj(Maneken maneken)
        {
            maneken.Ime.LicnoIme = txtIme.Text;
            maneken.Ime.Prezime = txtPrezime.Text;
            maneken.DatumRodjenja = dtpDatumRodjenja.Value;
            maneken.Pol = (cmbPol.SelectedItem!.ToString()!)[0];
            maneken.Visina = Int32.Parse(txtVisina.Text);
            maneken.Tezina = Double.Parse(txtTezina.Text);
            maneken.BojaOciju = txtBojaOciju.Text;
            maneken.BojaKose = txtBojaKose.Text;
            maneken.KonfekcijskiBroj = txtKonfBroj.Text;
            maneken.Zanimanje = txtZanimanje.Text;
        }
        #endregion

        private void frmAzurirajManekena_Load(object sender, EventArgs e)
        {
            if (frmManekeni._maneken != null)
            {
                Ucitaj();
                txtMBR.Enabled = false;
            }
            else
            {
                MessageBox.Show("Greška pri učitavanju manekena!");
                Close();
            }
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            try
            {
                Procitaj(frmManekeni._maneken);
                ProveriPolja();
                DTOManager.AzurirajManekena(frmManekeni._maneken);
                MessageBox.Show("Uspešno ažuriran maneken!");
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

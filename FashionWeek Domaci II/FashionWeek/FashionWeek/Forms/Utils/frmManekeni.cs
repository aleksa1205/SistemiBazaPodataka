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
    public partial class frmManekeni : Form
    {
        public static Maneken _maneken = null!;
        public frmManekeni()
        {
            InitializeComponent();
        }

        #region Funkcije
        public async void UcitajPodatke()
        {
            IList<ManekenPregled> listaManekena = await DTOManager.VratiManekene();
            foreach (var maneken in listaManekena)
            {
                ListViewItem item = new ListViewItem(new string[] { maneken.MBR, maneken.Ime?.LicnoIme!, maneken.Ime?.Prezime!, maneken.DatumRodjenja.ToShortDateString(), maneken.Pol.ToString() });
                lvManekeni.Items.Add(item);
            }
            lvManekeni.Refresh();
            return;
        }
        #endregion


        private void frmManekeni_Load(object sender, EventArgs e)
        {
            try
            {
                UcitajPodatke();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lvManekeni_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAzurirajManekena.Enabled = true;
            btnObrisiManekena.Enabled = true;
        }

        private void btnDodajManekena_Click(object sender, EventArgs e)
        {
            frmDodajManekena frmDodaj = new frmDodajManekena();
            frmDodaj.ShowDialog();
            lvManekeni.Items.Clear();
            UcitajPodatke();
        }

        private async void btnAzurirajManekena_Click(object sender, EventArgs e)
        {
            _maneken = await DTOManager.VratiManekena(lvManekeni.SelectedItems[0].Text);
            frmAzurirajManekena frmAzuriraj = new frmAzurirajManekena();
            frmAzuriraj.ShowDialog();
            lvManekeni.Items.Clear();
            btnAzurirajManekena.Enabled = false;
            btnObrisiManekena.Enabled = false;
            UcitajPodatke();
        }

        private async void btnObrisiManekena_Click(object sender, EventArgs e)
        {
            try
            {
                _maneken = await DTOManager.VratiManekena(lvManekeni.SelectedItems[0].Text);
                DTOManager.ObrisiManekena(_maneken);
                MessageBox.Show("Uspešno obrisan maneken!");
                lvManekeni.Items.Clear();
                btnAzurirajManekena.Enabled = false;
                btnObrisiManekena.Enabled = false;
                UcitajPodatke();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Brisanje greška:" + ex.Message);
            }
        }
    }
}

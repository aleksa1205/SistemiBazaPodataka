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
        public static Maneken? _maneken = null;
        public frmManekeni()
        {
            InitializeComponent();
        }

        #region Funkcije
        public void EnableButtons()
        {
            btnAzurirajManekena.Enabled = true;
            btnObrisiManekena.Enabled = true;
            btnZaposliManekena.Enabled = true;
            btnRevije.Enabled = true;
        }

        public void DisableButtons()
        {
            btnAzurirajManekena.Enabled = false;
            btnObrisiManekena.Enabled = false;
            btnZaposliManekena.Enabled = false;
            btnRevije.Enabled = false;
        }

        public async void UcitajPodatke()
        {
            lvManekeni.Items.Clear();
            IList<ManekenPregled> listaManekena = await DTOManager.VratiManekene();
            foreach (var maneken in listaManekena)
            {
                ListViewItem item = new ListViewItem(new string[] { maneken.MBR, maneken.Ime?.LicnoIme!, maneken.Ime?.Prezime!, maneken.DatumRodjenja.ToShortDateString(), maneken.Pol.ToString() });
                lvManekeni.Items.Add(item);
            }
            lvManekeni.Refresh();
        }
        #endregion


        private void frmManekeni_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void lvManekeni_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableButtons();
        }

        private void btnDodajManekena_Click(object sender, EventArgs e)
        {
            frmDodajManekena frmDodaj = new frmDodajManekena();
            frmDodaj.ShowDialog();
            UcitajPodatke();
        }

        private async void btnAzurirajManekena_Click(object sender, EventArgs e)
        {
            _maneken = await DTOManager.VratiManekena(lvManekeni.SelectedItems[0].Text);
            frmAzurirajManekena frmAzuriraj = new frmAzurirajManekena();
            frmAzuriraj.ShowDialog();
            DisableButtons();
            UcitajPodatke();
        }

        private async void btnObrisiManekena_Click(object sender, EventArgs e)
        {
            _maneken = await DTOManager.VratiManekena(lvManekeni.SelectedItems[0].Text);
            if (_maneken != null) 
            {
                await DTOManager.ObrisiManekena(_maneken);
                MessageBox.Show("Uspešno obrisan maneken!");
                DisableButtons();
                UcitajPodatke();
            }
            else
            {
                MessageBox.Show("Greška pri brisanju manekena!");
            }
        }

        private async void btnRevije_Click(object sender, EventArgs e)
        {
            _maneken = await DTOManager.VratiManekena(lvManekeni.SelectedItems[0].Text);
            if (_maneken != null)
            {
                frmRevije frmRevije = new frmRevije();
                frmRevije.ShowDialog();
            }
            else
            {
                MessageBox.Show("Greška pri otvaranju revija manekena!");
            }
        }
    }
}

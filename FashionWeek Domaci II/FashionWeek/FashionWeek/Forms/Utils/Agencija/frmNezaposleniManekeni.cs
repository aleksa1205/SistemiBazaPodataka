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

namespace FashionWeek.Forms.Utils.Agencija
{
    public partial class frmNezaposleniManekeni : Form
    {
        #region Funkcije
        public async void UcitajPodatke()
        {
            lvManekeni.Items.Clear();
            IList<ManekenPregled> manekeni = await DTOManager.VratiNezaposleneManeken();
            foreach (var maneken in manekeni)
            {
                ListViewItem item = new ListViewItem(new string[] { maneken.MBR, maneken.Ime.LicnoIme, maneken.Ime.Prezime, maneken.DatumRodjenja.ToShortDateString(), maneken.Pol.ToString() });
                lvManekeni.Items.Add(item);
            }
            lvManekeni.Refresh();
        }
        #endregion

        public frmNezaposleniManekeni()
        {
            InitializeComponent();
        }

        private void frmNezaposleniManekeni_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void lvManekeni_SelectedIndexChanged(object sender, EventArgs e)

        {
            if (lvManekeni.SelectedItems.Count > 0)
            {
                btnZaposliManekena.Enabled = true;
            }
            else
            {
                btnZaposliManekena.Enabled = false;
            }
        }

        private async void btnZaposliManekena_Click(object sender, EventArgs e)
        {
            Maneken maneken = await DTOManager.VratiManekena(lvManekeni.SelectedItems[0].Text);
            if (maneken != null)
            {
                if(await DTOManager.ZaposliManekena(maneken, frmAgencije._modnaAgencija))
                {
                    MessageBox.Show($"Maneken {maneken.Ime.ToString()} je uspešno zapošljen!");
                    UcitajPodatke();
                    btnZaposliManekena.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Greška pri pribavljanu manekena iz baze!");
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

using FashionWeek.DTO;
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
                ListViewItem item = new ListViewItem(new string[] { maneken.MBR, maneken.Ime.LicnoIme, maneken.Ime?.Prezime, maneken.DatumRodjenja.ToShortDateString(), maneken.Pol.ToString() });
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

        private void btnDodajManekena_Click(object sender, EventArgs e)
        {
            frmDodajManekena frmDodaj = new frmDodajManekena();
            frmDodaj.ShowDialog();
        }
    }
}

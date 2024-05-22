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

namespace FashionWeek.Forms.Utils.Agencija
{
    public partial class frmAgencijaManekeni : Form
    {
        #region Funkcije
        public async void Ucitaj()
        {
            lvManekeni.Items.Clear();
            IList<ManekenPregled> listaManekena = await DTOManager.VratiManekeneModneAgencijePregled(frmAgencije._modnaAgencija!);
            foreach (var maneken in listaManekena)
            {
                ListViewItem item = new ListViewItem(new string[] { maneken.MBR, maneken.Ime?.LicnoIme!, maneken.Ime?.Prezime!, maneken.DatumRodjenja.ToShortDateString(), maneken.Pol.ToString() });
                lvManekeni.Items.Add(item);
            }
            lvManekeni.Refresh();
        }
        #endregion

        public frmAgencijaManekeni()
        {
            InitializeComponent();
        }

        private void frmAgencijaManekeni_Load(object sender, EventArgs e)
        {
            lblListaManekenaAgencije.Text += frmAgencije._modnaAgencija?.Naziv;
            Ucitaj();
        }
    }
}

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
    public partial class frmRevijeManekena : Form
    {
        public frmRevijeManekena()
        {
            InitializeComponent();
        }

        #region Funkcije
        public void EnableButtons()
        {
            btnObrisiReviju.Enabled = true;
        }

        public void DisableButtons()
        {
            btnObrisiReviju.Enabled = false;
        }

        public async void UcitajPodatke()
        {
            IList<ModnaRevijaPregled> listaRevija = await DTOManager.VratiModneRevijaManekena(frmManekeni._maneken);
            foreach (var revija in listaRevija)
            {
                ListViewItem item = new ListViewItem(new string[] { revija.RBR.ToString(), revija.Naziv, revija.Mesto!.ToString(), revija.Termin.ToShortDateString() });
                lvRevije.Items.Add(item);
            }
            lvRevije.Refresh();
        }
        #endregion

        private void frmRevije_Load(object sender, EventArgs e)
        {
            try
            {
                lblRevije.Text += frmManekeni._maneken.Ime.ToString() + ':';
                UcitajPodatke();
                DisableButtons();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lvRevije_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableButtons();
        }
        private async void btnObrisiReviju_Click(object sender, EventArgs e)
        {
            ModnaRevija revija = await DTOManager.VratiModnuReviju(Int32.Parse(lvRevije.SelectedItems[0].Text));
            Maneken maneken = await DTOManager.VratiManekena(frmManekeni._maneken.MBR);
            DTOManager.ObrisiRevijuManekenu(maneken, revija);
        }
        private void btnDodajReviju_Click(object sender, EventArgs e)
        {
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}

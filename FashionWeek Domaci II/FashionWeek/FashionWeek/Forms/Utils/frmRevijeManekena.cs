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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lvRevije_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvRevije.SelectedItems.Count > 0)
            {
                btnObrisiReviju.Enabled = true;
            }
            else
            {
                btnObrisiReviju.Enabled = false;
            }
        }

        private void btnDodajReviju_Click(object sender, EventArgs e)
        {
        }

        private async void btnObrisiReviju_Click(object sender, EventArgs e)
        {
            ModnaRevija revija = await DTOManager.VratiModnuReviju(Int32.Parse(lvRevije.SelectedItems[0].Text));
            if (revija != null)
            {
                if(await DTOManager.ObrisiRevijuManekenu(revija, frmManekeni._maneken))
                {
                    MessageBox.Show($"Revija {revija.Naziv} je obrisana iz spiska revija manekena!");
                    UcitajPodatke();
                    btnObrisiReviju.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Greška pri pribavljanju manekena i revije iz baze!");
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}

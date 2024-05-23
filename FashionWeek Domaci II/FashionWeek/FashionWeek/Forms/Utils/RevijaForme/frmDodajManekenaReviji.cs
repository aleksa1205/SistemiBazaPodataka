using FashionWeek.DTO;
using FashionWeek.Forms.Utils.Revija;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FashionWeek.Forms.Utils.RevijaForme
{
    public partial class frmDodajManekenaReviji : Form
    {
        #region Funkcije
        public async void UcitajPodatke()
        {
            lvManekeni.Items.Clear();
            IList<ManekenPregled> listaManekena = await DTOManager.VratiManekenKojeNisuNaModnojReviji(frmRevije._revija);
            foreach (var maneken in listaManekena)
            {
                ListViewItem item = new ListViewItem(new string[] { maneken.MBR, maneken.Ime?.LicnoIme!, maneken.Ime?.Prezime!, maneken.DatumRodjenja.ToShortDateString(), maneken.Pol.ToString() });
                lvManekeni.Items.Add(item);
            }
            lvManekeni.Refresh();
        }
        #endregion
        public frmDodajManekenaReviji()
        {
            InitializeComponent();
        }

        private void frmDodajManekenaReviji_Load(object sender, EventArgs e)
        {
            lblListaManekena.Text += frmRevije._revija.Naziv + ':';
            UcitajPodatke();
        }

        private void lvManekeni_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvManekeni.SelectedItems.Count > 0)
            {
                btnDodajManekena.Enabled = true;
            }
            else
            {
                btnDodajManekena.Enabled = false;
            }
        }

        private async void btnDodajManekena_Click(object sender, EventArgs e)
        {
            if(await DTOManager.DodajRevijuManekenu(lvManekeni.SelectedItems[0].Text, frmRevije._revija.RBR))
            {
                MessageBox.Show("Uspešno dodat maneken!");
                UcitajPodatke();
                btnDodajManekena.Enabled = false;
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

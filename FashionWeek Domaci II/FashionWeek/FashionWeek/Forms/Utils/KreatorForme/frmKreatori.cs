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

namespace FashionWeek.Forms.Utils.KreatorForme
{
    public partial class frmKreatori : Form
    {
        #region Funkcije
        public void EnableButtons()
        {
            btnAzurirajKreatora.Enabled = true;
            btnObrisiKreatora.Enabled = true;
        }

        public void DisableButtons()
        {
            btnAzurirajKreatora.Enabled = false;
            btnObrisiKreatora.Enabled = false;
        }

        public async void UcitajPodatke()
        {
            lvKreatori.Items.Clear();
            IList<ModniKreatorPregled> kreatori = await DTOManager.VratiModneKreatore();
            foreach (var kreator in kreatori)
            {
                ListViewItem item = new ListViewItem(new string[] { kreator.MBR, kreator.Ime.LicnoIme, kreator.Ime.Prezime, kreator.DatumRodjenja.ToShortDateString(), kreator.Pol.ToString(), kreator.ZemljaPorekla, kreator.RadiU });
                lvKreatori.Items.Add(item);
            }
            lvKreatori.Refresh();
        }
        #endregion
        public frmKreatori()
        {
            InitializeComponent();
        }

        private void frmKreatori_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void lvKreatori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvKreatori.SelectedItems.Count > 0)
            {
                EnableButtons();
            }
            else
            {
                DisableButtons();
            }
        }
    }
}

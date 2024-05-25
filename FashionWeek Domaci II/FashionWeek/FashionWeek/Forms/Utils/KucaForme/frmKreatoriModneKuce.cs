namespace FashionWeek.Forms.Utils.KucaForme
{
    public partial class frmKreatoriModneKuce : Form
    {
        private ModnaKucaBasic _kuca;

        public frmKreatoriModneKuce(ModnaKucaBasic kuca)
        {
            InitializeComponent();
            _kuca = kuca;
        }

        #region Funkcije
        private async void UcitajPodatke()
        {
            lvKreatori.Items.Clear();
            IList<ModniKreatorPregled> listaKreatora = await DTOManager.VratiModneKreatoreModneKuce(_kuca.Naziv);
            foreach (var kreator in listaKreatora)
            {
                ListViewItem item = new ListViewItem(new string[] { kreator.MBR, kreator.Ime.LicnoIme, kreator.Ime.Prezime, kreator.DatumRodjenja.ToShortDateString(), kreator.Pol.ToString(), kreator.ZemljaPorekla });
                lvKreatori.Items.Add(item);
            }
            lvKreatori.Refresh();
        }
        #endregion

        private void frmKreatoriModneKuce_Load(object sender, EventArgs e)
        {
            lblListaKreatora.Text += _kuca.Naziv + ':';
            UcitajPodatke();
        }

        private void lvKreatori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvKreatori.SelectedItems.Count > 0)
            {
                btnObrisiKreatora.Enabled = true;
            }
            else
            {
                btnObrisiKreatora.Enabled = false;
            }
        }

        private void btnZaposliKreatora_Click(object sender, EventArgs e)
        {
            frmZaposliKreatora frmZaposli = new frmZaposliKreatora(_kuca.Naziv);
            frmZaposli.ShowDialog();
            UcitajPodatke();
            lvKreatori.SelectedItems.Clear();
        }

        private async void btnObrisiKreatora_Click(object sender, EventArgs e)
        {
            if (await DTOManager.ObrisiModnuKucuModnomKreatoru(lvKreatori.SelectedItems[0].Text, _kuca.Naziv))
            {
                MessageBox.Show("Uspešno je otpušen kreator!");
                lvKreatori.SelectedItems.Clear();
                UcitajPodatke();
            }
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

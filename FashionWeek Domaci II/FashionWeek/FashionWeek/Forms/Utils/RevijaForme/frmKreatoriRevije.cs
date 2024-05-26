namespace FashionWeek.Forms.Utils.RevijaForme;

public partial class frmKreatoriRevije : Form
{
    private ModnaRevijaBasic _revija;

    public frmKreatoriRevije(ModnaRevijaBasic revija)
    {
        InitializeComponent();
        _revija = revija;
    }

    #region Funkcije
    private async void UcitajPodatke()
    {
        lvKreatori.Items.Clear();
        var kreatori = await DTOManager.VratiModneKreatoreModneRevije(_revija.RBR);
        foreach (var kreator in kreatori)
        {
            ListViewItem item = new ListViewItem(new string[] { kreator.MBR, kreator.Ime.LicnoIme, kreator.Ime.Prezime, kreator.DatumRodjenja.ToShortDateString(), kreator.Pol.ToString(), kreator.ZemljaPorekla, kreator.RadiU });
            lvKreatori.Items.Add(item);
        }
        lvKreatori.Refresh();
    }
    #endregion


    private void frmKreatoriRevije_Load(object sender, EventArgs e)
    {
        UcitajPodatke();
        lblListaKreatora.Text += _revija.Naziv + ':';
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

    private void btnDodajKreatora_Click(object sender, EventArgs e)
    {
        frmDodajKreatoraReviji frmDodajKreatora = new frmDodajKreatoraReviji(_revija);
        frmDodajKreatora.ShowDialog();
        UcitajPodatke();
        lvKreatori.SelectedItems.Clear();
    }

    private async void btnObrisiKreatora_Click(object sender, EventArgs e)
    {
        if (await DTOManager.ObrisiModnogKreatoraReviji(_revija.RBR, lvKreatori.SelectedItems[0].Text))
        {
            MessageBox.Show($"Modni kreator {lvKreatori.SelectedItems[0].SubItems[1].Text} {lvKreatori.SelectedItems[0].SubItems[2].Text} uspešno uklonjen sa revije {_revija.Naziv}!");
            UcitajPodatke();
            lvKreatori.SelectedItems.Clear();
        }
    }

    private void btnIzadji_Click(object sender, EventArgs e)
    {
        Close();
    }
}

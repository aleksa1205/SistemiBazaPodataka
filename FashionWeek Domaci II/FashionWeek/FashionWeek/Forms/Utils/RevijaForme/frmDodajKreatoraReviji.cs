namespace FashionWeek.Forms.Utils.RevijaForme;

public partial class frmDodajKreatoraReviji : Form
{
    private ModnaRevijaBasic _revija;

    public frmDodajKreatoraReviji(ModnaRevijaBasic revija)
    {
        InitializeComponent();
        _revija = revija;
    }

    #region Funkcije
    private async void UcitajPodatke()
    {
        lvKreatori.Items.Clear();
        var kreatori = await DTOManager.VratiModneKreatoreKojiNisuPovezaniSaRevijom(_revija.RBR);
        foreach (var kreator in kreatori)
        {
            ListViewItem item = new ListViewItem(new string[] { kreator.MBR, kreator.Ime.LicnoIme, kreator.Ime.Prezime, kreator.DatumRodjenja.ToShortDateString(), kreator.Pol.ToString(), kreator.ZemljaPorekla, kreator.RadiU });
            lvKreatori.Items.Add(item);
        }
        lvKreatori.Refresh();
    }
    #endregion

    private void frmDodajKreatoraReviji_Load(object sender, EventArgs e)
    {
        UcitajPodatke();
        lblListaKreatora.Text += _revija.Naziv + ':';
    }

    private void lvKreatori_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lvKreatori.SelectedItems.Count > 0)
        {
            btnDodajKreatora.Enabled = true;
        }
        else
        {
            btnDodajKreatora.Enabled = false;
        }
    }

    private async void btnDodajKreatora_Click(object sender, EventArgs e)
    {
        if(await DTOManager.DodajModnogKreatoraReviji(_revija.RBR, lvKreatori.SelectedItems[0].Text))
        {
            MessageBox.Show($"Uspešno dodat modni kreator {lvKreatori.SelectedItems[0].SubItems[1].Text} {lvKreatori.SelectedItems[0].SubItems[2].Text}!");
            UcitajPodatke();
            lvKreatori.SelectedItems.Clear();
        }
    }

    private void btnIzadji_Click(object sender, EventArgs e)
    {
        Close();
    }
}

namespace FashionWeek.Forms.Utils.KreatorForme;

public partial class frmKreatori : Form
{
    public static string? _kreatorMBR = null;
    public static string? _imeKreatora = null;
    #region Funkcije
    public void EnableButtons()
    {
        btnAzurirajKreatora.Enabled = true;
        btnObrisiKreatora.Enabled = true;
        btnRevije.Enabled = true;
    }

    public void DisableButtons()
    {
        btnAzurirajKreatora.Enabled = false;
        btnObrisiKreatora.Enabled = false;
        btnRevije.Enabled = false;
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
            _kreatorMBR = lvKreatori.SelectedItems[0].Text;
            _imeKreatora = lvKreatori.SelectedItems[0].SubItems[1].Text + ' ' +lvKreatori.SelectedItems[0].SubItems[2].Text;
            EnableButtons();
        }
        else
        {
            DisableButtons();
        }
    }

    private void btnDodajKreatora_Click(object sender, EventArgs e)
    {
        frmDodajKreatora frmDodajKreatora = new frmDodajKreatora();
        frmDodajKreatora.ShowDialog();
        UcitajPodatke();
        DisableButtons();
    }

    private void btnAzurirajKreatora_Click(object sender, EventArgs e)
    {
        frmAzurirajKreatora frmAzuriraj = new frmAzurirajKreatora();
        frmAzuriraj.ShowDialog();
        UcitajPodatke();
        DisableButtons();
    }

    private async void btnObrisiKreatora_Click(object sender, EventArgs e)
    {
        if (await DTOManager.ObrisiModnogKreatora(frmKreatori._kreatorMBR!))
        {
            MessageBox.Show("Uspešno obrisan modni kreator!");
            UcitajPodatke();
            DisableButtons();
        }
    }

    private void btnRevije_Click(object sender, EventArgs e)
    {
        frmRevijeKreatora frmRevije = new frmRevijeKreatora();
        frmRevije.ShowDialog();
        DisableButtons();
    }

    private void btnIzadji_Click(object sender, EventArgs e)
    {
        Close();
    }
}

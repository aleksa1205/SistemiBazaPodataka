namespace FashionWeek.Forms.Utils.KreatorForme;

public partial class frmKreatori : Form
{
    private ModniKreatorBasic? _kreator = null;

    public frmKreatori()
    {
        InitializeComponent();
    }

    #region Funkcije
    private void EnableButtons()
    {
        btnAzurirajKreatora.Enabled = true;
        btnObrisiKreatora.Enabled = true;
        btnRevije.Enabled = true;
    }

    private void DisableButtons()
    {
        btnAzurirajKreatora.Enabled = false;
        btnObrisiKreatora.Enabled = false;
        btnRevije.Enabled = false;
    }

    private async void UcitajPodatke()
    {
        lvOrganizatori.Items.Clear();
        IList<ModniKreatorPregled> kreatori = await DTOManager.VratiModneKreatore();
        foreach (var kreator in kreatori)
        {
            ListViewItem item = new ListViewItem(new string[] { kreator.MBR, kreator.Ime.LicnoIme, kreator.Ime.Prezime, kreator.DatumRodjenja.ToShortDateString(), kreator.Pol.ToString(), kreator.ZemljaPorekla, kreator.RadiU });
            lvOrganizatori.Items.Add(item);
        }
        lvOrganizatori.Refresh();
    }
    #endregion

    private void frmKreatori_Load(object sender, EventArgs e)
    {
        UcitajPodatke();
    }

    private async void lvKreatori_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lvOrganizatori.SelectedItems.Count > 0)
        {
            _kreator = await DTOManager.VratiModnogKreatora(lvOrganizatori.SelectedItems[0].Text);
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
        lvOrganizatori.SelectedItems.Clear();
    }

    private void btnAzurirajKreatora_Click(object sender, EventArgs e)
    {
        frmAzurirajKreatora frmAzuriraj = new frmAzurirajKreatora(_kreator);
        frmAzuriraj.ShowDialog();
        UcitajPodatke();
        lvOrganizatori.SelectedItems.Clear();
    }

    private async void btnObrisiKreatora_Click(object sender, EventArgs e)
    {
        if (await DTOManager.ObrisiModnogKreatora(_kreator.MBR!))
        {
            MessageBox.Show("Uspešno obrisan modni kreator!");
            UcitajPodatke();
            _kreator = null;
            lvOrganizatori.SelectedItems.Clear();
        }
    }

    private void btnRevije_Click(object sender, EventArgs e)
    {
        frmRevijeKreatora frmRevije = new frmRevijeKreatora(_kreator);
        frmRevije.ShowDialog();
        lvOrganizatori.SelectedItems.Clear();
    }

    private void btnIzadji_Click(object sender, EventArgs e)
    {
        Close();
    }
}

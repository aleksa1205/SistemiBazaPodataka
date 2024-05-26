namespace FashionWeek.Forms.Utils.OrganizatorForme;

public partial class frmOrganizatori : Form
{
    private OrganizatorBasic? _organizator = null;
    public frmOrganizatori()
    {
        InitializeComponent();
    }

    #region Funkcije
    private async void UcitajPodatke()
    {
        lvOrganizatori.Items.Clear();
        var organizatori = await DTOManager.VratiOrganizatore();
        foreach (var organizator in organizatori)
        {
            ListViewItem item = new ListViewItem(new string[] { organizator.Id.ToString(), organizator.PrvaRevija.ToString(), organizator.InformacijeOKolekciji });
            lvOrganizatori.Items.Add(item);
        }
        lvOrganizatori.Refresh();
    }
    private void EnableButtons()
    {
        btnAzurirajOrganizatora.Enabled = true;
        btnObrisiOrganiztora.Enabled = true;
        btnRevije.Enabled = true;
    }
    private void DisableButtons()
    {
        btnAzurirajOrganizatora.Enabled = false;
        btnObrisiOrganiztora.Enabled = false;
        btnRevije.Enabled = false;
    }
    #endregion

    private void frmOrganizatori_Load(object sender, EventArgs e)
    {
        UcitajPodatke();
    }

    private async void lvOrganizatori_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lvOrganizatori.SelectedItems.Count > 0)
        {
            _organizator = await DTOManager.VratiOrganizatora(Int32.Parse(lvOrganizatori.SelectedItems[0].Text));
            EnableButtons();
        }
        else
        {
            DisableButtons();
        }
    }

    private void btnDodajOrganizatora_Click(object sender, EventArgs e)
    {
        frmDodajOrganizatora frmDodaj = new frmDodajOrganizatora();
        frmDodaj.ShowDialog();
        lvOrganizatori.SelectedItems.Clear();
        UcitajPodatke();
    }

    private void btnAzurirajOrganizatora_Click(object sender, EventArgs e)
    {
        frmAzurirajOrganizatora frmAzuriraj = new frmAzurirajOrganizatora(_organizator);
        frmAzuriraj.ShowDialog();
        lvOrganizatori.SelectedItems.Clear();
        UcitajPodatke();
    }

    private async void btnObrisiOrganiztora_Click(object sender, EventArgs e)
    {
        if (await DTOManager.ObrisiOrganizatora(_organizator.Id))
        {
            MessageBox.Show($"Uspešno obrisan orgnizator sa ID-em {_organizator.Id}!");
            _organizator = null;
            lvOrganizatori.SelectedItems.Clear();
            UcitajPodatke();
        }
    }

    private void btnRevije_Click(object sender, EventArgs e)
    {
        frmRevijeOrganizatora frmRevije = new frmRevijeOrganizatora(_organizator.Id);
        frmRevije.ShowDialog();
        lvOrganizatori.SelectedItems.Clear();
    }

    private void btnIzadji_Click(object sender, EventArgs e)
    {
        Close();
    }
}

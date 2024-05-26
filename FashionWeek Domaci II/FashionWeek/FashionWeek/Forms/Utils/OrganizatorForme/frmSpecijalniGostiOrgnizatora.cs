namespace FashionWeek.Forms.Utils.OrganizatorForme;

public partial class frmSpecijalniGostiOrgnizatora : Form
{
    private OrganizatorBasic _organizator;

    public frmSpecijalniGostiOrgnizatora(OrganizatorBasic organizator)
    {
        InitializeComponent();
        _organizator = organizator;
    }

    #region Funkcije
    private async void UcitajPodatke()
    {
        lvOrganizatori.Items.Clear();
        IList<ModniKreatorPregled> kreatori = await DTOManager.VratiSpecijalneGosteOrganizatora(_organizator.Id);
        foreach (var kreator in kreatori)
        {
            ListViewItem item = new ListViewItem(new string[] { kreator.MBR, kreator.Ime.LicnoIme, kreator.Ime.Prezime, kreator.DatumRodjenja.ToShortDateString(), kreator.Pol.ToString(), kreator.ZemljaPorekla, kreator.RadiU });
            lvOrganizatori.Items.Add(item);
        }
        lvOrganizatori.Refresh();
    }
    #endregion

    private void btnIzadji_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void frmSpecijalniGostiOrgnizatora_Load(object sender, EventArgs e)
    {
        UcitajPodatke();
    }
}

namespace FashionWeek.Forms.Utils.RevijaForme;

public partial class frmSpecijalniGosti : Form
{
    private ModnaRevijaBasic? _revija;

    public frmSpecijalniGosti(ModnaRevijaBasic? revija)
    {
        InitializeComponent();
        _revija = revija;
    }

    #region Funkcije
    private async void UcitajPodatke()
    {
        lvOrganizatori.Items.Clear();
        IList<ModniKreatorPregled> kreatori = await DTOManager.VratiSpecijalneGoste(_revija.RBR);
        foreach (var kreator in kreatori)
        {
            ListViewItem item = new ListViewItem(new string[] { kreator.MBR, kreator.Ime.LicnoIme, kreator.Ime.Prezime, kreator.DatumRodjenja.ToShortDateString(), kreator.Pol.ToString(), kreator.ZemljaPorekla, kreator.RadiU });
            lvOrganizatori.Items.Add(item);
        }
        lvOrganizatori.Refresh();
    }
    #endregion

    private void frmSpecijalniGosti_Load(object sender, EventArgs e)
    {
        lblSpecijalniGosti.Text += _revija.Naziv + " koju organizuje orgnizator " + _revija.Organizator.Id.ToString();
        UcitajPodatke();
    }

    private void lvOrganizatori_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lvOrganizatori.SelectedItems.Count > 0)
        {
            btnObrisiGosta.Enabled = true;
        }
        else
        {
            btnObrisiGosta.Enabled = false;
        }
    }

    private async void btnObrisiGosta_Click(object sender, EventArgs e)
    {
        if (await DTOManager.ObrisiSpecijalnogGosta(_revija.RBR, _revija.Organizator.Id, lvOrganizatori.SelectedItems[0].Text))
        {         
            MessageBox.Show("Uspešno obrisan specijalni gost!");
            UcitajPodatke();
            lvOrganizatori.SelectedItems.Clear();
        }
    }
}

namespace FashionWeek.Forms.Utils.RevijaForme;

public partial class frmDodajSpecijalnogGosta : Form
{
    private ModnaRevijaBasic _revija;
    public frmDodajSpecijalnogGosta(ModnaRevijaBasic revija)
    {
        InitializeComponent();
        _revija = revija;
    }

    #region Funkcije
    private async void UcitajPodatke()
    {
        lvOrganizatori.Items.Clear();
        IList<ModniKreatorPregled> kreatori = await DTOManager.VratiMoguceSpecijalneGoste(_revija.RBR);
        foreach (var kreator in kreatori)
        {
            ListViewItem item = new ListViewItem(new string[] { kreator.MBR, kreator.Ime.LicnoIme, kreator.Ime.Prezime, kreator.DatumRodjenja.ToShortDateString(), kreator.Pol.ToString(), kreator.ZemljaPorekla, kreator.RadiU });
            lvOrganizatori.Items.Add(item);
        }
        lvOrganizatori.Refresh();
    }
    #endregion

    private void frmDodajSpecijalnogGosta_Load(object sender, EventArgs e)
    {
        UcitajPodatke();
    }

    private void lvOrganizatori_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lvOrganizatori.SelectedItems.Count > 0)
        {
            btnPozoviGosta.Enabled = true;
        }
        else
        {
            btnPozoviGosta.Enabled = false;
        }
    }

    private async void btnPozoviGosta_Click(object sender, EventArgs e)
    {
        if(await DTOManager.DodajSpecijalnogGosta(_revija.RBR, _revija.Organizator.Id, lvOrganizatori.SelectedItems[0].Text))
        {
            MessageBox.Show($"Uspešno dodat specijalni gost {lvOrganizatori.SelectedItems[0].SubItems[1].Text} {lvOrganizatori.SelectedItems[0].SubItems[2].Text}!");
            UcitajPodatke();
            lvOrganizatori.SelectedItems.Clear();
        }
    }

    private void btnOdustani_Click(object sender, EventArgs e)
    {
        Close();
    }
}

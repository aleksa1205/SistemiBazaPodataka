namespace FashionWeek.Forms.Utils.AgencijaForme;

public partial class frmNezaposleniManekeni : Form
{
    private string _agencijaPIB;

    public frmNezaposleniManekeni(string agencijaPIB)
    {
        InitializeComponent();
        _agencijaPIB = agencijaPIB;
    }

    #region Funkcije
    private async void UcitajPodatke()
    {
        lvManekeni.Items.Clear();
        IList<ManekenNezaposlenPregled> manekeni = await DTOManager.VratiNezaposleneManeken();
        foreach (var maneken in manekeni)
        {
            ListViewItem item = new ListViewItem(new string[] { maneken.MBR, maneken.Ime.LicnoIme, maneken.Ime.Prezime, maneken.DatumRodjenja.ToShortDateString(), maneken.Pol.ToString(), maneken.Visina.ToString(), maneken.Tezina.ToString(), maneken.BojaOciju, maneken.BojaKose, maneken.KonfekcijskiBroj, maneken.Zanimanje });
            lvManekeni.Items.Add(item);
        }
        lvManekeni.Refresh();
    }
    #endregion

    private void frmNezaposleniManekeni_Load(object sender, EventArgs e)
    {
        UcitajPodatke();
    }

    private async void btnZaposli_Click(object sender, EventArgs e)
    {
        if (await DTOManager.ZaposliManekena(lvManekeni.SelectedItems[0].Text, _agencijaPIB))
        {
            MessageBox.Show($"Maneken {lvManekeni.SelectedItems[0].SubItems[1].Text} {lvManekeni.SelectedItems[0].SubItems[2].Text} je uspešno zapošljen!");
            UcitajPodatke();
            btnZaposli.Enabled = false;
        }
    }

    private void btnOdustani_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void lvManekeni_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lvManekeni.SelectedItems.Count > 0)
        {
            btnZaposli.Enabled = true;
        }
        else
        {
            btnZaposli.Enabled = false;
        }
    }
}

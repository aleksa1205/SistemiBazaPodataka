namespace FashionWeek.Forms.Utils.KucaForme;

public partial class frmZaposliKreatora : Form
{
    private string _nazivKuce;

    public frmZaposliKreatora(string nazivKuce)
    {
        InitializeComponent();
        _nazivKuce = nazivKuce;
    }

    #region Funkcije
    private async void UcitajPodatke()
    {
        lvKreatori.Items.Clear();
        var listaKreatora = await DTOManager.VratiNezaposleneModneKreatore();
        foreach (var kreator in listaKreatora)
        {
            ListViewItem item = new ListViewItem(new string[] { kreator.MBR, kreator.Ime.LicnoIme, kreator.Ime.Prezime, kreator.DatumRodjenja.ToShortDateString(), kreator.Pol.ToString(), kreator.ZemljaPorekla });
            lvKreatori.Items.Add(item);
        }
        lvKreatori.Refresh();
    }
    #endregion

    private void frmZaposliKreatora_Load(object sender, EventArgs e)
    {
        UcitajPodatke();
    }

    private void lvKreatori_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lvKreatori.SelectedItems.Count > 0)
        {
            btnZaposli.Enabled = true;
        }
        else
        {
            btnZaposli.Enabled = false;
        }
    }

    private async void btnZaposli_Click(object sender, EventArgs e)
    {
        if(await DTOManager.DodajModnuKucuModnomKreatoru(lvKreatori.SelectedItems[0].Text, _nazivKuce))
        {
            MessageBox.Show($"Uspešno zapošljen modni kreator {lvKreatori.SelectedItems[0].SubItems[1].Text} {lvKreatori.SelectedItems[0].SubItems[2].Text}!");
            lvKreatori.SelectedItems.Clear();
            UcitajPodatke();
        }
    }

    private void btnOdustani_Click(object sender, EventArgs e)
    {
        Close();
    }
}

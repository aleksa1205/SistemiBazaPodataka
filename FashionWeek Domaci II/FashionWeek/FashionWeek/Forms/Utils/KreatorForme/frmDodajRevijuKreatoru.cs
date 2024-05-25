namespace FashionWeek.Forms.Utils.KreatorForme;

public partial class frmDodajRevijuKreatoru : Form
{
    private ModniKreatorBasic _kreator;

    public frmDodajRevijuKreatoru(ModniKreatorBasic kreator)
    {
        InitializeComponent();
        _kreator = kreator;
    }

    #region Funkcije
    public async void UcitajPodatke()
    {
        lvRevije.Items.Clear();
        var listaRevija = await DTOManager.VratiModneRevijeNaKojimaNeUcestvujeKreator(_kreator.MBR!);
        foreach (var revija in listaRevija)
        {
            ListViewItem item = new ListViewItem(new string[] { revija.RBR.ToString(), revija.Naziv, revija.Mesto?.ToString(), revija.Termin.ToShortDateString() });
            lvRevije.Items.Add(item);
        }
        lvRevije.Refresh();
    }
    #endregion

    private void frmDodajRevijuKreatoru_Load(object sender, EventArgs e)
    {
        UcitajPodatke();
        lblRevije.Text += _kreator.Ime.ToString() + ':';
    }

    private void lvRevije_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lvRevije.SelectedItems.Count > 0)
        {
            btnDodajReviju.Enabled = true;
        }
        else
        {
            btnDodajReviju.Enabled = false;
        }
    }

    private async void btnDodajReviju_Click(object sender, EventArgs e)
    {
        if (await DTOManager.DodajModnogKreatoraReviji(Int32.Parse(lvRevije.SelectedItems[0].Text), _kreator.MBR))
        {
            MessageBox.Show("Uspešno dodata revija!");
            UcitajPodatke();
            lvRevije.SelectedItems.Clear();
        }
    }

    private void btnOdustani_Click(object sender, EventArgs e)
    {
        Close();
    }
}

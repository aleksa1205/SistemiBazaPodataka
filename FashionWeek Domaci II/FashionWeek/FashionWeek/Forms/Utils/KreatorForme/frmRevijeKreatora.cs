namespace FashionWeek.Forms.Utils.KreatorForme;

public partial class frmRevijeKreatora : Form
{
    private ModniKreatorBasic _kreator;

    public frmRevijeKreatora(ModniKreatorBasic kreator)
    {
        InitializeComponent();
        _kreator = kreator;
    }

    #region Funkcije
    private async void UcitajPodatke()
    {
        lvRevije.Items.Clear();
        var revije = await DTOManager.VratiModneRevijeModnogKreatora(_kreator.MBR);
        foreach (var revija in revije)
        {
            ListViewItem item = new ListViewItem(new string[] { revija.RBR.ToString(), revija.Naziv, revija.Mesto?.ToString(), revija.Termin.ToShortDateString() });
            lvRevije.Items.Add(item);
        }
        lvRevije.Refresh();
    }
    #endregion

    private void frmRevijeKreatora_Load(object sender, EventArgs e)
    {
        lblRevije.Text += _kreator.Ime.ToString() + ':';
        UcitajPodatke();
    }

    private void lvRevije_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lvRevije.SelectedItems.Count > 0)
        {
            btnObrisiReviju.Enabled = true;
        }
        else
        {
            btnObrisiReviju.Enabled = false;
        }
    }

    private void btnDodajReviju_Click(object sender, EventArgs e)
    {
        frmDodajRevijuKreatoru frmDodajReviju = new frmDodajRevijuKreatoru(_kreator);
        frmDodajReviju.ShowDialog();
        UcitajPodatke();
        lvRevije.SelectedItems.Clear();
    }

    private async void btnObrisiReviju_Click(object sender, EventArgs e)
    {
        if (await DTOManager.ObrisiModnogKreatoraReviji(Int32.Parse(lvRevije.SelectedItems[0].Text), _kreator.MBR))
        {
            MessageBox.Show("Uspešno uklonjen kreator sa revije!");
            UcitajPodatke();
            lvRevije.SelectedItems.Clear();
        }
    }

    private void btnOdustani_Click(object sender, EventArgs e)
    {
        Close();
    }
}

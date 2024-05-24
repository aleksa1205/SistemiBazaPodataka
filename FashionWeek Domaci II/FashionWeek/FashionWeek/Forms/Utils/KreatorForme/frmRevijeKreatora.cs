namespace FashionWeek.Forms.Utils.KreatorForme;

public partial class frmRevijeKreatora : Form
{
    #region Funkcije
    private async void UcitajPodatke()
    {
        lvRevije.Items.Clear();
        var revije = await DTOManager.VratiModneRevijeModnogKreatora(frmKreatori._kreatorMBR!);
        foreach (var revija in revije)
        {
            ListViewItem item = new ListViewItem(new string[] { revija.RBR.ToString(), revija.Naziv, revija.Mesto?.ToString(), revija.Termin.ToShortDateString() });
            lvRevije.Items.Add(item);
        }
        lvRevije.Refresh();
    }
    #endregion
    public frmRevijeKreatora()
    {
        InitializeComponent();
    }

    private void frmRevijeKreatora_Load(object sender, EventArgs e)
    {
        lblRevije.Text += frmKreatori._imeKreatora;
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
        frmDodajRevijuKreatoru frmDodajReviju = new frmDodajRevijuKreatoru();
        frmDodajReviju.ShowDialog();
        UcitajPodatke();
    }

    private async void btnObrisiReviju_Click(object sender, EventArgs e)
    {
        if (await DTOManager.ObrisiModnogKreatoraReviji(Int32.Parse(lvRevije.SelectedItems[0].Text), frmKreatori._kreatorMBR!))
        {
            MessageBox.Show("Uspešno uklonjen kreator sa revije!");
            UcitajPodatke();
            btnObrisiReviju.Enabled = false;
        }
    }

    private void btnOdustani_Click(object sender, EventArgs e)
    {
        Close();
    }
}

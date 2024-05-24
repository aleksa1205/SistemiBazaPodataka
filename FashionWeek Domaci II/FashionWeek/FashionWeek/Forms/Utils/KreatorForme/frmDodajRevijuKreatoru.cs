namespace FashionWeek.Forms.Utils.KreatorForme;

public partial class frmDodajRevijuKreatoru : Form
{
    #region Funkcije
    public async void UcitajPodatke()
    {
        lvRevije.Items.Clear();
        var listaRevija = await DTOManager.VratiModneRevijeNaKojimaNeUcestvujeKreator(frmKreatori._kreatorMBR!);
        foreach (var revija in listaRevija)
        {
            ListViewItem item = new ListViewItem(new string[] { revija.RBR.ToString(), revija.Naziv, revija.Mesto?.ToString(), revija.Termin.ToShortDateString() });
            lvRevije.Items.Add(item);
        }
        lvRevije.Refresh();
    }
    #endregion
    public frmDodajRevijuKreatoru()
    {
        InitializeComponent();
    }

    private void frmDodajRevijuKreatoru_Load(object sender, EventArgs e)
    {
        UcitajPodatke();
        lblRevije.Text += frmKreatori._imeKreatora;
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
        if (await DTOManager.DodajModnogKreatoraReviji(Int32.Parse(lvRevije.SelectedItems[0].Text), frmKreatori._kreatorMBR!))
        {
            MessageBox.Show("Uspešno dodata revija!");
            UcitajPodatke();
            btnDodajReviju.Enabled = false;
        }
    }

    private void btnOdustani_Click(object sender, EventArgs e)
    {
        Close();
    }
}

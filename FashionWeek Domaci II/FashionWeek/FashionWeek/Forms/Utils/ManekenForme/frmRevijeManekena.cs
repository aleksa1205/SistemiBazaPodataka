namespace FashionWeek.Forms.Utils.ManekenForme;

public partial class frmRevijeManekena : Form
{
    private ManekenBasic _maneken;
    public frmRevijeManekena(ManekenBasic maneken)
    {
        InitializeComponent();
        _maneken = maneken;
    }

    #region Funkcije
    private async void UcitajPodatke()
    {
        lvRevije.Items.Clear();
        IList<ModnaRevijaPregled> listaRevija = await DTOManager.VratiModneRevijaManekena(_maneken.MBR);
        foreach (var revija in listaRevija)
        {
            ListViewItem item = new ListViewItem(new string[] { revija.RBR.ToString(), revija.Naziv, revija.Mesto!.ToString(), revija.Termin.ToShortDateString() });
            lvRevije.Items.Add(item);
        }
        lvRevije.Refresh();
    }
    #endregion

    private void frmRevije_Load(object sender, EventArgs e)
    {

        lblRevije.Text += _maneken.Ime.ToString() + ':';
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
        frmDodajRevijuManeken frmDodaj = new frmDodajRevijuManeken(_maneken);
        frmDodaj.ShowDialog();
        UcitajPodatke();
        lvRevije.SelectedItems.Clear();
    }

    private async void btnObrisiReviju_Click(object sender, EventArgs e)
    {
        if(await DTOManager.ObrisiRevijuManekenu(_maneken.MBR, Int32.Parse(lvRevije.SelectedItems[0].Text)))
        {
            MessageBox.Show($"Uspešno obrisana revija {lvRevije.SelectedItems[0].SubItems[1].Text} manekenu {_maneken.Ime.ToString()}!");
            UcitajPodatke();
            lvRevije.SelectedItems.Clear();
        }
    }

    private void btnOdustani_Click(object sender, EventArgs e)
    {
        Close();
    }

}

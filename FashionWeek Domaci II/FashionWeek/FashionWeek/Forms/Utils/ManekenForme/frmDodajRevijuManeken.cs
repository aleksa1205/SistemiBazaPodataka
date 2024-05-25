namespace FashionWeek.Forms.Utils.ManekenForme;

public partial class frmDodajRevijuManeken : Form
{
    private ManekenBasic _maneken;
    public frmDodajRevijuManeken(ManekenBasic maneken)
    {
        InitializeComponent();
        _maneken = maneken;
    }

    #region Funkcije
    private async void UcitajPodatke()
    {
        lvRevije.Items.Clear();
        IList<ModnaRevijaPregled> listaRevija = await DTOManager.VratiModneRevijaNaKojimaNeUcestvujeManeken(_maneken.MBR);
        foreach (var revija in listaRevija)
        {
            ListViewItem item = new ListViewItem(new string[] { revija.RBR.ToString(), revija.Naziv, revija.Mesto?.ToString(), revija.Termin.ToShortDateString() });
            lvRevije.Items.Add(item);
        }
        lvRevije.Refresh();
    }
    #endregion

    private void frmDodajRevijuManeken_Load(object sender, EventArgs e)
    {
        lblListaRevija.Text += _maneken.Ime.ToString() + ':';
        UcitajPodatke();
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
        if(await DTOManager.DodajRevijuManekenu(_maneken.MBR, Int32.Parse(lvRevije.SelectedItems[0].Text)))
        {
            MessageBox.Show($"Uspešno dodata revija {lvRevije.SelectedItems[0].SubItems[1].Text} {_maneken.Ime.ToString()}!");
            UcitajPodatke();
            lvRevije.SelectedItems.Clear();
        }
    }

    private void btnOdustani_Click(object sender, EventArgs e)
    {
        Close();
    }
}

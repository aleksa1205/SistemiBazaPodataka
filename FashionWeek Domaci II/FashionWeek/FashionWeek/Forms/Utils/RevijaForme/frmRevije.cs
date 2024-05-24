namespace FashionWeek.Forms.Utils.Revija;

public partial class frmRevije : Form
{
    public static int? _rbrRevije = null;
    public static string? _nazivRevije = null;
    #region Funkcije
    public void EnableButtons()
    {
        btnAzurirajReviju.Enabled = true;
        btnObrisiReviju.Enabled = true;
        btnUcesnici.Enabled = true;
        btnKreatori.Enabled = true;
    }

    public void DisableButtons()
    {
        btnAzurirajReviju.Enabled = false;
        btnObrisiReviju.Enabled = false;
        btnUcesnici.Enabled = false;
        btnKreatori.Enabled = false;
    }

    public async void UcitajPodatke()
    {
        lvRevije.Items.Clear();
        IList<ModnaRevijaPregled> revije = await DTOManager.VratiModneRevije();
        foreach (var revija in revije)
        {
            ListViewItem item = new ListViewItem(new string[] { revija.RBR.ToString(), revija.Naziv, revija.Mesto?.ToString(), revija.Termin.ToShortDateString() });
            lvRevije.Items.Add(item);
        }
        lvRevije.Refresh();
    }
    #endregion

    public frmRevije()
    {
        InitializeComponent();
    }

    private void frmRevije_Load(object sender, EventArgs e)
    {
        UcitajPodatke();
    }

    private void lvRevije_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lvRevije.SelectedItems.Count > 0)
        {
            _rbrRevije = Int32.Parse(lvRevije.SelectedItems[0].Text);
            _nazivRevije = lvRevije.SelectedItems[0].SubItems[1].Text;
            EnableButtons();
        }
        else
        {
            DisableButtons();
        }
    }

    private void btnDodajReviju_Click(object sender, EventArgs e)
    {
        frmDodajReviju revija = new frmDodajReviju();
        revija.ShowDialog();
        UcitajPodatke();
    }

    private void btnAzurirajReviju_Click(object sender, EventArgs e)
    {
        frmAzurirajReviju frmAzuriraj = new frmAzurirajReviju();
        frmAzuriraj.ShowDialog();
        UcitajPodatke();
        DisableButtons();
    }

    private async void btnObrisiReviju_Click(object sender, EventArgs e)
    {
        if (await DTOManager.ObrisiReviju(_rbrRevije))
        {
            MessageBox.Show("Uspešno obrisana revija!");
            UcitajPodatke();
            DisableButtons();
        }
    }

    private void btnUcesnici_Click(object sender, EventArgs e)
    {

        frmUcesniciRevije frmUcesniciRevije = new frmUcesniciRevije();
        frmUcesniciRevije.ShowDialog();
        DisableButtons();
    }

    private void btnIzadji_Click(object sender, EventArgs e)
    {
        Close();
    }
}

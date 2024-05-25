namespace FashionWeek.Forms.Utils.ManekenForme;

public partial class frmNaziviCasopisaManekena : Form
{
    private ManekenBasic _maneken;
    public frmNaziviCasopisaManekena(ManekenBasic maneken)
    {
        _maneken = maneken;
        InitializeComponent();
    }

    #region Funkcije
    private async void UcitajPodatke()
    {
        lvCasopisi.Items.Clear();
        var listeCasopisa = await DTOManager.VratiCasopiseManekena(_maneken.MBR);
        foreach (var casopis in listeCasopisa)
        {
            lvCasopisi.Items.Add(new ListViewItem(casopis));
        }
        lvCasopisi.Refresh();
    }
    #endregion

    private void frmNaziviCasopisaManekena_Load(object sender, EventArgs e)
    {
        lblManeken.Text = _maneken.Ime.ToString();
        UcitajPodatke();
    }

    private void lvCasopisi_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lvCasopisi.SelectedItems.Count > 0)
        {
            btnObrisiCasopis.Enabled = true;
        }
        else
        {
            btnObrisiCasopis.Enabled = false;
        }
    }

    private void btnDodajCasopis_Click(object sender, EventArgs e)
    {
        frmDodajCasopis frmDodaj = new frmDodajCasopis(_maneken.MBR);
        frmDodaj.ShowDialog();
        UcitajPodatke();
        btnObrisiCasopis.Enabled = false;
    }

    private async void btnObrisiCasopis_Click(object sender, EventArgs e)
    {
        if (await DTOManager.ObrisiCasopis(_maneken.MBR, lvCasopisi.SelectedItems[0].Text))
        {
            MessageBox.Show($"Uspešno obrisan časopis {lvCasopisi.SelectedItems[0].Text}!");
            UcitajPodatke();
            lvCasopisi.SelectedItems.Clear();
        }
    }

    private void btnOdustani_Click(object sender, EventArgs e)
    {
        Close();
    }
}

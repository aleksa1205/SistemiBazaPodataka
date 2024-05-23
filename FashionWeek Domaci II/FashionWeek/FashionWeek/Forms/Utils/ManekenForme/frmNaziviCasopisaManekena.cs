namespace FashionWeek.Forms.Utils.ManekenForme;

public partial class frmNaziviCasopisaManekena : Form
{
    #region Funkcije
    public async void UcitajPodatke()
    {
        lvCasopisi.Items.Clear();
        IList<string> casopisi = await DTOManager.VratiCasopiseManekena(frmManekeni._manekenMBR!);
        foreach (var casopis in casopisi)
        {
            lvCasopisi.Items.Add(new ListViewItem(casopis));
        }
        lvCasopisi.Refresh();
    }
    #endregion
    public frmNaziviCasopisaManekena()
    {
        InitializeComponent();
    }

    private void frmNaziviCasopisaManekena_Load(object sender, EventArgs e)
    {
        //lblManeken.Text = frmManekeni._maneken.Ime.ToString();
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
        frmDodajCasopis frmDodaj = new frmDodajCasopis();
        frmDodaj.ShowDialog();
        UcitajPodatke();
        btnObrisiCasopis.Enabled = false;
    }

    private async void btnObrisiCasopis_Click(object sender, EventArgs e)
    {
        if (await DTOManager.ObrisiCasopis(frmManekeni._manekenMBR!, lvCasopisi.SelectedItems[0].Text))
        {
            MessageBox.Show("Uspešno obrisan časopis!");
            UcitajPodatke();
            btnObrisiCasopis.Enabled = false;
        }
    }

    private void btnOdustani_Click(object sender, EventArgs e)
    {
        Close();
    }
}

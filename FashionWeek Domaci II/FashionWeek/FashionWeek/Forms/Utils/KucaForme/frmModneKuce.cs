namespace FashionWeek.Forms.Utils.KucaForme;

public partial class frmModneKuce : Form
{
    public static string? _nazivModneKuce = null;
    #region Funkcije
    private async void UcitajPodatke()
    {
        lvModneKuce.Items.Clear();
        var modneKuce = await DTOManager.VratiModneKuce();
        foreach (var modnaKuca in modneKuce)
        {
            ListViewItem item = new ListViewItem(new string[] { modnaKuca.Naziv, modnaKuca.Osnivac?.ToString(), modnaKuca.Sediste?.ToString() });
            lvModneKuce.Items.Add(item);
        }
        lvModneKuce.Refresh();
    }
    private void EnableButtons()
    {
        btnAzurirajModnuKucu.Enabled = true;
        btnObrisiModnuKucu.Enabled = true;
        btnModniKreatori.Enabled = true;
        btnVlasnici.Enabled = true;
    }
    private void DisableButtons()
    {
        btnAzurirajModnuKucu.Enabled = false;
        btnObrisiModnuKucu.Enabled = false;
        btnModniKreatori.Enabled = false;
        btnVlasnici.Enabled = false;
    }
    #endregion
    public frmModneKuce()
    {
        InitializeComponent();
    }

    private void frmModneKuce_Load(object sender, EventArgs e)
    {
        UcitajPodatke();
    }

    private void lvModneKuce_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lvModneKuce.SelectedItems.Count > 0)
        {
            _nazivModneKuce = lvModneKuce.SelectedItems[0].Text;
            EnableButtons();
        }
        else
        {
            DisableButtons();
        }
    }

    private void btnDodajModnuKucu_Click(object sender, EventArgs e)
    {
        frmDodajModnuKucu frmDodaj = new frmDodajModnuKucu();
        frmDodaj.ShowDialog();
        UcitajPodatke();
        DisableButtons();
    }

    private void btnAzurirajModnuKucu_Click(object sender, EventArgs e)
    {
        frmAzurirajModnuKucu frmAzuriraj = new frmAzurirajModnuKucu();
        frmAzuriraj.ShowDialog();
        UcitajPodatke();
        DisableButtons();
    }

    private async void btnObrisiModnuKucu_Click(object sender, EventArgs e)
    {
        if(await DTOManager.ObrisiModnuKucu(_nazivModneKuce))
        {
            MessageBox.Show("Uspešno obrisana modna kuća!");
            UcitajPodatke();
            DisableButtons();
        }
    }
}

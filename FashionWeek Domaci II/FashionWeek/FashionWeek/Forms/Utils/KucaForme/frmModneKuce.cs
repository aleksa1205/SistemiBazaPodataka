namespace FashionWeek.Forms.Utils.KucaForme;

public partial class frmModneKuce : Form
{
    private ModnaKucaBasic? _kuca = null;

    public frmModneKuce()
    {
        InitializeComponent();
    }

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

    private void frmModneKuce_Load(object sender, EventArgs e)
    {
        UcitajPodatke();
    }

    private async void lvModneKuce_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lvModneKuce.SelectedItems.Count > 0)
        {
            _kuca = await DTOManager.VratiModnuKucu(lvModneKuce.SelectedItems[0].Text);
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
        lvModneKuce.SelectedItems.Clear();
    }

    private void btnAzurirajModnuKucu_Click(object sender, EventArgs e)
    {
        frmAzurirajModnuKucu frmAzuriraj = new frmAzurirajModnuKucu(_kuca);
        frmAzuriraj.ShowDialog();
        UcitajPodatke();
        lvModneKuce.SelectedItems.Clear();
    }

    private async void btnObrisiModnuKucu_Click(object sender, EventArgs e)
    {
        if (await DTOManager.ObrisiModnuKucu(_kuca.Naziv))
        {
            MessageBox.Show($"Uspešno obrisana modna kuća {_kuca.Naziv}!");
            UcitajPodatke();
            lvModneKuce.SelectedItems.Clear();
        }
    }

    private void btnModniKreatori_Click(object sender, EventArgs e)
    {
        frmKreatoriModneKuce frmKreatori = new frmKreatoriModneKuce(_kuca);
        frmKreatori.ShowDialog();
    }

    private void btnVlasnici_Click(object sender, EventArgs e)
    {
        frmVlasnici frmVlasnici = new frmVlasnici(_kuca);
        frmVlasnici.ShowDialog();
    }

    private void btnIzadji_Click(object sender, EventArgs e)
    {
        Close();
    }
}

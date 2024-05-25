namespace FashionWeek.Forms.Utils.AgencijaForme;

public partial class frmAgencije : Form
{
    private ModnaAgencijaBasic? _agencija = null;

    public frmAgencije()
    {
        InitializeComponent();
    }

    #region Funkcije
    private async void EnableButtons()
    {
        btnAzurirajAgenciju.Enabled = true;
        btnObrisiAgenciju.Enabled = true;
        btnPrikaziManekene.Enabled = true;
        if (await DTOManager.IsInostrana(_agencija!.PIB))
        {
            btnZemljePoslovanja.Enabled = true;
        }
    }

    private void DisableButtons()
    {
        btnAzurirajAgenciju.Enabled = false;
        btnObrisiAgenciju.Enabled = false;
        btnPrikaziManekene.Enabled = false;
        btnZemljePoslovanja.Enabled = false;
    }

    private async void UcitajPodatke()
    {
        lvAgencije.Items.Clear();
        IList<ModnaAgencijaPregled> agencije = await DTOManager.VratiModneAgencije();
        foreach (var agencija in agencije)
        {
            ListViewItem item = new ListViewItem(new string[] { agencija.PIB!, agencija.Naziv!, agencija.Sediste?.ToString(), agencija.DatumOsnivanja.ToShortDateString() });
            lvAgencije.Items.Add(item);
        }
        lvAgencije.Refresh();
    }
    #endregion

    private void frmAgencije_Load(object sender, EventArgs e)
    {
        UcitajPodatke();
    }

    private async void lvAgencije_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lvAgencije.SelectedItems.Count > 0)
        {
            _agencija = await DTOManager.VratiModnuAgenciju(lvAgencije.SelectedItems[0].Text);
            EnableButtons();
        }
        else
        {
            DisableButtons();
        }
    }

    private void btnDodajAgenciju_Click(object sender, EventArgs e)
    {
        frmDodajAgenciju frmDodajAgenciju = new frmDodajAgenciju();
        frmDodajAgenciju.ShowDialog();
        UcitajPodatke();
        lvAgencije.SelectedItems.Clear();
    }

    private void btnAzurirajAgenciju_Click(object sender, EventArgs e)
    {
        frmAzurirajAgenciju frmAzuriraj = new frmAzurirajAgenciju(_agencija!);
        frmAzuriraj.ShowDialog();
        UcitajPodatke();
        lvAgencije.SelectedItems.Clear();
    }

    private async void btnObrisiAgenciju_Click(object sender, EventArgs e)
    {

        if (await DTOManager.ObrisiModnuAgenciju(_agencija!.PIB!))
        {
            MessageBox.Show($"Uspešno obrisana agencija {_agencija.Naziv}!");
            _agencija = null;
            UcitajPodatke();
            lvAgencije.SelectedItems.Clear();
        }
    }

    private void btnPrikaziManekene_Click(object sender, EventArgs e)
    {
        frmAgencijaManekeni frmManekeni = new frmAgencijaManekeni(_agencija);
        frmManekeni.ShowDialog();
        lvAgencije.SelectedItems.Clear();
    }

    private void btnZemljePoslovanja_Click(object sender, EventArgs e)
    {
        frmNaziviZemaljaAgencije frmZemlje = new frmNaziviZemaljaAgencije(_agencija);
        frmZemlje.ShowDialog();
        lvAgencije.SelectedItems.Clear();
    }

    private void btnIzadji_Click(object sender, EventArgs e)
    {
        Close();
    }
}

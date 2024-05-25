namespace FashionWeek.Forms.Utils.AgencijaForme;

public partial class frmNaziviZemaljaAgencije : Form
{
    private ModnaAgencijaBasic _agencija;

    public frmNaziviZemaljaAgencije(ModnaAgencijaBasic agencija)
    {
        InitializeComponent();
        _agencija = agencija;
    }

    #region Funkcije
    private async void UcitajPodatke()
    {
        lvZemlje.Items.Clear();
        IList<string> listaZemalja = await DTOManager.VratiZemljeUKojimaPoslujeAgencijaPregled(_agencija.PIB);
        foreach (var zemlja in listaZemalja)
        {
            ListViewItem item = new ListViewItem(zemlja);
            lvZemlje.Items.Add(item);
        }
        lvZemlje.Refresh();
    }
    #endregion

    private void frmAgencijeZemlje_Load(object sender, EventArgs e)
    {
        lblNazivAgencije.Text = _agencija.Naziv;
        UcitajPodatke();
    }

    private void lvZemlje_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lvZemlje.SelectedItems.Count > 0)
        {
            btnObrisiZemlju.Enabled = true;
        }
        else
        {
            btnObrisiZemlju.Enabled = false;
        }
    }

    private void btnDodajZemlju_Click(object sender, EventArgs e)
    {
        frmDodajZemlju frmDodajZemlju = new frmDodajZemlju(_agencija.PIB);
        frmDodajZemlju.ShowDialog();
        UcitajPodatke();
    }

    private async void btnObrisiZemlju_Click(object sender, EventArgs e)
    {

        if (await DTOManager.ObrisiZemlju(_agencija.PIB, lvZemlje.SelectedItems[0].Text))
        {
            MessageBox.Show("Uspešno obrisana zemlja!");
            UcitajPodatke();
            btnObrisiZemlju.Enabled = false;
        }
    }

    private void btnIzadji_Click(object sender, EventArgs e)
    {
        Close();
    }
}

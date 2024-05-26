namespace FashionWeek.Forms.Utils.AgencijaForme;

public partial class frmAgencijaManekeni : Form
{
    private ModnaAgencijaBasic _agencija;

    public frmAgencijaManekeni(ModnaAgencijaBasic agencija)
    {
        InitializeComponent();
        _agencija = agencija;
    }

    #region Funkcije
    public async void UcitajPodatke()
    {
        lvManekeni.Items.Clear();
        IList<ManekenPregled> listaManekena = await DTOManager.VratiManekeneModneAgencije(_agencija.PIB);
        foreach (var maneken in listaManekena)
        {
            ListViewItem item = new ListViewItem(new string[] { maneken.MBR!, maneken.Ime?.LicnoIme!, maneken.Ime?.Prezime!, maneken.DatumRodjenja.ToShortDateString(), maneken.Pol.ToString(), maneken.Visina.ToString(), maneken.Tezina.ToString(), maneken.BojaOciju, maneken.BojaKose, maneken.KonfekcijskiBroj });
            lvManekeni.Items.Add(item);
        }
        lvManekeni.Refresh();
    }
    #endregion

    private void frmAgencijaManekeni_Load(object sender, EventArgs e)
    {
        lblListaManekenaAgencije.Text += _agencija.Naziv + ':';
        UcitajPodatke();
    }

    private void lvManekeni_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lvManekeni.SelectedItems.Count > 0)
        {
            btnOtpustiManekena.Enabled = true;
        }
        else
        {
            btnOtpustiManekena.Enabled = false;
        }
    }

    private void btnZaposliManekena_Click(object sender, EventArgs e)
    {
        frmNezaposleniManekeni frmNezaposleni = new frmNezaposleniManekeni(_agencija.PIB);
        frmNezaposleni.ShowDialog();
        UcitajPodatke();
        btnOtpustiManekena.Enabled = false;
    }

    private async void btnOtpustiManekena_Click(object sender, EventArgs e)
    {
        if (await DTOManager.DajOtkazManeken(lvManekeni.SelectedItems[0].Text))
        {
            MessageBox.Show($"Uspešno otpušten maneken {lvManekeni.SelectedItems[0].SubItems[1].Text} {lvManekeni.SelectedItems[0].SubItems[2].Text}!");
            UcitajPodatke();
            btnOtpustiManekena.Enabled = false;
        }
    }

    private void btnIzadji_Click(object sender, EventArgs e)
    {
        Close();
    }

}

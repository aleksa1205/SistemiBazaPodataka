namespace FashionWeek.Forms.Utils.Revija;

public partial class frmUcesniciRevije : Form
{
    private ModnaRevijaBasic _revija;

    public frmUcesniciRevije(ModnaRevijaBasic modnaRevija)
    {
        InitializeComponent();
        _revija = modnaRevija;
    }

    #region Funkcije
    private async void UcitajPodatke()
    {
        lvManekeni.Items.Clear();
        IList<ManekenPregled> manekeni = await DTOManager.VratiManekeneModneRevije(_revija.RBR);
        foreach (var maneken in manekeni)
        {
            ListViewItem item = new ListViewItem(new string[] { maneken.MBR, maneken.Ime.LicnoIme, maneken.Ime.Prezime, maneken.DatumRodjenja.ToShortDateString(), maneken.Pol.ToString() });
            lvManekeni.Items.Add(item);
        }
        lvManekeni.Refresh();
    }
    #endregion

    private void frmUcesniciRevije_Load(object sender, EventArgs e)
    {
        lblRevija.Text += _revija.Naziv + ':';
        UcitajPodatke();
    }

    private void lvManekeni_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lvManekeni.SelectedItems.Count > 0)
        {
            btnObrisiManekena.Enabled = true;
        }
        else
        {
            btnObrisiManekena.Enabled = false;
        }
    }

    private void btnDodajManekena_Click(object sender, EventArgs e)
    {
        frmDodajManekenaReviji frmDodajManekena = new frmDodajManekenaReviji(_revija);
        frmDodajManekena.ShowDialog();
        UcitajPodatke();
        lvManekeni.SelectedItems.Clear();
    }

    private async void btnObrisiManekena_Click(object sender, EventArgs e)
    {

        if (await DTOManager.ObrisiRevijuManekenu(lvManekeni.SelectedItems[0].Text, _revija.RBR))
        {
            MessageBox.Show($"Uspešno obrisan maneken {lvManekeni.SelectedItems[0].SubItems[1].Text} {lvManekeni.SelectedItems[0].SubItems[2].Text}!");
            lvManekeni.SelectedItems.Clear();
            UcitajPodatke();
        }
    }

    private void btnIzadji_Click(object sender, EventArgs e)
    {
        Close();
    }
}

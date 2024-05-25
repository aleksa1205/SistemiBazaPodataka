namespace FashionWeek.Forms.Utils.RevijaForme;

public partial class frmAzurirajReviju : Form
{
    public ModnaRevijaBasic _revija;

    public frmAzurirajReviju(ModnaRevijaBasic revija)
    {
        InitializeComponent();
        _revija = revija;
    }

    #region Funkcije
    private void Ucitaj()
    {
        txtRBR.Text = _revija.RBR.ToString();
        txtNaziv.Text = _revija.Naziv;
        dtpTermin.Value = _revija.Termin;
        txtDrzava.Text = _revija.Mesto?.Drzava;
        txtGrad.Text = _revija.Mesto?.Grad;
        txtUlica.Text = _revija.Mesto?.Ulica;
    }

    private void Procitaj()
    {
        _revija!.Naziv = txtNaziv.Text;
        _revija.Termin = dtpTermin.Value;
        _revija.Mesto = new(txtDrzava.Text, txtGrad.Text, txtUlica.Text);
    }
    #endregion

    private void frmAzurirajReviju_Load(object sender, EventArgs e)
    {
        Ucitaj();
    }

    private async void btnAzuriraj_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtNaziv.Text))
        {
            MessageBox.Show("Polje naziv ne sme biti prazno!");
            return;
        }
        Procitaj();
        if (await DTOManager.AzurirajReviju(_revija))
        {
            MessageBox.Show($"Revija {_revija.Naziv} uspešno ažurirana!");
            Close();
        }
    }

    private void btnOdustani_Click(object sender, EventArgs e)
    {
        Close();
    }
}

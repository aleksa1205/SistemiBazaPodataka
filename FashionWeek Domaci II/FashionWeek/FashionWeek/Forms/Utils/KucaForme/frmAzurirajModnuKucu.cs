namespace FashionWeek.Forms.Utils.KucaForme;

public partial class frmAzurirajModnuKucu : Form
{
    private ModnaKucaBasic _kuca;

    public frmAzurirajModnuKucu(ModnaKucaBasic kuca)
    {
        InitializeComponent();
        _kuca = kuca;
    }

    #region Funkcije
    private void Ucitaj()
    {
        txtNaziv.Text = _kuca.Naziv;
        txtIme.Text = _kuca.Osnivac.LicnoIme;
        txtPrezime.Text = _kuca.Osnivac.Prezime;
        txtDrzava.Text = _kuca.Sediste?.Drzava;
        txtGrad.Text = _kuca.Sediste?.Grad;
        txtUlica.Text = _kuca.Sediste?.Ulica;

    }
    private void Procitaj()
    {
        _kuca!.Sediste = new Adresa(txtDrzava.Text, txtGrad.Text, txtUlica.Text); ;
    }
    #endregion

    private void frmAzurirajModnuKucu_Load(object sender, EventArgs e)
    {
        Ucitaj();
    }

    private async void btnAzuriraj_Click(object sender, EventArgs e)
    {
        Procitaj();
        if(await DTOManager.AzurirajModnuKucu(_kuca))
        {
            MessageBox.Show($"Modna kuća {_kuca.Naziv} uspešno ažurirana!");
            Close();
        }
    }

    private void btnOdustani_Click(object sender, EventArgs e)
    {
        Close();
    }
}

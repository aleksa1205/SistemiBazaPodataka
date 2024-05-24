namespace FashionWeek.Forms.Utils.KucaForme;

public partial class frmAzurirajModnuKucu : Form
{
    ModnaKucaBasic? modnaKuca = null;
    #region Funkcije
    private async void Ucitaj()
    {
        modnaKuca = await DTOManager.VratiModnuKucu(frmModneKuce._nazivModneKuce!);
        if (modnaKuca != null)
        {
            txtNaziv.Text = modnaKuca.Naziv;
            txtIme.Text = modnaKuca.Osnivac.LicnoIme;
            txtPrezime.Text = modnaKuca.Osnivac.Prezime;
            txtDrzava.Text = modnaKuca.Sediste?.Drzava;
            txtGrad.Text = modnaKuca.Sediste?.Grad;
            txtUlica.Text = modnaKuca.Sediste?.Ulica;
        }
        else
        {
            MessageBox.Show("Greška pri učitavanju modne kuće!");
            Close();
        }
    }
    private void Procitaj()
    {
        modnaKuca!.Sediste = new Adresa(txtDrzava.Text, txtGrad.Text, txtUlica.Text);;
    }
    #endregion
    public frmAzurirajModnuKucu()
    {
        InitializeComponent();
    }

    private void frmAzurirajModnuKucu_Load(object sender, EventArgs e)
    {
        Ucitaj();
    }

    private async void btnAzuriraj_Click(object sender, EventArgs e)
    {
        Procitaj();
        if(await DTOManager.AzurirajModnuKucu(modnaKuca))
        {
            MessageBox.Show("Modna kuća uspešno ažuriana!");
            Close();
        }
    }

    private void btnOdustani_Click(object sender, EventArgs e)
    {
        Close();
    }
}

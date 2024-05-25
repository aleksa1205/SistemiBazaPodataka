namespace FashionWeek.Forms.Utils.KucaForme;

public partial class frmDodajModnuKucu : Form
{
    public frmDodajModnuKucu()
    {
        InitializeComponent();
    }

    #region Funkcije
    private bool ProveriPolja()
    {
        bool checker = true;
        StringBuilder stringBuilder = new StringBuilder();
        if (string.IsNullOrEmpty(txtNaziv.Text))
        {
            stringBuilder.AppendLine("Polje Naziv ne sme biti prazno!");
        }
        if (string.IsNullOrEmpty(txtIme.Text))
        {
            stringBuilder.AppendLine("Polje Ime osnivača ne sme biti prazno!");

        }
        if (string.IsNullOrEmpty(txtPrezime.Text))
        {
            stringBuilder.AppendLine("Polje Prezime osnivača ne sme biti prazno");
        }
        if (!checker)
        {
            MessageBox.Show(stringBuilder.ToString());
        }
        return checker;
    }
    #endregion

    private async void btnSacuvaj_Click(object sender, EventArgs e)
    {
        if (!ProveriPolja())
        {
            return;
        }
        ModnaKucaBasic modnaKuca = new ModnaKucaBasic()
        {
            Naziv = txtNaziv.Text,
            Osnivac = new(txtIme.Text, txtPrezime.Text),
            Sediste = new(txtDrzava.Text, txtGrad.Text, txtUlica.Text)
        };
        if(await DTOManager.DodajModnuKucu(modnaKuca))
        {
            MessageBox.Show($"Modna kuća {modnaKuca.Naziv} uspešno dodata!");
            Close();
        }
    }

    private void btnOdustani_Click(object sender, EventArgs e)
    {
        Close();
    }
}

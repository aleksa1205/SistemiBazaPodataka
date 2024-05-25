namespace FashionWeek.Forms.Utils.RevijaForme;

public partial class frmDodajReviju : Form
{
    public frmDodajReviju()
    {
        InitializeComponent();
    }

    private async void btnSacuvaj_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtNaziv.Text))
        {
            MessageBox.Show("Polje naziv ne sme biti prazno!");
            return;
        }
        ModnaRevijaBasic revija = new ModnaRevijaBasic()
        {
            Naziv = txtNaziv.Text,
            Termin = dtpTermin.Value,
            Mesto = new Adresa(txtDrzava.Text, txtGrad.Text, txtUlica.Text)
        };

        if (await DTOManager.DodajReviju(revija))
        {
            MessageBox.Show($"Revija {revija.Naziv} je uspešno dodata!");
            Close();
        }
    }

    private void btnOdustani_Click(object sender, EventArgs e)
    {
        Close();
    }
}

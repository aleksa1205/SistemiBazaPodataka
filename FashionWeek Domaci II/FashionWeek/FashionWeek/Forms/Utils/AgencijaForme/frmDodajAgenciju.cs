namespace FashionWeek.Forms.Utils.AgencijaForme;

public partial class frmDodajAgenciju : Form
{
    public frmDodajAgenciju()
    {
        InitializeComponent();
    }

    #region Funkcije
    private bool ProveriBrojeve(string numbers)
    {
        foreach (var ch in numbers)
        {
            if (ch <= 0 || ch >= 9)
            {
                return false;
            }
        }
        return true;
    }

    private bool ProveriPolja()
    {
        bool checker = true;
        StringBuilder stringBuilder = new StringBuilder();
        if (string.IsNullOrEmpty(txtPIB.Text))
        {
            stringBuilder.AppendLine("Polje PIB ne sme biti prazno!");
            checker = false;
        }
        if (string.IsNullOrEmpty(txtNaziv.Text))
        {
            stringBuilder.AppendLine("Polje Naziv ne sme biti prazno!");
            checker = false;
        }
        if (txtPIB.Text.Length != 8)
        {
            stringBuilder.AppendLine("Polje PIB mora biti dužine 8!");
            checker = false;
        }
        if (ProveriBrojeve(txtPIB.Text))
        {
            stringBuilder.AppendLine("U polje PIB mogu biti upisani samo brojevi!");
            checker = false;
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
        if(!ProveriPolja())
        {
            return;
        }
        ModnaAgencijaBasic? modnaAgencija = await DTOManager.VratiModnuAgenciju(txtPIB.Text);
        if (modnaAgencija != null)
        {
            MessageBox.Show($"Modna agencija sa PIB-om {txtPIB.Text} već postoji!");
            return;
        }
        if (rbDomaca.Checked)
        {
            modnaAgencija = new DomacaAgencijaBasic
            {
                PIB = txtPIB.Text,
                Naziv = txtNaziv.Text,
                Inostrana = 'N',
                DatumOsnivanja = dtpDatumOsnivanja.Value,
                Sediste = new Adresa()
            };
        }
        else
        {
            modnaAgencija = new InostranaAgencijaBasic
            {
                PIB = txtPIB.Text,
                Naziv = txtNaziv.Text,
                Inostrana = 'Y',
                DatumOsnivanja = dtpDatumOsnivanja.Value,
                Sediste = new Adresa()
            };
        }
        modnaAgencija.Sediste.Drzava = txtDrzava.Text;
        modnaAgencija.Sediste.Grad = txtGrad.Text;
        modnaAgencija.Sediste.Ulica = txtUlica.Text;

        if (await DTOManager.DodajModnuAgenciju(modnaAgencija))
        {
            MessageBox.Show($"Modna agencija {modnaAgencija.PIB}: {modnaAgencija.Naziv} je uspešno dodata!");
            Close();
        }
    }

    private void btnOdustani_Click(object sender, EventArgs e)
    {
        Close();
    }
}

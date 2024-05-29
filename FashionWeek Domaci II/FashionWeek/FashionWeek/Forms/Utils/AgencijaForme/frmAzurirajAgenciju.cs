namespace FashionWeek.Forms.Utils.AgencijaForme;

public partial class frmAzurirajAgenciju : Form
{
    private ModnaAgencijaBasic _agencija;

    public frmAzurirajAgenciju(ModnaAgencijaBasic agencija)
    {
        InitializeComponent();
        _agencija = agencija;
    }

    #region Funkcije
    private void Ucitaj()
    {
        txtPIB.Text = _agencija.PIB;
        txtNaziv.Text = _agencija.Naziv;
        dtpDatumOsnivanja.Value = _agencija.DatumOsnivanja;
        txtDrzava.Text = _agencija.Sediste?.Drzava;
        txtGrad.Text = _agencija.Sediste?.Grad;
        txtUlica.Text = _agencija.Sediste?.Ulica;
        if (_agencija is InostranaAgencijaBasic)
        {
            rbInostrana.Checked = true;
        }
        else
        {
            rbDomaca.Checked = true;
        }
    }

    private void Procitaj()
    {
        _agencija!.Naziv = txtNaziv.Text;
        _agencija.DatumOsnivanja = dtpDatumOsnivanja.Value;
        _agencija.Sediste = new(txtDrzava.Text, txtGrad.Text, txtUlica.Text);
    }
    #endregion

    private void frmAzurirajAgenciju_Load(object sender, EventArgs e)
    {
        Ucitaj();
        txtPIB.Enabled = false;
        gbTip.Enabled = false;
    }

    private async void btnSacuvaj_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtNaziv.Text))
        {
            MessageBox.Show("Polje naziv mora biti popunjeno!");
            return;
        }
        Procitaj();
        if(await DTOManager.AzurirajModnuAgenciju(_agencija))
        {
            MessageBox.Show($"Uspešno ažurirana modna agencija {_agencija.Naziv}!");
            Close();
        }
    }

    private void btnOdustani_Click(object sender, EventArgs e)
    {
        Close();
    }
}

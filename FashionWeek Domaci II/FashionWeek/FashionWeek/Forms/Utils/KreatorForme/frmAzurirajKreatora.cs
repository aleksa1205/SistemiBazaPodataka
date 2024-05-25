namespace FashionWeek.Forms.Utils.KreatorForme;

public partial class frmAzurirajKreatora : Form
{
    private ModniKreatorBasic _kreator;

    public frmAzurirajKreatora(ModniKreatorBasic kreator)
    {
        InitializeComponent();
        _kreator = kreator;
    }

    #region Funkcije
    private bool ProveriPolja()
    {
        bool checker = true;
        StringBuilder stringBuilder = new StringBuilder();
        if (string.IsNullOrEmpty(txtIme.Text))
        {
            stringBuilder.AppendLine("Polje Ime mora biti popunjeno!");
            checker = false;
        }
        if (string.IsNullOrEmpty(txtPrezime.Text))
        {
            stringBuilder.AppendLine("Polje Prezime mora biti popunjeno!");
            checker = false;
        }
        if (cmbPol.SelectedIndex == -1)
        {
            stringBuilder.AppendLine("Mora biti izabran jedan od dva ponuđena pola!");
            checker = false;
        }
        if (!checker)
        {
            MessageBox.Show(stringBuilder.ToString());
        }
        return checker;
    }

    private void Ucitaj()
    {
        txtMBR.Text = _kreator.MBR;
        txtIme.Text = _kreator.Ime.LicnoIme;
        txtPrezime.Text = _kreator.Ime.Prezime;
        dtpDatumRodjenja.Value = _kreator.DatumRodjenja;
        cmbPol.SelectedIndex = cmbPol.FindString(_kreator.Pol.ToString());
        txtZemljaPorekla.Text = _kreator.ZemljaPorekla;
    }

    private void Procitaj()
    {
        _kreator.Ime.LicnoIme = txtIme.Text;
        _kreator.Ime.Prezime = txtPrezime.Text;
        _kreator.DatumRodjenja = dtpDatumRodjenja.Value;
        _kreator.Pol = cmbPol.SelectedItem.ToString()[0];
        _kreator.ZemljaPorekla = txtZemljaPorekla.Text;
    }
    #endregion

    private void frmAzurirajKreatora_Load(object sender, EventArgs e)
    {
        Ucitaj();
    }

    private async void btnSacuvaj_Click(object sender, EventArgs e)
    {
        if (!ProveriPolja())
        {
            return;
        }
        Procitaj();
        if(await DTOManager.AzurirajModnogKreatora(_kreator!))
        {
            MessageBox.Show("Uspešno ažuriran modni kreator!");
            Close();
        }
    }

    private void btnOdustani_Click(object sender, EventArgs e)
    {
        Close();
    }
}

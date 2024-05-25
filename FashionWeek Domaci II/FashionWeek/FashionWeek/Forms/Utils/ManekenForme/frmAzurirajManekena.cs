namespace FashionWeek.Forms.Utils.ManekenForme;

public partial class frmAzurirajManekena : Form
{
    private ManekenBasic _maneken;
    public frmAzurirajManekena(ManekenBasic maneken)
    {
        InitializeComponent();
        _maneken = maneken;
    }

    #region Funkcije
    private bool ProveriBrojeve(string number)
    {
        foreach (char ch in number)
        {
            if (!char.IsDigit(ch))
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
        if (string.IsNullOrEmpty(txtMBR.Text))
        {
            stringBuilder.AppendLine("Polje MBR mora biti popunjeno!");
            checker = false;
        }
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
        if (txtMBR.Text.Length != 13)
        {
            stringBuilder.AppendLine("MBR mora biti dužine 13!");
            checker = false;
        }
        if (!ProveriBrojeve(txtVisina.Text))
        {
            stringBuilder.AppendLine("U polje za visinu mogu se unositi samo brojevi!");
            checker = false;
        }
        if (!ProveriBrojeve(txtTezina.Text))
        {
            stringBuilder.AppendLine("U polje za težinu mogu se unositi samo brojevi!");
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
        txtMBR.Text = _maneken.MBR;
        txtIme.Text = _maneken.Ime.LicnoIme;
        txtPrezime.Text = _maneken.Ime.Prezime;
        dtpDatumRodjenja.Value = _maneken!.DatumRodjenja;
        cmbPol.SelectedIndex = cmbPol.FindString(_maneken.Pol.ToString());
        txtVisina.Text = _maneken.Visina.ToString();
        txtTezina.Text = _maneken.Tezina.ToString();
        txtBojaOciju.Text = _maneken.BojaOciju;
        txtBojaKose.Text = _maneken.BojaKose;
        txtKonfBroj.Text = _maneken.KonfekcijskiBroj;
        txtZanimanje.Text = _maneken.Zanimanje;
    }

    private void Procitaj()
    {
        _maneken!.Ime.LicnoIme = txtIme.Text;
        _maneken.Ime.Prezime = txtPrezime.Text;
        _maneken.DatumRodjenja = dtpDatumRodjenja.Value;
        _maneken.Pol = cmbPol.SelectedItem.ToString()[0];
        _maneken.Visina = int.Parse(txtVisina.Text);
        _maneken.Tezina = double.Parse(txtTezina.Text);
        _maneken.BojaOciju = txtBojaOciju.Text;
        _maneken.BojaKose = txtBojaKose.Text;
        _maneken.KonfekcijskiBroj = txtKonfBroj.Text;
        _maneken.Zanimanje = txtZanimanje.Text;
    }   
    #endregion

    private void frmAzurirajManekena_Load(object sender, EventArgs e)
    {
        Ucitaj();
    }

    private async void btnAzuriraj_Click(object sender, EventArgs e)
    {
        if (!ProveriPolja())
        {
            return;
        }
        Procitaj();
        if (await DTOManager.AzurirajManekena(_maneken!))
        {
            MessageBox.Show($"Uspešno ažuriran maneken {_maneken!.Ime.ToString()}!");
            Close();
        }
    }

    private void btnOdustani_Click(object sender, EventArgs e)
    {
        Close();
    }
}

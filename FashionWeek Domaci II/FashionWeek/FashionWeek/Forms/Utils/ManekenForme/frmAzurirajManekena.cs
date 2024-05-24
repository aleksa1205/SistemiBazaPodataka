namespace FashionWeek.Forms.Utils.ManekenForme;

public partial class frmAzurirajManekena : Form
{
    public static ManekenBasic? maneken = null;
    public frmAzurirajManekena()
    {
        InitializeComponent();
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

    private async void Ucitaj()
    {
        maneken = await DTOManager.VratiManekena(frmManekeni._manekenMBR!);
        if(maneken != null)
        {
            txtMBR.Text = maneken.MBR;
            txtIme.Text = maneken.Ime.LicnoIme;
            txtPrezime.Text = maneken?.Ime.Prezime;
            dtpDatumRodjenja.Value = maneken!.DatumRodjenja;
            cmbPol.SelectedIndex = cmbPol.FindString(maneken.Pol.ToString());
            txtVisina.Text = maneken.Visina.ToString();
            txtTezina.Text = maneken.Tezina.ToString();
            txtBojaOciju.Text = maneken.BojaOciju;
            txtBojaKose.Text = maneken.BojaKose;
            txtKonfBroj.Text = maneken.KonfekcijskiBroj;
            txtZanimanje.Text = maneken.Zanimanje;
        }
        else
        {
            MessageBox.Show("Greška pri učitavanju manekena!");
            Close();
        }
    }

    private void Procitaj()
    {
        maneken.Ime.LicnoIme = txtIme.Text;
        maneken.Ime.Prezime = txtPrezime.Text;
        maneken.DatumRodjenja = dtpDatumRodjenja.Value;
        maneken.Pol = cmbPol.SelectedItem.ToString()[0];
        maneken.Visina = int.Parse(txtVisina.Text);
        maneken.Tezina = double.Parse(txtTezina.Text);
        maneken.BojaOciju = txtBojaOciju.Text;
        maneken.BojaKose = txtBojaKose.Text;
        maneken.KonfekcijskiBroj = txtKonfBroj.Text;
        maneken.Zanimanje = txtZanimanje.Text;
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
        if (await DTOManager.AzurirajManekena(maneken!))
        {
            MessageBox.Show("Uspešno ažuriran maneken!");
            Close();
        }
    }

    private void btnOdustani_Click(object sender, EventArgs e)
    {
        Close();
    }
}

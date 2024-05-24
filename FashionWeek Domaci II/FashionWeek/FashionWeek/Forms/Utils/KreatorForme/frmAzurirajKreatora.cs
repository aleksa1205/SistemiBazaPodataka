namespace FashionWeek.Forms.Utils.KreatorForme;

public partial class frmAzurirajKreatora : Form
{
    public static ModniKreatorBasic? kreator = null;
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

    private async void Ucitaj()
    {
        kreator = await DTOManager.VratiModnogKreatora(frmKreatori._kreatorMBR!);
        if (kreator != null)
        {
            txtMBR.Text = kreator.MBR;
            txtIme.Text = kreator.Ime.LicnoIme;
            txtPrezime.Text = kreator.Ime.Prezime;
            dtpDatumRodjenja.Value = kreator.DatumRodjenja;
            cmbPol.SelectedIndex = cmbPol.FindString(kreator.Pol.ToString());
            txtZemljaPorekla.Text = kreator.ZemljaPorekla;
        }
        else
        {
            MessageBox.Show("Greška pri učitavanju modnog kreatora!");
            Close();
        }
    }

    private void Procitaj()
    {
        kreator.Ime.LicnoIme = txtIme.Text;
        kreator.Ime.Prezime = txtPrezime.Text;
        kreator.DatumRodjenja = dtpDatumRodjenja.Value;
        kreator.Pol = cmbPol.SelectedItem.ToString()[0];
        kreator.ZemljaPorekla = txtZemljaPorekla.Text;
    }
    #endregion

    public frmAzurirajKreatora()
    {
        InitializeComponent();
    }

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
        if(await DTOManager.AzurirajModnogKreatora(kreator!))
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

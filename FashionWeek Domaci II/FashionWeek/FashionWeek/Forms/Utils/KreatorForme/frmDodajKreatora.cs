namespace FashionWeek.Forms.Utils.KreatorForme;

public partial class frmDodajKreatora : Form
{
    #region Funkcije
    private bool ProveriBrojeve(string number)
    {
        foreach (char ch in number)
        {
            if (!Char.IsDigit(ch))
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
        if (!ProveriBrojeve(txtMBR.Text))
        {
            stringBuilder.AppendLine("U polju MBR mogu se unositi samo brojevi!");
            checker = false;
        }
        if (!checker)
        {
            MessageBox.Show(stringBuilder.ToString());
        }
        return checker;
    }
    #endregion
    public frmDodajKreatora()
    {
        InitializeComponent();
    }

    private async void btnSacuvaj_Click(object sender, EventArgs e)
    {
        if (!ProveriPolja())
        {
            return;
        }
        ModniKreatorBasic? kreator = await DTOManager.VratiModnogKreatora(txtMBR.Text);
        if (kreator != null)
        {
            MessageBox.Show($"Modni kreator sa MBR-om {txtMBR.Text} već postoji!");
            return;
        }
        kreator = new ModniKreatorBasic()
        {
            MBR = txtMBR.Text,
            Ime = new(txtIme.Text, txtPrezime.Text),
            DatumRodjenja = dtpDatumRodjenja.Value,
            Pol = (cmbPol.SelectedItem!.ToString()!)[0],
            ZemljaPorekla = txtZemljaPorekla.Text
        };

        if(await DTOManager.DodajModnogKreatora(kreator))
        {
            MessageBox.Show($"Modni kreator {kreator.MBR}: {kreator.Ime.ToString()} uspešno dodat!");
            Close();
        }
    }

    private void btnOdustani_Click(object sender, EventArgs e)
    {
        Close();
    }
}

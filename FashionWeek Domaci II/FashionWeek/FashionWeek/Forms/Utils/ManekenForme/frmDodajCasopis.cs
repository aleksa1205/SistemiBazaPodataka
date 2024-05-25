namespace FashionWeek.Forms.Utils.ManekenForme;

public partial class frmDodajCasopis : Form
{
    private string _manekenMBR;
    public frmDodajCasopis(string manekenMBR)
    {
        InitializeComponent();
        _manekenMBR = manekenMBR;
    }

    private async void btnDodajCasopis_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtNazivCasopisa.Text))
        {
            MessageBox.Show("Naziv časopisa mora biti popunjen!");
            return;
        }
        if (await DTOManager.DodajCasopis(_manekenMBR, txtNazivCasopisa.Text))
        {
            MessageBox.Show($"Uspešno dodat časopis {txtNazivCasopisa.Text}!");
            Close();
        }
    }

    private void btnOdustani_Click(object sender, EventArgs e)
    {
        Close();
    }
}

namespace FashionWeek.Forms.Utils.AgencijaForme;

public partial class frmDodajZemlju : Form
{
    private string _agencijaPIB;

    public frmDodajZemlju(string agencijaPIB)
    {
        InitializeComponent();
        _agencijaPIB = agencijaPIB;
    }

    private async void btnDodajZemlju_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtNazivZemlje.Text))
        {
            MessageBox.Show("Naziv zemlje ne sme biti prazan!");
            return;
        }
        if (await DTOManager.DodajZemlju(_agencijaPIB, txtNazivZemlje.Text))
        {
            MessageBox.Show($"Uspešno dodata zemlja {txtNazivZemlje.Text}!");
            Close();
        }
    }

    private void btnOdustani_Click(object sender, EventArgs e)
    {
        Close();
    }
}

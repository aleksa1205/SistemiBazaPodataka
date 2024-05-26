namespace FashionWeek.Forms.Utils.OrganizatorForme;

public partial class frmAzurirajOrganizatora : Form
{
    private OrganizatorBasic _organizator;

    public frmAzurirajOrganizatora(OrganizatorBasic organizator)
    {
        InitializeComponent();
        _organizator = organizator;
    }

    #region Funkcije
    private void Ucitaj()
    {
        txtID.Text = _organizator.Id.ToString();
        if (_organizator.PrvaRevija == 'T')
        {
            rbYes.Checked = true;
        }
        else
        {
            rbNo.Checked = true;
        }
        txtInfo.Text = _organizator.InformacijeOKolekciji;
    }
    private void Procitaj()
    {
        _organizator.PrvaRevija = rbYes.Checked ? 'T' : 'F';
        _organizator.InformacijeOKolekciji = txtInfo.Text;
    }
    #endregion


    private void frmAzurirajOrganizatora_Load(object sender, EventArgs e)
    {
        Ucitaj();
    }

    private async void btnAzuriraj_Click(object sender, EventArgs e)
    {
        Procitaj();
        if (await DTOManager.AzurirajOrganizatora(_organizator))
        {
            MessageBox.Show($"Uspešno ažuriran organizator sa ID-em {_organizator.Id}!");
            Close();
        }
    }

    private void btnOdustani_Click(object sender, EventArgs e)
    {
        Close();
    }
}

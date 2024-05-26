namespace FashionWeek.Forms.Utils.OrganizatorForme;

public partial class frmDodajOrganizatora : Form
{
    public frmDodajOrganizatora()
    {
        InitializeComponent();
    }

    private async void btnDodajOrganizatora_Click(object sender, EventArgs e)
    {
        OrganizatorBasic organizator = new OrganizatorBasic()
        {
            PrvaRevija = rbYes.Checked ? 'T' : 'F',
            InformacijeOKolekciji = txtInfo.Text
        };
        if (await DTOManager.DodajOrganizatora(organizator))
        {
            MessageBox.Show("Uspešno dodat organizator!");
            Close();
        }
    }

    private void btnOdustani_Click_1(object sender, EventArgs e)
    {
        Close();
    }
}

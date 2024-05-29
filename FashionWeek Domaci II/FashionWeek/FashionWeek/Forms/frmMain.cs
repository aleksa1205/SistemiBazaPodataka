namespace FashionWeek.Forms;

public partial class frmMain : Form
{
    public frmMain()
    {
        InitializeComponent();
    }

    private void btnManekeni_Click(object sender, EventArgs e)
    {
        frmManekeni frmManeken = new frmManekeni();
        frmManeken.ShowDialog();
    }

    private void btnAgencije_Click(object sender, EventArgs e)
    {
        frmAgencije frmAgencije = new frmAgencije();
        frmAgencije.ShowDialog();
    }

    private void btnRevije_Click(object sender, EventArgs e)
    {
        frmRevije frmRevije = new frmRevije();
        frmRevije.ShowDialog();
    }

    private void btnKreatori_Click(object sender, EventArgs e)
    {
        frmKreatori frmKreatori = new frmKreatori();
        frmKreatori.ShowDialog();
    }

    private void btnModneKuce_Click(object sender, EventArgs e)
    {
        frmModneKuce frmModneKuce = new frmModneKuce();
        frmModneKuce.ShowDialog();
    }

    private void btnOrganizatori_Click(object sender, EventArgs e)
    {
        frmOrganizatori frmOrganizatori = new frmOrganizatori();
        frmOrganizatori.ShowDialog();
    }
}
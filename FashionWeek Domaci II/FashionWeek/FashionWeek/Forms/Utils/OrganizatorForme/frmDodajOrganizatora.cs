namespace FashionWeek.Forms.Utils.OrganizatorForme;

public partial class frmDodajOrganizatora : Form
{
    public frmDodajOrganizatora()
    {
        InitializeComponent();
    }

    #region Funkcije
    private async void UcitajPodatke()
    {
        lvIdentifikatori.Items.Clear();
        List<string> ids = await DTOManager.VratiMoguceOrganizatore();
        foreach (string id in ids)
        {
            lvIdentifikatori.Items.Add(id);
        }
        lvIdentifikatori.Refresh();
    }
    #endregion

    private async void btnDodajOrganizatora_Click(object sender, EventArgs e)
    {
        OrganizatorBasic organizator = new OrganizatorBasic()
        {
            PrvaRevija = rbYes.Checked ? 'T' : 'F',
            InformacijeOKolekciji = txtInfo.Text,
        };
        if (await DTOManager.DodajOrganizatora(organizator, lvIdentifikatori.SelectedItems[0].Text))
        {
            MessageBox.Show("Uspešno dodat organizator!");
            Close();
        }
    }

    private void btnOdustani_Click_1(object sender, EventArgs e)
    {
        Close();
    }

    private void frmDodajOrganizatora_Load(object sender, EventArgs e)
    {
        UcitajPodatke();
    }

    private void lvIdentifikatori_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lvIdentifikatori.SelectedItems.Count > 0)
        {
            btnDodajOrganizatora.Enabled = true;
        }
        else
        {
            btnDodajOrganizatora.Enabled = false;
        }
    }
}

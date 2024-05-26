namespace FashionWeek.Forms.Utils.OrganizatorForme;

public partial class frmDodajRevijuOrganizator : Form
{
    private int _organizatorId;

    public frmDodajRevijuOrganizator(int organizatorId)
    {
        InitializeComponent();
        _organizatorId = organizatorId;
    }

    #region Funkicije
    private async void UcitajPodatke()
    {
        lvRevije.Items.Clear();
        var revije = await DTOManager.VratiModneRevijeBezOrganizatora();
        foreach (var revija in revije)
        {
            ListViewItem item = new ListViewItem(new string[] { revija.RBR.ToString(), revija.Naziv, revija.Mesto?.ToString(), revija.Termin.ToShortDateString() });
            lvRevije.Items.Add(item);
        }
        lvRevije.Refresh();
    }
    #endregion

    private void frmDodajRevijuOrganizator_Load(object sender, EventArgs e)
    {
        UcitajPodatke();
    }

    private void lvRevije_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lvRevije.SelectedItems.Count > 0)
        {
            btnDodajReviju.Enabled = true;
        }
        else
        {
            btnDodajReviju.Enabled = false;
        }
    }

    private async void btnDodajReviju_Click(object sender, EventArgs e)
    {
        if (await DTOManager.DodajOrganizatoraModnojReviji(Int32.Parse(lvRevije.SelectedItems[0].Text), _organizatorId)) 
        {
            MessageBox.Show($"Uspešno dodat orgnaizator {_organizatorId} reviji {lvRevije.SelectedItems[0].SubItems[1].Text}!");
            UcitajPodatke();
            lvRevije.SelectedItems.Clear();
        }
    }

    private void btnIzadji_Click(object sender, EventArgs e)
    {
        Close();
    }
}

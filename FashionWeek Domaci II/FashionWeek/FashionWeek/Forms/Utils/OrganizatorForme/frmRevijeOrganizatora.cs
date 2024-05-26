using System.Runtime.CompilerServices;

namespace FashionWeek.Forms.Utils.OrganizatorForme;

public partial class frmRevijeOrganizatora : Form
{
    private int _orgniazatorId;

    public frmRevijeOrganizatora(int organizatorId)
    {
        InitializeComponent();
        _orgniazatorId = organizatorId;
    }

    #region Funkcije
    private async void UcitajPodatke()
    {
        lvRevije.Items.Clear();
        var revije = await DTOManager.VratiModneRevijeOrganizatora(_orgniazatorId);
        foreach (var revija in revije)
        {
            ListViewItem item = new ListViewItem(new string[] { revija.RBR.ToString(), revija.Naziv, revija.Mesto?.ToString(), revija.Termin.ToShortDateString() });
            lvRevije.Items.Add(item);
        }
        lvRevije.Refresh();
    }
    #endregion

    private void frmRevijeOrganizatora_Load(object sender, EventArgs e)
    {
        lblRevije.Text += _orgniazatorId.ToString() + ':';
        UcitajPodatke();
    }

    private void lvRevije_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lvRevije.SelectedItems.Count > 0)
        {
            btnObrisiReviju.Enabled = true;
        }
        else
        {
            btnObrisiReviju.Enabled = false;
        }
    }

    private void btnDodajReviju_Click(object sender, EventArgs e)
    {
        frmDodajRevijuOrganizator frmDodajReviju = new frmDodajRevijuOrganizator(_orgniazatorId);
        frmDodajReviju.ShowDialog();
        UcitajPodatke();
        lvRevije.SelectedItems.Clear();
    }

    private async void btnObrisiReviju_Click_1(object sender, EventArgs e)
    {
        if (await DTOManager.ObrisiOrganizatoraModnojReviji(Int32.Parse(lvRevije.SelectedItems[0].Text)))
        {
            MessageBox.Show($"Uspešno obrisan organizator {_orgniazatorId} sa revije {lvRevije.SelectedItems[0].SubItems[1].Text}!");
            UcitajPodatke();
            lvRevije.SelectedItems.Clear();
        }
    }

    private void btnIzadji_Click(object sender, EventArgs e)
    {
        Close();
    }

}

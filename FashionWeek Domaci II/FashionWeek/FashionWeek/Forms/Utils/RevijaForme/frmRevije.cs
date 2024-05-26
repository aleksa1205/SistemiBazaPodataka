namespace FashionWeek.Forms.Utils.Revija;

public partial class frmRevije : Form
{
    private ModnaRevijaBasic? _revija = null;

    public frmRevije()
    {
        InitializeComponent();
    }

    #region Funkcije
    private void EnableButtons()
    {
        btnAzurirajReviju.Enabled = true;
        btnObrisiReviju.Enabled = true;
        btnUcesnici.Enabled = true;
        btnKreatori.Enabled = true;
        if (_revija.Organizator != null)
        {
            btnSpecijalniGosti.Enabled = true;
        }
    }

    private void DisableButtons()
    {
        btnAzurirajReviju.Enabled = false;
        btnObrisiReviju.Enabled = false;
        btnUcesnici.Enabled = false;
        btnKreatori.Enabled = false;
        btnSpecijalniGosti.Enabled = false;
    }

    private async void UcitajPodatke()
    {
        lvRevije.Items.Clear();
        IList<ModnaRevijaPregled> revije = await DTOManager.VratiModneRevije();
        foreach (var revija in revije)
        {
            ListViewItem item = new ListViewItem(new string[] { revija.RBR.ToString(), revija.Naziv, revija.Mesto?.ToString(), revija.Termin.ToShortDateString() });
            lvRevije.Items.Add(item);
        }
        lvRevije.Refresh();
    }
    #endregion

    private void frmRevije_Load(object sender, EventArgs e)
    {
        UcitajPodatke();
    }

    private async void lvRevije_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lvRevije.SelectedItems.Count > 0)
        {
            _revija = await DTOManager.VratiModnuReviju(Int32.Parse(lvRevije.SelectedItems[0].Text));
            EnableButtons();
        }
        else
        {
            DisableButtons();
        }
    }

    private void btnDodajReviju_Click(object sender, EventArgs e)
    {
        frmDodajReviju revija = new frmDodajReviju();
        revija.ShowDialog();
        UcitajPodatke();
        lvRevije.SelectedItems.Clear();
    }

    private void btnAzurirajReviju_Click(object sender, EventArgs e)
    {
        frmAzurirajReviju frmAzuriraj = new frmAzurirajReviju(_revija);
        frmAzuriraj.ShowDialog();
        UcitajPodatke();
        lvRevije.SelectedItems.Clear();
    }

    private async void btnObrisiReviju_Click(object sender, EventArgs e)
    {
        if (await DTOManager.ObrisiReviju(_revija.RBR))
        {
            MessageBox.Show($"Uspešno obrisana revija {_revija.Naziv}!");
            _revija = null;
            UcitajPodatke();
            lvRevije.SelectedItems.Clear();
        }
    }

    private void btnUcesnici_Click(object sender, EventArgs e)
    {

        frmUcesniciRevije frmUcesniciRevije = new frmUcesniciRevije(_revija);
        frmUcesniciRevije.ShowDialog();
        lvRevije.SelectedItems.Clear();
    }

    private void btnKreatori_Click(object sender, EventArgs e)
    {
        frmKreatoriRevije frmKreatori = new frmKreatoriRevije(_revija);
        frmKreatori.ShowDialog();
        lvRevije.SelectedItems.Clear();
    }

    private void btnSpecijalniGosti_Click(object sender, EventArgs e)
    {
        frmSpecijalniGosti frmSpecijalniGosti = new frmSpecijalniGosti(_revija);
        frmSpecijalniGosti.ShowDialog();
        lvRevije.SelectedItems.Clear();
    }

    private void btnIzadji_Click(object sender, EventArgs e)
    {
        Close();
    }
}

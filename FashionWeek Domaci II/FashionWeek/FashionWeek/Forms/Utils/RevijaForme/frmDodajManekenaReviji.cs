namespace FashionWeek.Forms.Utils.RevijaForme;

public partial class frmDodajManekenaReviji : Form
{
    private ModnaRevijaBasic _revija;

    public frmDodajManekenaReviji(ModnaRevijaBasic revija)
    {
        InitializeComponent();
        _revija = revija;
    }

    #region Funkcije
    private async void UcitajPodatke()
    {
        lvManekeni.Items.Clear();
        IList<ManekenPregled> listaManekena = await DTOManager.VratiManekeneKojeNisuNaModnojReviji(_revija.RBR);
        foreach (var maneken in listaManekena)
        {
            ListViewItem item = new ListViewItem(new string[] { maneken.MBR, maneken.Ime?.LicnoIme!, maneken.Ime?.Prezime!, maneken.DatumRodjenja.ToShortDateString(), maneken.Pol.ToString() });
            lvManekeni.Items.Add(item);
        }
        lvManekeni.Refresh();
    }
    #endregion

    private void frmDodajManekenaReviji_Load(object sender, EventArgs e)
    {
        lblListaManekena.Text += _revija.Naziv + ':';
        UcitajPodatke();
    }

    private void lvManekeni_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lvManekeni.SelectedItems.Count > 0)
        {
            btnDodajManekena.Enabled = true;
        }
        else
        {
            btnDodajManekena.Enabled = false;
        }
    }

    private async void btnDodajManekena_Click(object sender, EventArgs e)
    {
        if(await DTOManager.DodajRevijuManekenu(lvManekeni.SelectedItems[0].Text, _revija.RBR))
        {
            MessageBox.Show($"Uspešno dodat maneken {lvManekeni.SelectedItems[0].SubItems[1].Text} {lvManekeni.SelectedItems[0].SubItems[2].Text}!");
            UcitajPodatke();
            lvManekeni.SelectedItems.Clear();
        }
    }

    private void btnOdustani_Click(object sender, EventArgs e)
    {
        Close();
    }
}

namespace FashionWeek.Forms.Utils.ManekenForme;

public partial class frmManekeni : Form
{
    private ManekenBasic? _maneken = null;

    public frmManekeni()
    {
        InitializeComponent();
    }

    #region Funkcije
    private void EnableButtons()
    {
        btnAzurirajManekena.Enabled = true;
        btnObrisiManekena.Enabled = true;
        btnRevije.Enabled = true;
        btnCasopisi.Enabled = true;
    }

    private void DisableButtons()
    {
        btnAzurirajManekena.Enabled = false;
        btnObrisiManekena.Enabled = false;
        btnRevije.Enabled = false;
        btnCasopisi.Enabled = false;
    }

    private async void UcitajPodatke()
    {
        lvManekeni.Items.Clear();
        IList<ManekenPregled> listaManekena = await DTOManager.VratiManekene();
        foreach (var maneken in listaManekena)
        {
            ListViewItem item = new ListViewItem(new string[] { maneken.MBR!, maneken.Ime?.LicnoIme!, maneken.Ime?.Prezime!, maneken.DatumRodjenja.ToShortDateString(), maneken.Pol.ToString(), maneken.RadiU, maneken.Visina.ToString(), maneken.Tezina.ToString(), maneken.BojaOciju, maneken.BojaKose, maneken.KonfekcijskiBroj });
            lvManekeni.Items.Add(item);
        }
        lvManekeni.Refresh();
    }
    #endregion

    private void frmManekeni_Load(object sender, EventArgs e)
    {
        UcitajPodatke();
    }

    private async void lvManekeni_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lvManekeni.SelectedItems.Count > 0)
        {
            _maneken = await DTOManager.VratiManekenaBasic(lvManekeni.SelectedItems[0].Text);
            if (_maneken == null)
            {
                MessageBox.Show("Greška pri pribavljanju manekena!");
                return;
            }
            EnableButtons();
        }
        else
        {
            DisableButtons();
        }
    }

    private void btnDodajManekena_Click(object sender, EventArgs e)
    {
        frmDodajManekena frmDodaj = new frmDodajManekena();
        frmDodaj.ShowDialog();
        UcitajPodatke();
        lvManekeni.SelectedItems.Clear();
    }

    private void btnAzurirajManekena_Click(object sender, EventArgs e)
    {
        frmAzurirajManekena frmAzuriraj = new frmAzurirajManekena(_maneken!);
        frmAzuriraj.ShowDialog();
        lvManekeni.SelectedItems.Clear();
        UcitajPodatke();
    }

    private async void btnObrisiManekena_Click(object sender, EventArgs e)
    {
        if (await DTOManager.ObrisiManekena(_maneken!.MBR))
        {
            MessageBox.Show($"Uspešno obrisan maneken {_maneken.Ime.ToString()}!");
            _maneken = null;
            UcitajPodatke();
            lvManekeni.SelectedItems.Clear();
        }
    }

    private void btnRevije_Click(object sender, EventArgs e)
    {
        frmRevijeManekena frmRevije = new frmRevijeManekena(_maneken!);
        frmRevije.ShowDialog();
    }

    private void btnCasopisi_Click(object sender, EventArgs e)
    {
        frmNaziviCasopisaManekena frmCasopisi = new frmNaziviCasopisaManekena(_maneken!);
        frmCasopisi.ShowDialog();
    }

    private void btnIzadji_Click(object sender, EventArgs e)
    {
        Close();
    }
}

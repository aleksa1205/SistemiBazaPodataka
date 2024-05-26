using FluentNHibernate.Utils;

namespace FashionWeek.Forms.Utils.KucaForme;

public partial class frmVlasnici : Form
{
    private ModnaKucaBasic _kuca;
    public frmVlasnici(ModnaKucaBasic kuca)
    {
        InitializeComponent();
        _kuca = kuca;
    }

    #region Funkcije
    private async void UcitajPodatke()
    {
        lvVlasnici.Items.Clear();
        var vlasnici = await DTOManager.VratiImenaVlasnika(_kuca.Naziv);
        for (int i = 0; i < vlasnici.Count; i++)
        {
            ListViewItem item = new ListViewItem(new string[] { (i + 1).ToString(), vlasnici[i].LicnoIme, vlasnici[i].Prezime });
            lvVlasnici.Items.Add(item);
        }
        lvVlasnici.Refresh();
    }
    #endregion

    private void frmVlasnici_Load(object sender, EventArgs e)
    {
        lblNazivModneKuce.Text = _kuca.Naziv;
        UcitajPodatke();
    }

    private void lvVlasnici_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lvVlasnici.SelectedItems.Count > 0)
        {
            btnObrisiVlasnika.Enabled = true;
        }
        else
        {
            btnObrisiVlasnika.Enabled = false;
        }
    }

    private void btnDodajVlasnika_Click(object sender, EventArgs e)
    {
        frmDodajVlasnika frmDodaj = new frmDodajVlasnika(_kuca.Naziv);
        frmDodaj.ShowDialog();
        UcitajPodatke();
        lvVlasnici.SelectedItems.Clear();
    }

    private async void btnObrisiVlasnika_Click(object sender, EventArgs e)
    {
        if (await DTOManager.ObrisiImeVlasnika(_kuca.Naziv, new Ime(lvVlasnici.SelectedItems[0].SubItems[1].Text, lvVlasnici.SelectedItems[0].SubItems[2].Text)))
        {
            MessageBox.Show("Uspešno obrisan vlasnik!");
            UcitajPodatke();
            lvVlasnici.SelectedItems.Clear();
        }
    }

    private void btnIzadji_Click(object sender, EventArgs e)
    {
        Close();
    }
}

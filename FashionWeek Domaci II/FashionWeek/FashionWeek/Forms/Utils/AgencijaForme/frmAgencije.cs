using FashionWeek.DTO;
using FashionWeek.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FashionWeek.Forms.Utils.AgencijaForme;

public partial class frmAgencije : Form
{
    public static ModnaAgencija? _modnaAgencija = null;

    #region Funkcije
    public async Task<bool> IsInostrana()
    {
        _modnaAgencija = await DTOManager.VratiModnuAgenciju(lvAgencije.SelectedItems[0].Text);
        if (_modnaAgencija != null & _modnaAgencija is InostranaAgencija)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
    public async void EnableButtons()
    {
        btnAzurirajAgenciju.Enabled = true;
        btnObrisiAgenciju.Enabled = true;
        btnPrikaziManekene.Enabled = true;
        btnZaposliManekena.Enabled = true;
        if (await IsInostrana())
        {
            btnZemljePoslovanja.Enabled = true;
        }
    }

    public void DisableButtons()
    {
        btnAzurirajAgenciju.Enabled = false;
        btnObrisiAgenciju.Enabled = false;
        btnPrikaziManekene.Enabled = false;
        btnZemljePoslovanja.Enabled = false;
        btnZaposliManekena.Enabled = false;
    }

    public async void UcitajPodatke()
    {
        lvAgencije.Items.Clear();
        IList<ModnaAgencijaPregled> agencije = await DTOManager.VratiModneAgencije();
        foreach (var agencija in agencije)
        {
            ListViewItem item = new ListViewItem(new string[] { agencija.PIB!, agencija.Naziv!, agencija.Sediste!.ToString(), agencija.DatumOsnivanja.ToShortDateString() });
            lvAgencije.Items.Add(item);
        }
        lvAgencije.Refresh();
    }
    #endregion

    public frmAgencije()
    {
        InitializeComponent();
    }

    private void frmAgencije_Load(object sender, EventArgs e)
    {
        UcitajPodatke();
    }

    private void lvAgencije_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lvAgencije.SelectedItems.Count > 0)
        {
            EnableButtons();
        }
        else
        {
            DisableButtons();
        }
    }

    private void btnDodajAgenciju_Click(object sender, EventArgs e)
    {
        frmDodajAgenciju frmDodajAgenciju = new frmDodajAgenciju();
        frmDodajAgenciju.ShowDialog();
        UcitajPodatke();
        DisableButtons();
    }

    private async void btnAzurirajAgenciju_Click(object sender, EventArgs e)
    {
        _modnaAgencija = await DTOManager.VratiModnuAgenciju(lvAgencije.SelectedItems[0].Text);
        if (_modnaAgencija != null)
        {
            frmAzurirajAgenciju frmAzuriraj = new frmAzurirajAgenciju();
            frmAzuriraj.ShowDialog();
            UcitajPodatke();
            DisableButtons();
        }
        else
        {
            MessageBox.Show("Greška pri pribavljanju agencije iz baze!");
        }
    }

    private async void btnObrisiAgenciju_Click(object sender, EventArgs e)
    {
        _modnaAgencija = await DTOManager.VratiModnuAgenciju(lvAgencije.SelectedItems[0].Text);
        if (_modnaAgencija != null)
        {
            await DTOManager.ObrisiModnuAgenciju(_modnaAgencija);
            MessageBox.Show("Uspešno obrisana agencija!");
            UcitajPodatke();
            DisableButtons();
        }
        else
        {
            MessageBox.Show("Greška pri pribavljanju agencije iz baze!");
        }
    }

    private async void btnPrikaziManekene_Click(object sender, EventArgs e)
    {
        _modnaAgencija = await DTOManager.VratiModnuAgenciju(lvAgencije.SelectedItems[0].Text);
        frmAgencijaManekeni frmManekeni = new frmAgencijaManekeni();
        frmManekeni.ShowDialog();
    }

    private async void btnZemljePoslovanja_Click(object sender, EventArgs e)
    {
        _modnaAgencija = await DTOManager.VratiModnuAgenciju(lvAgencije.SelectedItems[0].Text);
        frmNaziviZemaljaAgencije frmZemlje = new frmNaziviZemaljaAgencije();
        frmZemlje.ShowDialog();
    }

    private void btnZaposliManekena_Click(object sender, EventArgs e)
    {
        frmNezaposleniManekeni frmNezaposleni = new frmNezaposleniManekeni();
        frmNezaposleni.ShowDialog();
    }

    private void btnIzadji_Click(object sender, EventArgs e)
    {
        Close();
    }
}

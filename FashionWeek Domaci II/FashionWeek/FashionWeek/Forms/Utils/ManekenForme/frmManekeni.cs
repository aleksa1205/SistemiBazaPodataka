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

namespace FashionWeek.Forms.Utils.ManekenForme;

public partial class frmManekeni : Form
{
    public static string? _manekenMBR = null;

    #region Funkcije
    public void EnableButtons()
    {
        btnAzurirajManekena.Enabled = true;
        btnObrisiManekena.Enabled = true;
        btnRevije.Enabled = true;
        btnCasopisi.Enabled = true;
    }

    public void DisableButtons()
    {
        btnAzurirajManekena.Enabled = false;
        btnObrisiManekena.Enabled = false;
        btnRevije.Enabled = false;
        btnCasopisi.Enabled = false;
    }

    public async void UcitajPodatke()
    {
        lvManekeni.Items.Clear();
        IList<ManekenPregled> listaManekena = await DTOManager.VratiManekene();
        foreach (var maneken in listaManekena)
        {
            ListViewItem item = new ListViewItem(new string[] { maneken.MBR, maneken.Ime?.LicnoIme!, maneken.Ime?.Prezime!, maneken.DatumRodjenja.ToShortDateString(), maneken.Pol.ToString() });
            lvManekeni.Items.Add(item);
        }
        lvManekeni.Refresh();
    }
    #endregion

    public frmManekeni()
    {
        InitializeComponent();
    }

    private void frmManekeni_Load(object sender, EventArgs e)
    {
        UcitajPodatke();
    }

    private void lvManekeni_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lvManekeni.SelectedItems.Count > 0)
        {
            _manekenMBR = lvManekeni.SelectedItems[0].Text;
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
    }

    private void btnAzurirajManekena_Click(object sender, EventArgs e)
    {

        frmAzurirajManekena frmAzuriraj = new frmAzurirajManekena();
        frmAzuriraj.ShowDialog();
        DisableButtons();
        UcitajPodatke();
    }

    private async void btnObrisiManekena_Click(object sender, EventArgs e)
    {
        if (await DTOManager.ObrisiManekena(_manekenMBR!))
        {
            MessageBox.Show("Uspešno obrisan maneken!");
            UcitajPodatke();
            DisableButtons();
        }
    }

    private void btnRevije_Click(object sender, EventArgs e)
    {
        frmRevijeManekena frmRevije = new frmRevijeManekena();
        frmRevije.ShowDialog();
    }

    private void btnCasopisi_Click(object sender, EventArgs e)
    {
        frmNaziviCasopisaManekena frmCasopisi = new frmNaziviCasopisaManekena();
        frmCasopisi.ShowDialog();
    }

    private void btnIzadji_Click(object sender, EventArgs e)
    {
        Close();
    }
}

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

public partial class frmNaziviZemaljaAgencije : Form
{
    #region Funkcije
    public async void UcitajPodatke()
    {
        lvZemlje.Items.Clear();
        IList<string> listaZemalja = await DTOManager.VratiZemljeUKojimaPoslujeAgencijaPregled(frmAgencije._modnaAgencijaPIB!);
        foreach (var zemlja in listaZemalja)
        {
            ListViewItem item = new ListViewItem(zemlja);
            lvZemlje.Items.Add(item);
        }
        lvZemlje.Refresh();
    }
    #endregion
    public frmNaziviZemaljaAgencije()
    {
        InitializeComponent();
    }

    private void frmAgencijeZemlje_Load(object sender, EventArgs e)
    {
        lblNazivAgencije.Text = frmAgencije._nazivModneAgencije;
        UcitajPodatke();
    }

    private void lvZemlje_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lvZemlje.SelectedItems.Count > 0)
        {
            btnObrisiZemlju.Enabled = true;
        }
        else
        {
            btnObrisiZemlju.Enabled = false;
        }
    }

    private void btnDodajZemlju_Click(object sender, EventArgs e)
    {
        frmDodajZemlju frmDodajZemlju = new frmDodajZemlju();
        frmDodajZemlju.ShowDialog();
        UcitajPodatke();
    }

    private async void btnObrisiZemlju_Click(object sender, EventArgs e)
    {

        if (await DTOManager.ObrisiZemlju(frmAgencije._modnaAgencijaPIB!, lvZemlje.SelectedItems[0].Text))
        {
            MessageBox.Show("Uspešno obrisana zemlja!");
            UcitajPodatke();
            btnObrisiZemlju.Enabled = false;
        }
    }

    private void btnIzadji_Click(object sender, EventArgs e)
    {
        Close();
    }
}

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

public partial class frmNaziviCasopisaManekena : Form
{
    #region Funkcije
    public async void UcitajPodatke()
    {
        lvCasopisi.Items.Clear();
        IList<string> casopisi = await DTOManager.VratiCasopiseManekena(frmManekeni._maneken);
        foreach (var casopis in casopisi)
        {
            lvCasopisi.Items.Add(new ListViewItem(casopis));
        }
        lvCasopisi.Refresh();
    }
    #endregion
    public frmNaziviCasopisaManekena()
    {
        InitializeComponent();
    }

    private void frmNaziviCasopisaManekena_Load(object sender, EventArgs e)
    {
        lblManeken.Text = frmManekeni._maneken.Ime.ToString();
        UcitajPodatke();
    }

    private void lvCasopisi_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lvCasopisi.SelectedItems.Count > 0)
        {
            btnObrisiCasopis.Enabled = true;
        }
        else
        {
            btnObrisiCasopis.Enabled = false;
        }
    }

    private void btnDodajCasopis_Click(object sender, EventArgs e)
    {
        frmDodajCasopis frmDodaj = new frmDodajCasopis();
        frmDodaj.ShowDialog();
        UcitajPodatke();
        btnObrisiCasopis.Enabled = false;
    }

    private async void btnObrisiCasopis_Click(object sender, EventArgs e)
    {
        Casopis casopis = new Casopis()
        {
            Id = new CasopisId()
            {
                Maneken = frmManekeni._maneken,
                NazivCasopisa = lvCasopisi.SelectedItems[0].Text
            }
        };
        if (await DTOManager.ObrisiCasopis(casopis))
        {
            MessageBox.Show("Uspešno obrisan časopis!");
            UcitajPodatke();
            btnObrisiCasopis.Enabled = false;
        }
    }

    private void btnOdustani_Click(object sender, EventArgs e)
    {
        Close();
    }
}

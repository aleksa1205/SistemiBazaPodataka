using FashionWeek.DTO;
using FashionWeek.Entiteti;
using NHibernate;
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

public partial class frmDodajManekena : Form
{
    public frmDodajManekena()
    {
        InitializeComponent();
    }

    #region Funkcije
    private bool ProveriBrojeve(string number)
    {
        foreach (char ch in number)
        {
            if (!Char.IsDigit(ch))
            {
                return false;
            }
        }
        return true;
    }

    private bool ProveriPolja()
    {
        bool checker = true;
        StringBuilder stringBuilder = new StringBuilder();
        if (string.IsNullOrEmpty(txtMBR.Text))
        {
            stringBuilder.AppendLine("Polje MBR mora biti popunjeno!");
            checker = false;
        }
        if (string.IsNullOrEmpty(txtIme.Text))
        {
            stringBuilder.AppendLine("Polje Ime mora biti popunjeno!");
            checker = false;
        }
        if (string.IsNullOrEmpty(txtPrezime.Text))
        {
            stringBuilder.AppendLine("Polje Prezime mora biti popunjeno!");
            checker = false;
        }
        if (cmbPol.SelectedIndex == -1)
        {
            stringBuilder.AppendLine("Mora biti izabran jedan od dva ponuđena pola!");
            checker = false;
        }
        if (txtMBR.Text.Length != 13)
        {
            stringBuilder.AppendLine("MBR mora biti dužine 13!");
            checker = false;
        }
        if (!ProveriBrojeve(txtMBR.Text))
        {
            stringBuilder.AppendLine("U polju MBR mogu se unositi samo brojevi!");
            checker = false;
        }
        if (!ProveriBrojeve(txtVisina.Text))
        {
            stringBuilder.AppendLine("U polje za visinu mogu se unositi samo brojevi!");
            checker = false;
        }
        if (!ProveriBrojeve(txtTezina.Text))
        {
            stringBuilder.AppendLine("U polje za težinu mogu se unositi samo brojevi!");
            checker = false;
        }
        if (!checker)
        {
            MessageBox.Show(stringBuilder.ToString());
        }
        return checker;
    }
    #endregion

    private async void btnSacuvaj_Click(object sender, EventArgs e)
    {
        if (!ProveriPolja())
        {
            return;
        }
        Maneken maneken = await DTOManager.VratiManekena(txtMBR.Text);
        if (maneken != null)
        {
            MessageBox.Show($"Maneken sa MBR-om {txtMBR.Text} već postoji!");
            return;
        }
        maneken = new Maneken
        {
            MBR = txtMBR.Text,
            Ime = new()
            {
                LicnoIme = txtIme.Text,
                Prezime = txtPrezime.Text
            },
            DatumRodjenja = dtpDatumRodjenja.Value,
            Pol = (cmbPol.SelectedItem!.ToString()!)[0],
            Visina = !string.IsNullOrEmpty(txtVisina.Text) ? Int32.Parse(txtVisina.Text) : 0,
            Tezina = !string.IsNullOrEmpty(txtTezina.Text) ? Double.Parse(txtTezina.Text) : 0,
            BojaOciju = txtBojaOciju.Text,
            BojaKose = txtBojaKose.Text,
            KonfekcijskiBroj = txtKonfBroj.Text,
            Zanimanje = txtZanimanje.Text
        };

        if (await DTOManager.DodajManekena(maneken))
        {
            MessageBox.Show($"Maneken {maneken.MBR}: {maneken.Ime.LicnoIme} {maneken.Ime.Prezime} uspešno dodat!");
            Close();
        }
    }

    private void btnOdustani_Click(object sender, EventArgs e)
    {
        Close();
    }
}
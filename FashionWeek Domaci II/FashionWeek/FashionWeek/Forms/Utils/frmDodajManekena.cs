﻿using FashionWeek.DTO;
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

namespace FashionWeek.Forms.Utils
{
    public partial class frmDodajManekena : Form
    {
        public frmDodajManekena()
        {
            InitializeComponent();
        }

        #region Checks
        private bool ProveriBrojeve(string number)
        {
            foreach (char ch in number)
            {
                if (ch <= 0 && ch >= 9 && ch != '.')
                {
                    return false;
                }
            }
            return true;
        }

        private void ProveriPolja()
        {
            bool checker = true;
            StringBuilder stringBuilder = new StringBuilder();
            if (String.IsNullOrEmpty(txtMBR.Text))
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
        }

        private void DodatniKonstruktor(Maneken maneken)
        {
            if (!string.IsNullOrEmpty(txtVisina.Text))
            {
                maneken.Visina = Int32.Parse(txtVisina.Text);
            }
            if (!string.IsNullOrEmpty(txtTezina.Text))
            {
                maneken.Tezina = Double.Parse(txtTezina.Text);
            }
            if (!string.IsNullOrEmpty(txtBojaOciju.Text))
            {
                maneken.BojaOciju = txtBojaOciju.Text;
            }
            if (!string.IsNullOrEmpty(txtBojaKose.Text))
            {
                maneken.BojaKose = txtBojaKose.Text;
            }
            if (!string.IsNullOrEmpty(txtKonfBroj.Text))
            {
                maneken.KonfekcijskiBroj = txtKonfBroj.Text;
            }
            if (!string.IsNullOrEmpty(txtZanimanje.Text))
            {
                maneken.Zanimanje = txtZanimanje.Text;
            }
        }
        #endregion

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            try
            {
                ProveriPolja();
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
                    Pol = (cmbPol.SelectedItem!.ToString()!)[0]
                };
                DodatniKonstruktor(maneken);

                if (await DTOManager.DodajManekena(maneken))
                {
                    MessageBox.Show($"Maneken {maneken.MBR}: {maneken.Ime.LicnoIme} {maneken.Ime.Prezime} uspesno dodat!");
                    Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
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

public partial class frmDodajZemlju : Form
{
    public frmDodajZemlju()
    {
        InitializeComponent();
    }

    private async void btnDodajZemlju_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtNazivZemlje.Text))
        {
            MessageBox.Show("Naziv zemlje ne sme biti prazan!");
            return;
        }
        if (await DTOManager.DodajZemlju(frmAgencije._modnaAgencija as InostranaAgencija, txtNazivZemlje.Text))
        {
            MessageBox.Show("Uspešno dodata zemlja!");
            Close();
        }
    }

    private void btnOdustani_Click(object sender, EventArgs e)
    {
        Close();
    }
}

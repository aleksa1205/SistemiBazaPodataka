using NHibernate.Cfg.Loquacious;
using NHibernate.Criterion;

namespace FashionWeek.Forms.Utils.KucaForme;

public partial class frmDodajVlasnika : Form
{
    private string _nazivKuce;

    public frmDodajVlasnika(string nazivKuce)
    {
        InitializeComponent();
        _nazivKuce = nazivKuce;
    }

    #region Funkcije
    private bool ProveriPolja()
    {
        bool checker = true;
        StringBuilder sb = new StringBuilder();
        if (string.IsNullOrEmpty(txtIme.Text))
        {
            sb.AppendLine("Polje ime ne sme biti prazno!");
            checker = false;
        }
        if (string.IsNullOrEmpty(txtPrezime.Text))
        {
            sb.AppendLine("Polje prezime ne sme biti prazno!");
            checker = false;
        }
        if (!checker)
        {
            MessageBox.Show(sb.ToString());
        }
        return checker;
    }
    #endregion

    private async void btnDodajVlasnika_Click(object sender, EventArgs e)
    {
        if(!ProveriPolja())
        {
            return;
        }
        IList<Ime> listaVlasnika = await DTOManager.VratiImenaVlasnika(_nazivKuce);
        Ime vlasnik = new Ime(txtIme.Text, txtPrezime.Text);
        if (listaVlasnika.Contains(vlasnik))
        {
            MessageBox.Show($"{txtIme.Text} {txtPrezime.Text} je već vlasnik modne kuće!");
            return;
        }
        if(await DTOManager.DodajImeVlasnika(_nazivKuce, vlasnik))
        {
            MessageBox.Show($"Uspešno dodat vlasnik {vlasnik.ToString()}!");
            Close();
        }
    }
}

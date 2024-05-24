namespace FashionWeek.Entiteti.Helper;

public class Adresa
{
    public string? Drzava { get; set; }
    public string? Grad { get; set; }
    public string? Ulica { get; set; }

    #region Constructors
    public Adresa() { }
    public Adresa(string? drzava, string? grad, string? ulica)
    {
        Drzava = drzava;
        Grad = grad;
        Ulica = ulica;
    }
    public Adresa(Adresa adresa)
    {
        Drzava = adresa.Drzava;
        Grad = adresa.Grad;
        Ulica = adresa.Ulica;
    }
    #endregion

    #region Overrides
    public override string ToString()
    {
        return Drzava + "," + Grad + "," + Ulica;
    }
    #endregion
}

namespace FashionWeek.Entiteti.Helper;

public class Ime
{
    public string? LicnoIme { get; set; }
    public string? Prezime { get; set; }

    #region Constructors
    public Ime() { }
    public Ime(string? licnoIme, string? prezime)
    {
        LicnoIme = licnoIme;
        Prezime = prezime;
    }
    public Ime(Ime ime)
    {
        LicnoIme = ime.LicnoIme;
        Prezime = ime.Prezime;
    }
    #endregion

    #region Overrides
    public override string ToString()
    {
        return LicnoIme + ' ' + Prezime;
    }
    #endregion
}

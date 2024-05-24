namespace FashionWeek.DTO;

public class ModnaKucaPregled
{
    public string Naziv { get; set; }
    public Ime? Osnivac { get; set; }
    public Adresa? Sediste { get; set; }

    #region Constructors
    public ModnaKucaPregled(string naziv, Ime osnivac, Adresa sediste)
    {
        Naziv = naziv;
        Osnivac = osnivac;
        Sediste = sediste;
    }
    public ModnaKucaPregled(ModnaKuca modnaKuca)
    {
        Naziv = modnaKuca.Naziv;
        Osnivac = modnaKuca.Osnivac;
        Sediste = modnaKuca.Sediste;
    }
    #endregion
}

public class ModnaKucaBasic
{
    public string? Naziv { get; set; }
    public Ime? Osnivac { get; set; }
    public Adresa? Sediste { get; set; }
    public IList<ModniKreatorBasic> Kreatori { get; set; } = [];
    public OrganizatorBasic? Organizator { get; set; }
    public IList<ImeVlasnikaBasic> Vlasnici { get; set; } = [];

    #region Constructors
    public ModnaKucaBasic() { }
    public ModnaKucaBasic(string naziv, Ime osnivac, Adresa sediste)
    {
        Naziv = naziv;
        Osnivac = osnivac;
        Sediste = sediste;
    }
    public ModnaKucaBasic(ModnaKuca modnaKuca)
    {
        Naziv = modnaKuca.Naziv;
        Osnivac = modnaKuca.Osnivac;
        Sediste = modnaKuca.Sediste;
    }
    #endregion
}
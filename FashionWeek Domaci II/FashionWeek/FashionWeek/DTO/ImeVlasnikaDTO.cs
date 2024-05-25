namespace FashionWeek.DTO;

public class ImeVlasnikaPregled
{
    public ImeVlasnikaId Id { get; set; }

    #region Constructors
    public ImeVlasnikaPregled() { }
    public ImeVlasnikaPregled(ImeVlasnikaId id)
    {
        Id = id;
    }
    #endregion
}

public class ImeVlasnikaIdBasic
{
    public ModnaKucaBasic ModnaKuca { get; set; }
    public string LicnoIme { get; set; }
    public string Prezime { get; set; }

    #region Constuctors
    public ImeVlasnikaIdBasic() { }
    public ImeVlasnikaIdBasic(ImeVlasnikaId Id)
    {
        ModnaKuca = new ModnaKucaBasic(Id.ModnaKuca);
        LicnoIme = Id.LicnoIme;
        Prezime = Id.Prezime;
    }
    #endregion
}
public class ImeVlasnikaBasic
{
    public ImeVlasnikaIdBasic Id { get; set; }

    #region Constructors
    public ImeVlasnikaBasic() { }
    public ImeVlasnikaBasic(ImeVlasnikaIdBasic id)
    {
        Id = id;
    }
    #endregion
}

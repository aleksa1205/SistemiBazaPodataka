namespace FashionWeek.DTO;

public class CasopisPregled
{
    public CasopisId Id { get; set; }

    #region Constructors
    public CasopisPregled() { }
    public CasopisPregled(CasopisId id)
    {
        Id = id;
    }
    #endregion
}

public class CasopisIdBasic
{
    public ManekenBasic Maneken { get; set; }
    public string NazivCasopisa { get; set; }

    #region Constructors
    public CasopisIdBasic() { }
    public CasopisIdBasic(CasopisId Id)
    {
        Maneken = new ManekenBasic(Id.Maneken);
        NazivCasopisa = Id.NazivCasopisa;
    }
    #endregion
}

public class CasopisBasic
{
    public CasopisIdBasic Id { get; set; }

    #region Constructors
    public CasopisBasic() { }
    public CasopisBasic(CasopisIdBasic id)
    {
        Id = id;
    }
    #endregion
}
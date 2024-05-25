namespace FashionWeek.DTO;

public class NazivZemljePregled
{
    public NazivZemljeId Id { get; set; }

    #region Constructors
    public NazivZemljePregled() { }
    public NazivZemljePregled(NazivZemljeId id)
    {
        Id = id;
    }
    #endregion
}

public class NazivZemljeIdBasic
{
    public InostranaAgencijaBasic InostranaAgencija { get; set; }
    public string NazivZemlje { get; set; }

    #region Constructors
    public NazivZemljeIdBasic() { }
    public NazivZemljeIdBasic(NazivZemljeId Id)
    {
        InostranaAgencija = new(Id.InostranaAgencija!);
        NazivZemlje = Id.NazivZemlje!;
    }
    #endregion
}

public class NazivZemljeBasic
{
    public NazivZemljeIdBasic Id { get; set; }

    #region Constructors
    public NazivZemljeBasic() { }
    public NazivZemljeBasic(NazivZemljeIdBasic id)
    {
        Id = id;
    }
    #endregion
}
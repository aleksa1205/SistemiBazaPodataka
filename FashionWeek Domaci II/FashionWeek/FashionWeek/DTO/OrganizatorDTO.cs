namespace FashionWeek.DTO;
public class OrganizatorPregled
{
    public int Id { get; set; }
    public char PrvaRevija { get; set; }
    public string InformacijeOKolekciji { get; set; }

    #region Constructors
    public OrganizatorPregled(int id, char prvaRevija, string infoOKolekciji)
    {
        Id = id;
        PrvaRevija = prvaRevija;
        InformacijeOKolekciji = infoOKolekciji;
    }
    #endregion
}

public class OrganizatorBasic
{
    public int Id { get; set; }
    public char PrvaRevija { get; set; }
    public string? InformacijeOKolekciji { get; set; }
    public IList<ModniKreatorBasic> Kreatori { get; set; } = [];
    public IList<ModnaKucaBasic> ModneKuce { get; set; } = [];
    public IList<ModnaRevijaBasic> ModneRevije { get; set; } = [];
    public IList<SpecijalanGostBasic> SpecijalniGosti { get; set; } = [];

    #region Constructors
    public OrganizatorBasic() { }
    public OrganizatorBasic(int id, char prvaRevija, string infoOKolekciji)
    {
        Id = id;
        PrvaRevija = prvaRevija;
        InformacijeOKolekciji = infoOKolekciji;
    }
    #endregion
}

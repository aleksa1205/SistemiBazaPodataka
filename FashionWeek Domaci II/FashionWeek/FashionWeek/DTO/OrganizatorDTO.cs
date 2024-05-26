namespace FashionWeek.DTO;
public class OrganizatorPregled
{
    public int Id { get; set; }
    public char PrvaRevija { get; set; }
    public string? InformacijeOKolekciji { get; set; }

    #region Constructors
    public OrganizatorPregled(int id, char prvaRevija, string infoOKolekciji)
    {
        Id = id;
        PrvaRevija = prvaRevija;
        InformacijeOKolekciji = infoOKolekciji;
    }
    public OrganizatorPregled(Organizator organizator)
    {
        Id = organizator.Id;
        PrvaRevija = organizator.PrvaRevija;
        InformacijeOKolekciji = organizator.InformacijeOKolekciji;
    }
    #endregion
}

public class OrganizatorBasic
{
    public int Id { get; set; }
    public char PrvaRevija { get; set; }
    public string? InformacijeOKolekciji { get; set; }
    public List<ModniKreatorBasic> Kreatori { get; set; } = [];
    public List<ModnaKucaBasic> ModneKuce { get; set; } = [];
    public List<ModnaRevijaBasic> ModneRevije { get; set; } = [];
    public List<SpecijalanGostBasic> SpecijalniGosti { get; set; } = [];

    #region Constructors
    public OrganizatorBasic() { }
    public OrganizatorBasic(int id, char prvaRevija, string infoOKolekciji)
    {
        Id = id;
        PrvaRevija = prvaRevija;
        InformacijeOKolekciji = infoOKolekciji;
    }
    public OrganizatorBasic(Organizator organizator) 
    {
        Id = organizator.Id;
        PrvaRevija = organizator.PrvaRevija;
        InformacijeOKolekciji = organizator.InformacijeOKolekciji;
    }
    #endregion
}

namespace FashionWeek_Library.DTO;

public class OrganizatorView
{
    public int Id { get; set; }
    public char PrvaRevija { get; set; }
    public string? InformacijeOKolekciji { get; set; }
    public virtual IList<ModniKreatorView> Kreatori { get; set; } = [];
    public virtual IList<ModnaKucaView> ModneKuce { get; set; } = [];
    public virtual IList<ModnaRevijaView> ModneRevije {  get; set; } = [];
    public virtual IList<SpecijalanGostView> SpecijalniGosti { get; set; } = [];

    public OrganizatorView() { }
    internal OrganizatorView(Organizator organizator)
    {
        Id = organizator.Id;
        PrvaRevija = organizator.PrvaRevija;
        InformacijeOKolekciji = organizator.InformacijeOKolekciji;
    }
}

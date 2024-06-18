namespace FashionWeek_Library.DTO;

public class SpecijalanGostIdView
{
    public ModniKreatorView ModniKreator { get; set; }
    public ModnaRevijaView ModnaRevija { get; set; }
    public OrganizatorView Organizator { get; set; }

    public SpecijalanGostIdView() { }

    internal SpecijalanGostIdView(SpecijalanGostId Id)
    {
        ModniKreator = new(Id.ModniKreator);
        ModnaRevija = new(Id.ModnaRevija);
        Organizator = new(Id.Organizator);
    }
}

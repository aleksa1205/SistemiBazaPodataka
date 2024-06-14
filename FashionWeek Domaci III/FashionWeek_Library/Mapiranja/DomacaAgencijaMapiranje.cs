namespace FashionWeek_Library.Mapiranja;

internal class DomacaAgencijaMapiranje : SubclassMap<DomacaAgencija>
{
    public DomacaAgencijaMapiranje()
    {
        DiscriminatorValue("N");
    }
}

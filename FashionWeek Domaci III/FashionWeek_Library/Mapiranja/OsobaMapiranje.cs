namespace FashionWeek_Library.Mapiranja;

internal class OsobaMapiranje : ClassMap<Osoba>
{
    public OsobaMapiranje()
    {
        UseUnionSubclassForInheritanceMapping();
        Id(x => x.MBR).GeneratedBy.Assigned().Column("MBR");

        Component(x => x.Ime);
        Map(x => x.DatumRodjenja).Column("DATUM_RODJENJA");
        Map(x => x.Pol).Column("POL");
    }
}

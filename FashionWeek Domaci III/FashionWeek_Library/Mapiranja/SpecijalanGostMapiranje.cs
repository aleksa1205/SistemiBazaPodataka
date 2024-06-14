namespace FashionWeek_Library.Mapiranja;

internal class SpecijalanGostMapiranje : ClassMap<SpecijalanGost>
{
    public SpecijalanGostMapiranje()
    {
        Table("SPECIJALNI_GOSTI");
        CompositeId(x => x.Id)
            .KeyReference(x => x.ModnaRevija, "RBR_REVIJE")
            .KeyReference(x => x.ModniKreator, "MBR_KREATORA")
            .KeyReference(x => x.Organizator, "ORGANIZATOR_ID");
    }
}

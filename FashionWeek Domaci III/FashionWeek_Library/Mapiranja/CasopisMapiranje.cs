namespace FashionWeek_Library.Mapiranja;

internal class CasopisMapiranje : ClassMap<Casopis>
{
    public CasopisMapiranje()
    {
        Table("NAZIVI_CASOPISA");
        CompositeId(x => x.Id)
            .KeyReference(x => x.Maneken, "MBR_MANEKENA")
            .KeyProperty(x => x.NazivCasopisa, "NAZIV_CASOPISA");
    }

}

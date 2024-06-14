namespace FashionWeek_Library.Mapiranja;

internal class NazivZemljeMapiranje : ClassMap<NazivZemlje>
{
    public NazivZemljeMapiranje()
    {
        Table("NAZIVI_ZEMALJA");
        CompositeId(x => x.Id)
            .KeyReference(x => x.InostranaAgencija, "PIB_INOSTRANE")
            .KeyProperty(x => x.NazivZemlje, "NAZIV_ZEMLJE");
    }
}

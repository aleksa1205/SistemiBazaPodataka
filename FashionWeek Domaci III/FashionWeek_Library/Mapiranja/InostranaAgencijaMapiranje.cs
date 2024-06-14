namespace FashionWeek_Library.Mapiranja;

internal class InostranaAgencijaMapiranje : SubclassMap<InostranaAgencija>
{
    public InostranaAgencijaMapiranje()
    {
        DiscriminatorValue("Y");

        HasMany(x => x.Zemlje).KeyColumn("NAZIV_ZEMLJE").Cascade.All();
    }
}

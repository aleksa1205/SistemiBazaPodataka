namespace FashionWeek_Library.Mapiranja;

internal class ModnaKucaMapiranje : ClassMap<ModnaKuca>
{
    public ModnaKucaMapiranje()
    {
        Table("MODNA_KUCA");
        Id(x => x.Naziv).GeneratedBy.Assigned().Column("NAZIV");

        Component(x => x.Osnivac).ColumnPrefix("OSNIVAC_");
        Component(x => x.Sediste);

        HasMany(x => x.Kreatori).KeyColumn("NAZIV_KUCE");
        References(x => x.Organizator).Column("ORGANIZATOR_ID");
        HasMany(x => x.Vlasnici).KeyColumn("NAZIV_KUCE").Cascade.All().Inverse();
    }
}

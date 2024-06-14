namespace FashionWeek_Library.Mapiranja;

internal class ModnaAgencijaMapiranje : ClassMap<ModnaAgencija>
{
    public ModnaAgencijaMapiranje()
    {
        Table("MODNA_AGENCIJA");
        DiscriminateSubClassesOnColumn("INOSTRANA");
        Id(x => x.PIB).GeneratedBy.Assigned().Column("PIB");

        Map(x => x.Naziv).Column("NAZIV");
        //Map(x => x.Inostrana).Column("INOSTRANA");
        Component(x => x.Sediste);
        Map(x => x.DatumOsnivanja).Column("DATUM_OSNIVANJA");

        HasMany(x => x.Manekeni).KeyColumn("PIB_AGENCIJE").Cascade.All().Inverse();
    }
}

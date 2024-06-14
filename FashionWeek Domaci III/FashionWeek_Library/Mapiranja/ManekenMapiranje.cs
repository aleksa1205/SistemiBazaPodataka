namespace FashionWeek_Library.Mapiranja;

internal class ManekenMapiranje : SubclassMap<Maneken>
{
    public ManekenMapiranje()
    {
        Table("MANEKEN");
        Abstract();

        Map(x => x.Visina).Column("VISINA");
        Map(x => x.Tezina).Column("TEZINA");
        Map(x => x.BojaOciju).Column("BOJA_OCIJU");
        Map(x => x.BojaKose).Column("BOJA_KOSE");
        Map(x => x.KonfekcijskiBroj).Column("KONFEKCIJSKI_BROJ");
        Map(x => x.Zanimanje).Column("ZANIMANJE");

        References(x => x.RadiUAgenciji).Column("PIB_AGENCIJE");
        HasManyToMany(x => x.Revije)
            .Table("NASTUPA_U")
            .ParentKeyColumn("MBR_MANEKENA")
            .ChildKeyColumn("RBR_REVIJE")
            .Cascade.All();
        HasMany(x => x.Casopisi).KeyColumn("MBR_MANEKENA").Cascade.All().Inverse();
    }
}

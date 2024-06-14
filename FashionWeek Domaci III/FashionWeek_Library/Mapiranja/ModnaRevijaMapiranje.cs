namespace FashionWeek_Library.Mapiranja;

internal class ModnaRevijaMapiranje : ClassMap<ModnaRevija>
{
    public ModnaRevijaMapiranje()
    {
        Table("MODNA_REVIJA");
        Id(x => x.RBR).GeneratedBy.TriggerIdentity().Column("RBR_REVIJE");

        Map(x => x.Naziv).Column("NAZIV");
        Component(x => x.Mesto);
        Map(x => x.Termin).Column("TERMIN_ODRZAVANJA");

        HasManyToMany(x => x.Manekeni)
            .Table("NASTUPA_U")
            .ParentKeyColumn("RBR_REVIJE")
            .ChildKeyColumn("MBR_MANEKENA")
            .Cascade.All().Inverse();
        HasManyToMany(x => x.Kreatori)
            .Table("PREDSTAVLJA")
            .ParentKeyColumn("RBR_REVIJE")
            .ChildKeyColumn("MBR_KREATORA")
            .Cascade.All();
        References(x => x.Organizator).Column("ORGANIZATOR_ID");
        HasMany(x => x.SpecijalniGosti).KeyColumn("RBR_REVIJE").Cascade.AllDeleteOrphan();
    }
}

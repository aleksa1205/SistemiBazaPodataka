namespace FashionWeek_Library.Mapiranja;

internal class OrganizatorMapiranje : ClassMap<Organizator>
{
    public OrganizatorMapiranje() 
    {
        Table("ORGANIZATOR");
        //menjace se
        Id(x => x.Id).GeneratedBy.TriggerIdentity().Column("ID");

        //bool -> char
        Map(x => x.PrvaRevija).Column("PRVA_REVIJA");
        Map(x => x.InformacijeOKolekciji).Column("INFORMACIJE_O_KOLEKCIJI");

        HasMany(x => x.Kreatori).KeyColumn("ORGANIZATOR_ID");
        HasMany(x => x.ModneKuce).KeyColumn("ORGANIZATOR_ID");
        HasMany(x => x.ModneRevije).KeyColumn("ORGANIZATOR_ID");
        HasMany(x => x.SpecijalniGosti).KeyColumn("ORGANIZATOR_ID").Cascade.AllDeleteOrphan();
    }
}

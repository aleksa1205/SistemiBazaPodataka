namespace FashionWeek.Mapiranja;

public class ModniKreatorMapiranje : SubclassMap<ModniKreator>
{
    ModniKreatorMapiranje()
    {
        Table("MODNI_KREATOR");
        Abstract();

        Map(x => x.ZemljaPorekla).Column("ZEMLJA_POREKLA");

        References(x => x.RadiU).Column("NAZIV_KUCE");
        HasManyToMany(x => x.Revije)
            .Table("PREDSTAVLJA")
            .ParentKeyColumn("MBR_KREATORA")
            .ChildKeyColumn("RBR_REVIJE")
            .Cascade.All().Inverse();
        References(x => x.Organizator).Column("ORGANIZATOR_ID");
        HasMany(x => x.SpecijalniGosti).KeyColumn("MBR_KREATORA").Cascade.AllDeleteOrphan();
    }
}

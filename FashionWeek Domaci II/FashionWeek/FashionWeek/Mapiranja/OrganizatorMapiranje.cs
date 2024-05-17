using FashionWeek.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionWeek.Mapiranja;

public class OrganizatorMapiranje : ClassMap<Organizator>
{
    public OrganizatorMapiranje() 
    {
        Table("ORGANIZATOR");
        //menjace se
        Id(x => x.Id).GeneratedBy.TriggerIdentity();

        //bool -> char
        Map(x => x.PrvaRevija).Column("PRVA_REVIJA");
        Map(x => x.InformacijeOKolekciji).Column("INFORMACIJE_O_KOLEKCIJI");

        HasMany(x => x.Kreatori).KeyColumn("ORGANIZATOR_ID");
        HasMany(x => x.ModneKuce).KeyColumn("ORGANIZATOR_ID");
        HasMany(x => x.ModneRevije).KeyColumn("ORGANIZATOR_ID");
    }
}

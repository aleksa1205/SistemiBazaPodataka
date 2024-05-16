using FashionWeek.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionWeek.Mapiranja;

public class OsobaMapiranje : ClassMap<Osoba>
{
    OsobaMapiranje()
    {
        UseUnionSubclassForInheritanceMapping();
        Id(x => x.MBR).GeneratedBy.Assigned().Column("MBR");

        Component(x => x.Ime);
        Map(x => x.DatumRodjenja).Column("DATUM_RODJENJA");
        Map(x => x.Pol).Column("POL");
    }
}

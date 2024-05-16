using FashionWeek.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionWeek.Mapiranja;

public class ManekenMapiranje : SubclassMap<Maneken>
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
    }
}

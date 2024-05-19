using FashionWeek.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionWeek.Mapiranja;

public class CasopisMapiranje : ClassMap<Casopis>
{
    public CasopisMapiranje()
    {
        Table("NAZIVI_CASOPISA");
        CompositeId(x => x.Id)
            .KeyReference(x => x.Maneken, "MBR_MANEKENA")
            .KeyProperty(x => x.NazivCasopisa, "NAZIV_CASOPISA");
    }

}

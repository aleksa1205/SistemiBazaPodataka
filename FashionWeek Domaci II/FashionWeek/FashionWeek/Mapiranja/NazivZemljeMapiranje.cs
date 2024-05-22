using FashionWeek.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionWeek.Mapiranja;

public class NazivZemljeMapiranje : ClassMap<NazivZemlje>
{
    public NazivZemljeMapiranje()
    {
        Table("NAZIVI_ZEMALJA");
        CompositeId(x => x.Id)
            .KeyReference(x => x.InostranaAgencija, "PIB_INOSTRANE")
            .KeyProperty(x => x.NazivZemlje, "NAZIV_ZEMLJE");
    }
}

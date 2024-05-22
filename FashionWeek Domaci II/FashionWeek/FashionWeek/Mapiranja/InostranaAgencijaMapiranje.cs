using FashionWeek.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionWeek.Mapiranja;

public class InostranaAgencijaMapiranje : SubclassMap<InostranaAgencija>
{
    public InostranaAgencijaMapiranje()
    {
        DiscriminatorValue("Y");

        HasMany(x => x.Zemlje).KeyColumn("NAZIV_ZEMLJE").Cascade.All();
    }
}

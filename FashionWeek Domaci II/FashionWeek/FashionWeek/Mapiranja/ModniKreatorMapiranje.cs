using FashionWeek.Entiteti;
using FluentNHibernate.Mapping;
using NHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionWeek.Mapiranja
{
    public class ModniKreatorMapiranje : SubclassMap<ModniKreator>
    {
        ModniKreatorMapiranje()
        {
            Table("MODNI_KREATOR");
            Abstract();

            Map(x => x.ZemljaPorekla).Column("ZEMLJA_POREKLA");
        }
    }
}

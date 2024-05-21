using FashionWeek.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionWeek.Mapiranja
{
    public class DomacaAgencijaMapiranje : SubclassMap<DomacaAgencija>
    {
        public DomacaAgencijaMapiranje()
        {
            DiscriminatorValue("N");
        }
    }
}

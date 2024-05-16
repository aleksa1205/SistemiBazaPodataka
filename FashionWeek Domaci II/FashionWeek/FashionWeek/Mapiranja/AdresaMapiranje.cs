using FashionWeek.Entiteti.Helper;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionWeek.Mapiranja;

public class AdresaMapiranje : ComponentMap<Adresa>
{
    AdresaMapiranje()
    {
        Map(x => x.Drzava).Column("DRZAVA");
        Map(x => x.Grad).Column("GRAD");
        Map(x => x.Ulica).Column("ULICA");
    }
}

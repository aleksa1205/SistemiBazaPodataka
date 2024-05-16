using FashionWeek.Entiteti.Helper;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionWeek.Mapiranja;

public class ImeMapiranje : ComponentMap<Ime>
{
    public ImeMapiranje()
    {
        Map(x => x.LicnoIme).Column("LICNO_IME");
        Map(x => x.Prezime).Column("PREZIME");
    }
}

using FashionWeek.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionWeek.Mapiranja;

public class ImeVlasnikaMapiranje : ClassMap<ImeVlasnika>
{
    public ImeVlasnikaMapiranje()
    {
        Table("IMENA_VLASNIKA");
        CompositeId(x => x.Id)
            .KeyReference(x => x.ModnaKuca, "NAZIV_KUCE")
            .KeyProperty(x => x.LicnoIme, "LICNO_IME")
            .KeyProperty(x => x.Prezime, "PREZIME");
    }
}

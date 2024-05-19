using FashionWeek.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionWeek.Mapiranja;

public class SpecijalanGostMapiranje : ClassMap<SpecijalanGost>
{
    public SpecijalanGostMapiranje()
    {
        Table("SPECIJALNI_GOSTI");
        CompositeId(x => x.Id)
            .KeyReference(x => x.ModnaRevija, "RBR_REVIJE")
            .KeyReference(x => x.ModniKreator, "MBR_KREATORA")
            .KeyReference(x => x.Organizator, "ORGANIZATOR_ID");
    }
}

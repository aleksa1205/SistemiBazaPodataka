﻿using FashionWeek.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionWeek.Mapiranja;

public class ModnaKucaMapiranje : ClassMap<ModnaKuca>
{
    public ModnaKucaMapiranje()
    {
        Table("MODNA_KUCA");
        Id(x => x.Naziv).GeneratedBy.Assigned().Column("NAZIV");

        Component(x => x.Osnivac).ColumnPrefix("OSNIVAC_");
        Component(x => x.Sediste);

        //1:N
        HasMany(x => x.Kreatori).KeyColumn("NAZIV_KUCE");
    }
}

using FashionWeek.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionWeek.Mapiranja
{
    public class ModnaAgencijaMapiranje : ClassMap<ModnaAgencija>
    {
        public ModnaAgencijaMapiranje()
        {
            Table("MODNA_AGENCIJA");
            Id(x => x.PIB).GeneratedBy.Assigned().Column("PIB");

            Map(x => x.Naziv).Column("NAZIV");
            Map(x => x.Inostrana).Column("INOSTRANA");
            Component(x => x.Sediste);
            Map(x => x.DatumOsnivanja).Column("DATUM_OSNIVANJA");

            //1:N 
            HasMany(x => x.Manekeni).KeyColumn("PIB_AGENCIJE");
        }
    }
}

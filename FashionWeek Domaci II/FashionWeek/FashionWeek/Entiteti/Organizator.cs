using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionWeek.Entiteti;

public class Organizator
{
    public virtual int Id { get; set; }
    public virtual char PrvaRevija { get; set; }
    public virtual string? InformacijeOKolekciji { get; set; }

    public virtual IList<ModniKreator> Kreatori { get; set; } = [];
    public virtual IList<ModnaKuca> ModneKuce { get; set; } = [];
    public virtual IList<ModnaRevija> ModneRevije { get; set; } = [];
    public virtual IList<SpecijalanGost> SpecijalniGosti { get; set; } = [];
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionWeek.Entiteti;

public class ModniKreator : Osoba
{
    public virtual string? ZemljaPorekla { get; set; }

    public virtual ModnaKuca? RadiU { get; set; } 
    public virtual IList<ModnaRevija> Revije { get; set; }
    public virtual Organizator? Organizator { get; set; }

    public ModniKreator()
    {
        Revije = new List<ModnaRevija>();
    }
}

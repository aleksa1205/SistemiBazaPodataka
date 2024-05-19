using FashionWeek.Entiteti.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionWeek.Entiteti;

public class ModnaRevija
{
    public virtual int RBR { get; set; }
    public virtual required string Naziv { get; set; }
    public virtual Adresa? Mesto { get; set; }
    public virtual DateTime Termin { get; set; }
    public virtual IList<Maneken> Manekeni { get; set; } = [];
    public virtual IList<ModniKreator> Kreatori { get; set; } = [];
    public virtual Organizator? Organizator { get; set; }
    public virtual IList<SpecijalanGost> SpecijalniGosti { get; set; } = [];

}

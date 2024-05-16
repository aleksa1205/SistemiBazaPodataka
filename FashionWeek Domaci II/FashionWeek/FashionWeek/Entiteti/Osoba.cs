using FashionWeek.Entiteti.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionWeek.Entiteti;

public abstract class Osoba
{
    public virtual required string MBR { get; set; }
    public virtual required Ime Ime { get; set; }
    public virtual DateTime DatumRodjenja { get; set; }
    public virtual char Pol { get; set; }
}

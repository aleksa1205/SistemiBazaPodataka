using FashionWeek.Entiteti.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionWeek.Entiteti;

public class Maneken : Osoba
{
    public virtual int Visina { get; set; }
    public virtual double Tezina { get; set; }
    public virtual string? BojaOciju { get; set; }
    public virtual string? BojaKose { get; set; }
    public virtual string? KonfekcijskiBroj { get; set; }
    public virtual string? Zanimanje { get; set; }

    public virtual ModnaAgencija? RadiUAgenciji { get; set; }
    public virtual IList<ModnaRevija> Revije { get; set; } = [];
    public virtual IList<Casopis> Casopisi { get; set; } = [];
}

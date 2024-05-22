using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionWeek.Entiteti.Helper;

public class Ime
{
    public string? LicnoIme { get; set; }
    public string? Prezime { get; set; }

    public override string ToString()
    {
        return LicnoIme + ' ' + Prezime;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionWeek.Entiteti.Helper;

public class Adresa
{
    public string? Drzava { get; set; }
    public string? Grad { get; set; }
    public string? Ulica { get; set; }

    public override string ToString()
    {
        string res = "";
        if (Drzava != null)
        {
            res += Drzava + ", ";
        }
        if (Grad != null)
        {
            res += Grad + ", ";
        }
        if (Ulica != null)
        {
            res += Ulica;
        }
        return res;
    }
}

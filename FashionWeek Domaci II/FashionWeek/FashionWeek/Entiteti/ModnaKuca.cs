using FashionWeek.Entiteti.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionWeek.Entiteti;

public class ModnaKuca
{
    public virtual required string Naziv { get; set; }
    public virtual Ime? Osnivac { get; set; }
    public virtual Adresa? Sediste { get; set; }

    public virtual IList<ModniKreator> Kreatori { get; set; }
    public virtual Organizator Organizator { get; set; }
    public virtual IList<ImeVlasnika> Vlasnici { get; set; }

    public ModnaKuca()
    {
        Kreatori = new List<ModniKreator>();
        Vlasnici = new List<ImeVlasnika>();
    }
}

using FashionWeek.Entiteti.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionWeek.Entiteti;

public class ImeVlasnikaId
{
    public virtual ModnaKuca? ModnaKuca { get; set; }
    public virtual Ime? Ime { get; set; }

    public override bool Equals(object? obj)
    {
        if (obj == null)
        {
            return false;
        }
        if (ReferenceEquals(this, obj))
        {
            return true;
        }

        ImeVlasnikaId compare = (obj as ImeVlasnikaId)!;
        return ModnaKuca!.Naziv == compare!.ModnaKuca!.Naziv && Ime == compare!.Ime;
    }

    public override int GetHashCode()
    {
        return ModnaKuca!.Naziv.GetHashCode();
    }
}

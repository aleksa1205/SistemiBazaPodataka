using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionWeek.Entiteti;

public class NazivZemljeId
{
    public virtual ModnaAgencija? ModnaAgencija { get; set; }
    public virtual string? NazivZemlje { get; set; }

    public override bool Equals(object? obj)
    {
        if (obj == null)
        {
            return false;
        }
        if(ReferenceEquals(this, obj))
        {
            return true;
        }

        NazivZemljeId compare = (obj as NazivZemljeId)!;
        return ModnaAgencija!.PIB == compare!.ModnaAgencija!.PIB && NazivZemlje == compare.NazivZemlje;

    }
    public override int GetHashCode()
    {
        return ModnaAgencija!.PIB.GetHashCode();
    }
}

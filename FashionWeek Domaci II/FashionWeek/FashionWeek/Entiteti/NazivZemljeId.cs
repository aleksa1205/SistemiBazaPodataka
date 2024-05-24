namespace FashionWeek.Entiteti;

public class NazivZemljeId
{
    public virtual InostranaAgencija? InostranaAgencija { get; set; }
    public virtual string? NazivZemlje { get; set; }

    #region Overrides
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
        return InostranaAgencija!.PIB == compare!.InostranaAgencija!.PIB && NazivZemlje == compare.NazivZemlje;

    }
    public override int GetHashCode()
    {
        return InostranaAgencija!.PIB.GetHashCode();
    }
    #endregion
}

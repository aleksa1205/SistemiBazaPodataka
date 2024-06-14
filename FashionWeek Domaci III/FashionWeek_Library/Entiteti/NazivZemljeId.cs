namespace FashionWeek_Library.Entiteti;

internal class NazivZemljeId
{
    internal protected virtual InostranaAgencija? InostranaAgencija { get; set; }
    internal protected virtual string? NazivZemlje { get; set; }

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

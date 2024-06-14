namespace FashionWeek_Library.Entiteti;

internal class CasopisId
{
    internal protected virtual Maneken? Maneken { get; set; }
    internal protected virtual string? NazivCasopisa { get; set; }

    #region Overrides
    public override bool Equals(object? obj)
    {
        if(obj == null)
        {
            return false;
        }
        if(ReferenceEquals(this, obj))
        {
            return true;
        }

        CasopisId compare = (obj as CasopisId)!;
        return Maneken!.MBR == compare!.Maneken!.MBR && NazivCasopisa == compare.NazivCasopisa;
    }
    public override int GetHashCode()
    {
        return Maneken!.MBR.GetHashCode();
    }
    #endregion
}

namespace FashionWeek.Entiteti;

public class SpecijalanGostId
{
    public virtual required ModniKreator ModniKreator { get; set; }
    public virtual required ModnaRevija ModnaRevija { get; set; }
    public virtual required Organizator Organizator { get; set; }

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

        SpecijalanGostId compare = (obj as SpecijalanGostId)!;
        return ModnaRevija == compare.ModnaRevija && ModniKreator == compare.ModniKreator && Organizator == compare.Organizator;
    }

    public override int GetHashCode()
    {
        return ModnaRevija.RBR.GetHashCode() + ModniKreator.MBR.GetHashCode() + Organizator.Id.GetHashCode();
    }
    #endregion
}

namespace FashionWeek.Entiteti;

public class ImeVlasnikaId
{
    public virtual required ModnaKuca ModnaKuca { get; set; }
    //public virtual required Ime Ime { get; set; }
    public virtual required string LicnoIme { get; set; }
    public virtual required string Prezime { get; set; }

    #region Overrides
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
        return ModnaKuca!.Naziv == compare!.ModnaKuca!.Naziv && LicnoIme == compare!.LicnoIme && Prezime == compare!.Prezime;
    }

    public override int GetHashCode()
    {
        return ModnaKuca!.Naziv.GetHashCode();
    }
    #endregion
}

namespace FashionWeek_Library.DTO;

public class ModniKreatorView : OsobaView
{
    public string? ZemljaPorekla { get; set; }
    public ModnaKucaView? RadiU { get; set; } = null;
    public virtual IList<ModnaRevijaView> Revije { get; set; } = [];
    public virtual OrganizatorView? Organizator { get; set; } = null;
    public virtual IList<SpecijalanGostView> SpecijalniGosti { get; set; } = [];

    #region Constructors
    public ModniKreatorView() { }
    internal ModniKreatorView(ModniKreator kreator)
    {
        MBR = kreator.MBR;
        Ime = kreator.Ime;
        DatumRodjenja = kreator.DatumRodjenja;
        Pol = kreator.Pol;
        ZemljaPorekla = kreator.ZemljaPorekla;
        RadiU = kreator.RadiU != null ? new ModnaKucaView(kreator.RadiU) : null;
    }
    #endregion

    #region Overrides
    public override string ToString()
    {
        return MBR + ": " + Ime.ToString();
    }
    #endregion
}

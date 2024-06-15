namespace FashionWeek_Library.DTO;

public class ModniKreatorView : OsobaView
{
    public string? ZemljaPorekla { get; set; }
    //radiu
    //organizator

    #region Constructors
    public ModniKreatorView() { }
    internal ModniKreatorView(ModniKreator kreator)
    {
        MBR = kreator.MBR;
        Ime = kreator.Ime;
        DatumRodjenja = kreator.DatumRodjenja;
        Pol = kreator.Pol;
        ZemljaPorekla = kreator.ZemljaPorekla;
    }
    #endregion

    #region Overrides
    public override string ToString()
    {
        return MBR + ": " + Ime.ToString();
    }
    #endregion
}

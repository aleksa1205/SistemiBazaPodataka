namespace FashionWeek.Entiteti
{
    public abstract class ModnaAgencija
    {
        public virtual required string PIB { get; set; }
        public virtual required string Naziv { get; set; }
        public virtual char Inostrana { get; set; }
        public virtual Adresa? Sediste { get; set; }
        public virtual DateTime DatumOsnivanja { get; set; }

        public virtual IList<Maneken> Manekeni { get; set; } = [];

    }
}

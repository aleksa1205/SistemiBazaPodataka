namespace FashionWeek_Library.DTO
{
    public class SpecijalanGostView
    {
        public SpecijalanGostIdView Id { get; set; }
        
        public SpecijalanGostView() { }
        internal SpecijalanGostView(SpecijalanGost gost)
        {
            Id = new SpecijalanGostIdView(gost.Id);
        }
    }
}

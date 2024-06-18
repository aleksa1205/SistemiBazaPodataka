using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionWeek_Library.DTO.Basic
{
    public class ManekenBasic
    {
        public string MBR { get; set; }
        public Ime Ime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public char Pol { get; set; }
        public int Visina { get; set; }
        public double Tezina { get; set; }
        public string? BojaOciju { get; set; }
        public string? BojaKose { get; set; }
        public string? Zanimanje { get; set; }
        public string? KonfekcijskiBroj { get; set; }
    }
}

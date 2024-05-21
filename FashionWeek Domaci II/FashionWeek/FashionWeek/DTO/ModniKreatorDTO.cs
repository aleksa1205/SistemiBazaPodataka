using FashionWeek.Entiteti;
using FashionWeek.Entiteti.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionWeek.DTO;

public class ModniKreatorDTO
{
    public required string MBR { get; set; }
    public required Ime Ime { get; set; }
    public DateTime DatumRodjenja { get; set; }
    public char Pol { get; set; }
    public string? ZemljaPorekla { get; set; }
    public ModnaKuca? RadiU { get; set; }
}

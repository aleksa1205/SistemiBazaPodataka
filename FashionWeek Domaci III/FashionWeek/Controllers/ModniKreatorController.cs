using FashionWeek_Library.DTO.Basic;

namespace FashionWeek.Controllers;

[ApiController]
[Route("[controller]")]
public class ModniKreatorController : ControllerBase
{
    [HttpGet("VratiSveModneKreatore")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> GetAll()
    {
        var kreatori = await DataProvider.VratiSveModneKreatore();
        if (kreatori.IsError)
        {
            return StatusCode(kreatori.Error.StatusCode, kreatori.Error.Message);
        }
        return Ok(kreatori.Data);
    }

    [HttpGet("VratiModnogKreatora/{mbr}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetByMBR(string mbr)
    {
        var kreator = await DataProvider.VratiModnogKreatora(mbr);
        if (kreator.IsError)
        {
            return StatusCode(kreator.Error.StatusCode, kreator.Error.Message);
        }
        return Ok(kreator.Data);
    }

    [HttpGet("VratiModneKreatoreModneKuce/{naziv}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> GetByModnaKuca(string naziv)
    {
        var kreatori = await DataProvider.VratiModneKreatoreModneKuce(naziv);
        if (kreatori.IsError)
        {
            return StatusCode(kreatori.Error.StatusCode, kreatori.Error.Message);
        }
        return Ok(kreatori.Data);
    }

    [HttpGet("VratiModneKreatoreBezModneKuce")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> GetByWithouthModnaKuca()
    {
        var kreatori = await DataProvider.VratiModneKreatoreModneKuce(null);
        if (kreatori.IsError)
        {
            return StatusCode(kreatori.Error.StatusCode, kreatori.Error.Message);
        }
        return Ok(kreatori.Data);
    }

    [HttpGet("VratiModneKreatoreModneRevije/{rbr}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> GetByModnaRevija(int rbr)
    {
        var kreatori = await DataProvider.VratiModneKreatoreModneRevije(rbr);
        if (kreatori.IsError)
        {
            return StatusCode(kreatori.Error.StatusCode, kreatori.Error.Message);
        }
        return Ok(kreatori.Data);
    }

    [HttpPost("DodajModnogKreatora")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
    public async Task<IActionResult> AddModniKreator([FromBody] ModniKreatorBasic kreator)
    {
        var check = await DataProvider.DodajModnogKreatora(kreator);
        if (check.IsError)
        {
            return StatusCode(check.Error.StatusCode, check.Error.Message);
        }
        return Ok($"Uspešno dodat maneken {kreator.MBR}: {kreator.Ime.ToString()}!");
    }

    [HttpPut("AzurirajModnogKreatora")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
    public async Task<IActionResult> UpdateModniKreator([FromBody] ModniKreatorBasic kreator)
    {
        var check = await DataProvider.AzurirajModnogKreatora(kreator);
        if (check.IsError)
        {
            return StatusCode(check.Error.StatusCode, check.Error.Message);
        }
        return Ok($"Uspešno ažuriran modni kreator {kreator.MBR}!");
    }

    [HttpPatch("DodajModnuKucuModnomKreatoru/{mbr}/{naziv}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> AddModnaKucaToModniKreator(string mbr, string naziv)
    {
        var check = await DataProvider.DodajModnuKucuModnomKreatoru(mbr, naziv);
        if (check.IsError)
        {
            return StatusCode(check.Error.StatusCode, check.Error.Message);
        }
        return Ok($"Uspešno dodata modna kuća sa nazivom {naziv} modnom kreatoru sa MBR-om {mbr}!");
    }

    [HttpPatch("ObrisiModnuKucuModnomKreatoru/{mbr}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> RemoveModnaKucaFromModniKreator(string mbr)
    {
        var check = await DataProvider.ObrisiModnuKucuModnomKreatoru(mbr);
        if (check.IsError)
        {
            return StatusCode(check.Error.StatusCode, check.Error.Message);
        }
        return Ok($"Uspešno obrisana modna kuća modnom kreatoru sa MBR-om {mbr}!");
    }

    [HttpPatch("DodajModnuRevijuModnomKreatoru/{mbr}/{rbr}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> AddModnaRevijaToModniKreator(string mbr, int rbr)
    {
        var check = await DataProvider.DodajModnuRevijuModnomKreatoru(mbr, rbr);
        if (check.IsError)
        {
            return StatusCode(check.Error.StatusCode, check.Error.Message);
        }
        return Ok($"Uspešno dodata modna revija sa rednim brojem {rbr} modnom kreatoru sa MBR-om {mbr}!");
    }

    [HttpPatch("ObrisiModnuRevijuModnomKreatoru/{mbr}/{rbr}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> RemoveModnaRevijaFromModniKreator(string mbr, int rbr)
    {
        var check = await DataProvider.ObrisiModnuRevijuModnomKreatoru(mbr, rbr);
        if (check.IsError)
        {
            return StatusCode(check.Error.StatusCode, check.Error.Message);
        }
        return Ok($"Uspešno obrisana modna revija sa rednim brojem {rbr} modnom kreatoru sa MBR-om {mbr}!");
    }

    [HttpDelete("ObrisiModnogKreatora/{mbr}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> RemoveModniKreator(string mbr)
    {
        var check = await DataProvider.ObrisiModnogKreatora(mbr);
        if (check.IsError)
        {
            return StatusCode(check.Error.StatusCode, check.Error.Message);
        }
        return Ok($"Uspešno obrisan maneken sa MBR-om {mbr}!");
    }
}

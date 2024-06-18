using FashionWeek_Library.DTO.Basic;

namespace FashionWeek.Controllers;

[ApiController]
[Route("[controller]")]
public class ManekenController : ControllerBase
{
    [HttpGet("VratiSveManekene")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> GetAll()
    {
        var manekeni = await DataProvider.VratiSveManekene();
        if (manekeni.IsError)
        {
            return StatusCode(manekeni.Error.StatusCode, manekeni.Error.Message);
        }
        return Ok(manekeni.Data);
    }

    [HttpGet("VratiManekena/{mbr}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetByMBR(string mbr)
    {
        var maneken = await DataProvider.VratiManekena(mbr);
        if (maneken.IsError)
        {
            return StatusCode(maneken.Error.StatusCode, maneken.Error.Message);
        }
        return Ok(maneken.Data);
    }

    [HttpGet("VratiManekeneModneAgencije/{pib}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> GetByAgencija(string pib)
    {
        var manekeni = await DataProvider.VratiManekeneModneAgencije(pib);
        if (manekeni.IsError)
        {
            return StatusCode(manekeni.Error.StatusCode, manekeni.Error.Message);
        }
        return Ok(manekeni.Data);
    }

    [HttpGet("VratiManekeneBezModneAgencije")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> GetByWithouthAgencija()
    {
        var manekeni = await DataProvider.VratiManekeneModneAgencije(null);
        if (manekeni.IsError)
        {
            return StatusCode(manekeni.Error.StatusCode, manekeni.Error.Message);
        } 
        return Ok(manekeni.Data);
    }

    [HttpGet("VratiManekeneModneRevije/{rbr}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetByRevija(int rbr)
    {
        var manekeni = await DataProvider.VratiManekeneModneRevije(rbr);
        if (manekeni.IsError)
        {
            return StatusCode(manekeni.Error.StatusCode, manekeni.Error.Message);
        }
        return Ok(manekeni.Data);
    }

    [HttpPost("DodajManekena")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
    public async Task<IActionResult> AddManeken([FromBody] ManekenBasic maneken)
    {
        var check = await DataProvider.DodajManekena(maneken);
        if (check.IsError)
        {
            return StatusCode(check.Error.StatusCode, check.Error.Message);
        }
        return Ok($"Uspešno dodat maneken {maneken.MBR}: {maneken.Ime.ToString()}!");
    }

    [HttpPut("AzurirajManekena")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
    public async Task<IActionResult> UpdateManeken([FromBody] ManekenBasic maneken)
    {
        var check = await DataProvider.AzurirajManekena(maneken);
        if (check.IsError)
        {
            return StatusCode(check.Error.StatusCode, check.Error.Message);
        }
        return Ok($"Uspešno ažuriran maneken {maneken.MBR}!");
    }

    [HttpPatch("DodajModnuAgencijuManekenu/{mbr}/{pib}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> AddModnaAgencijaToManeken(string mbr, string pib)
    {
        var check = await DataProvider.DodajModnuAgencijuManekenu(mbr, pib);
        if (check.IsError)
        {
            return StatusCode(check.Error.StatusCode, check.Error.Message);
        }
        return Ok($"Uspešno dodata agencija sa PIB-om {pib} manekenu sa MBR-om {mbr}!");
    }

    [HttpPatch("ObrisiModnuAgencijuManekenu/{mbr}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> RemoveModnaAgencijaFromManeken(string mbr)
    {
        var check = await DataProvider.ObrisiModnuAgencijuManekenu(mbr);
        if (check.IsError)
        {
            return StatusCode(check.Error.StatusCode, check.Error.Message);
        }
        return Ok($"Uspešno obrisana agencija manekenu sa MBR-om {mbr}!");
    }

    [HttpPatch("DodajModnuRevijuManekenu/{mbr}/{rbr}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> AddModnaRevijaToManeken(string mbr, int rbr)
    {
        var check = await DataProvider.DodajModnuRevijuManekenu(mbr, rbr);
        if (check.IsError)
        {
            return StatusCode(check.Error.StatusCode, check.Error.Message);
        }
        return Ok($"Uspešno dodata modna revija sa rednim borjem {rbr} manekenu sa MBR-om {mbr}!");
    }

    [HttpPatch("ObrisiModnuRevijuManekenu/{mbr}/{rbr}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> RemoveModnaRevijaFromManeken(string mbr, int rbr)
    {
        var check = await DataProvider.ObrisiModnuRevijuManekenu(mbr, rbr);
        if (check.IsError)
        {
            return StatusCode(check.Error.StatusCode, check.Error.Message);
        }
        return Ok($"Uspešno obrisana modna revija sa rednim borjem {rbr} manekenu sa MBR-om {mbr}!");
    }

    [HttpDelete("ObrisiManekena/{mbr}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> RemoveManeken(string mbr)
    {
        var check = await DataProvider.ObrisiManekena(mbr);
        if (check.IsError)
        {
            return StatusCode(check.Error.StatusCode, check.Error.Message);
        }
        return Ok($"Uspešno obrisan maneken sa MBR-om {mbr}!");
    }
}

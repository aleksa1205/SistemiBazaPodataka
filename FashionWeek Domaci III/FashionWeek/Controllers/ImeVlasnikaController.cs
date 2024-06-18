using FashionWeek_Library.Entiteti.Helper;

namespace FashionWeek.Controllers;

[ApiController]
[Route("[controller]")]
public class ImeVlasnikaController : ControllerBase
{
    [HttpGet("VratiImenaVlasnika")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> GetAll()
    {
        var vlasnici = await DataProvider.VratiImenaVlasnika();
        if (vlasnici.IsError)
        {
            return StatusCode(vlasnici.Error.StatusCode, vlasnici.Error.Message);
        }
        return Ok(vlasnici.Data);
    }

    [HttpGet("VratiImenaVlasnikaModneKuce/{naziv}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> GetByModnaKuca(string naziv)
    {
        var vlasnici = await DataProvider.VratiImenaVlasnikaModneKuce(naziv);
        if (vlasnici.IsError)
        {
            return StatusCode(vlasnici.Error.StatusCode, vlasnici.Error.Message);
        }
        return Ok(vlasnici.Data);
    }

    [HttpPost("DodajImeVlasnika/{naziv}/{licnoIme}/{prezime}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
    public async Task<IActionResult> AddImeVlasnika(string naziv, string licnoIme, string prezime)
    {
        Ime ime = new Ime(licnoIme, prezime);
        var check = await DataProvider.DodajImeVlasnika(naziv, ime);
        if (check.IsError)
        {
            return StatusCode(check.Error.StatusCode, check.Error.Message);
        }
        return Ok($"Uspešno dodata vlasnik {ime.ToString()} modnoj kući sa nazivom {naziv}!");
    }

    [HttpDelete("ObrisiImeVlasnika/{naziv}/{licnoIme}/{prezime}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> RemoveCasopis(string naziv, string licnoIme, string prezime)
    {
        Ime ime = new Ime(licnoIme, prezime);
        var check = await DataProvider.ObrisiImeVlasnika(naziv, ime);
        if (check.IsError)
        {
            return StatusCode(check.Error.StatusCode, check.Error.Message);
        }
        return Ok($"Uspešno obrisan vlasnik {ime.ToString()} iz modne kuće sa nazivom {naziv}!");
    }
}

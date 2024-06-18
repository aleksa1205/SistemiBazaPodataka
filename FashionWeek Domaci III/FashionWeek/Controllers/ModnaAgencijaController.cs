namespace FashionWeek.Controllers;

[ApiController]
[Route("[controller]")]
public class ModnaAgencijaController : ControllerBase
{
    [HttpGet("VratiSveModneAgencije")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> GetAll()
    {
        var agencije = await DataProvider.VratiSveModneAgencije();
        if (agencije.IsError)
        {
            return StatusCode(agencije.Error.StatusCode, agencije.Error.Message);
        }
        return Ok(agencije.Data);
    }

    [HttpGet("VratiModnuAgenciju/{pib}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetByPIB(string pib)
    {
        var modnaAgencija = await DataProvider.VratiModnuAgenciju(pib);
        if (modnaAgencija.IsError)
        {
            return StatusCode(modnaAgencija.Error.StatusCode, modnaAgencija.Error.Message);
        }
        return Ok(modnaAgencija.Data);
    }

    [HttpPost("DodajModnuAgenciju")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
    public async Task<IActionResult> AddModnaAgenciju([FromBody] ModnaAgencijaView modnaAgencija)
    {
        var check = await DataProvider.DodajModnuAgenciju(modnaAgencija);
        if (check.IsError)
        {
            return StatusCode(check.Error.StatusCode, check.Error.Message);
        }
        return Ok($"Uspešno dodata modna agencija {modnaAgencija.PIB}: {modnaAgencija.Naziv}!");
    }

    [HttpPut("AzurirajModnuAgenciju")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
    public async Task<IActionResult> UpdateModnaAgencija([FromBody] ModnaAgencijaView agencija)
    {
        var check = await DataProvider.AzurirajModnuAgenciju(agencija);
        if (check.IsError)
        {
            return StatusCode(check.Error.StatusCode, check.Error.Message);
        }
        return Ok($"Uspešno ažurirana modna agencija {agencija.PIB}!");
    }

    [HttpDelete("ObrisiModnuAgenciju/{pib}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> RemoveModnaKuca(string pib)
    {
        var check = await DataProvider.ObrisiModnuKucu(pib);
        if (check.IsError)
        {
            return StatusCode(check.Error.StatusCode, check.Error.Message);
        }
        return Ok($"Uspešno obrisana modna agencija sa PIB-om {pib}!");
    }
}

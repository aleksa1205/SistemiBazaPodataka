using FashionWeek_Library.DTO.Basic;

namespace FashionWeek.Controllers;

[ApiController]
[Route("[controller]")]
public class ModnaKucaController : ControllerBase
{
    [HttpGet("VratiSveModneKuce")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> GetAll()
    {
        var modneKuce = await DataProvider.VratiSveModneKuce();
        if (modneKuce.IsError)
        {
            return StatusCode(modneKuce.Error.StatusCode, modneKuce.Error.Message);
        }
        return Ok(modneKuce.Data);
    }

    [HttpGet("VratiModnuKucu/{naziv}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetByNaziv(string naziv)
    {
        var modnaKuca = await DataProvider.VratiModnuKucu(naziv);
        if (modnaKuca.IsError)
        {
            return StatusCode(modnaKuca.Error.StatusCode, modnaKuca.Error.Message);
        }
        return Ok(modnaKuca.Data);
    }

    [HttpPost("DodajModnuKucu")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
    public async Task<IActionResult> AddModnaKuca([FromBody] ModnaKucaBasic modnaKuca)
    {
        var check = await DataProvider.DodajModnuKucu(modnaKuca);
        if (check.IsError)
        {
            return StatusCode(check.Error.StatusCode, check.Error.Message);
        }
        return Ok($"Uspešno dodata modna kuća {modnaKuca.Naziv}!");
    }

    [HttpPut("AzurirajModnuKucu")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
    public async Task<IActionResult> UpdateModnaKuca([FromBody] ModnaKucaBasic modnaKuca)
    {
        var check = await DataProvider.AzurirajModnuKucu(modnaKuca);
        if (check.IsError)
        {
            return StatusCode(check.Error.StatusCode, check.Error.Message);
        }
        return Ok($"Uspešno ažuriran modna kuća {modnaKuca.Naziv}!");
    }

    [HttpDelete("ObrisiModnuKucu/{naziv}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> RemoveModnaKuca(string naziv)
    {
        var check = await DataProvider.ObrisiModnuKucu(naziv);
        if (check.IsError)
        {
            return StatusCode(check.Error.StatusCode, check.Error.Message);
        }
        return Ok($"Uspešno obrisana modna kuća sa nazivom {naziv}!");
    }
}

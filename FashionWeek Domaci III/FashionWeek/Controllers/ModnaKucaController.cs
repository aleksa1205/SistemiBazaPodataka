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
    public async Task<IActionResult> GetByNaziv(string naziv)
    {
        var modnaKuca = await DataProvider.VratiModnuKucu(naziv);
        if (modnaKuca.IsError)
        {
            return StatusCode(modnaKuca.Error.StatusCode, modnaKuca.Error.Message);
        }
        return Ok(modnaKuca.Data);
    }
}

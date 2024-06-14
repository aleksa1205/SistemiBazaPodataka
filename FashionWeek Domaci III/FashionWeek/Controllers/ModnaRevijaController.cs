namespace FashionWeek.Controllers;

[ApiController]
[Route("[controller]")]
public class ModnaRevijaController : ControllerBase
{
    [HttpGet("VratiSveModneRevije")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> GetAll()
    {
        var revije = await DataProvider.VratiSveModneRevije();
        if (revije.IsError)
        {
            return StatusCode(revije.Error.StatusCode, revije.Error.Message);
        }
        return Ok(revije.Data);
    }

    [HttpGet("VratiModnuReviju/{rbr}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> GetByRBR(int rbr)
    {
        var modnaRevija = await DataProvider.VratiModnuReviju(rbr);
        if (modnaRevija.IsError)
        {
            return StatusCode(modnaRevija.Error.StatusCode, modnaRevija.Error.Message);
        }
        return Ok(modnaRevija.Data);
    }
}

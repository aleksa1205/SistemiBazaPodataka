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
    public async Task<IActionResult> GetByPIB(string pib)
    {
        var modnaAgencija = await DataProvider.VratiModnuAgenciju(pib);
        if (modnaAgencija.IsError)
        {
            return StatusCode(modnaAgencija.Error.StatusCode, modnaAgencija.Error.Message);
        }
        return Ok(modnaAgencija.Data);
    }
}

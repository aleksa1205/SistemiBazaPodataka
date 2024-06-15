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
}

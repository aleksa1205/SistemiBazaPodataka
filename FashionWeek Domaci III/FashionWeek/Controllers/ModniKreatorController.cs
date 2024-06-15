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
}

namespace FashionWeek.Controllers;

[ApiController]
[Route("[controller]")]
public class CasopisController : ControllerBase
{
    [HttpGet("VratiSveCasopise")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> GetAll()
    {
        var casopisi = await DataProvider.VratiSveCasopise();
        if (casopisi.IsError)
        {
            return StatusCode(casopisi.Error.StatusCode, casopisi.Error.Message);
        }
        return Ok(casopisi.Data);
    }

    [HttpGet("VratiCasopiseManekena/{mbr}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> GetByManeken(string mbr)
    {
        var casopisi = await DataProvider.VratiCasopiseManekena(mbr);
        if (casopisi.IsError)
        {
            return StatusCode(casopisi.Error.StatusCode, casopisi.Error.Message);
        }
        return Ok(casopisi.Data);
    }

    [HttpPost("DodajCasopis/{mbr}/{nazivCasopisa}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
    public async Task<IActionResult> AddCasopis(string mbr, string nazivCasopisa)
    {
        var check = await DataProvider.DodajCasopis(mbr, nazivCasopisa);
        if (check.IsError)
        {
            return StatusCode(check.Error.StatusCode, check.Error.Message);
        }
        return Ok($"Uspešno dodata časopis {nazivCasopisa} manekenu sa MBR-om {mbr}!");
    }

    [HttpDelete("ObrisiCasopis/{mbr}/{nazivCasopisa}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> RemoveCasopis(string mbr, string nazivCasopisa)
    {
        var check = await DataProvider.ObrisiCasopis(mbr, nazivCasopisa);
        if (check.IsError)
        {
            return StatusCode(check.Error.StatusCode, check.Error.Message);
        }
        return Ok($"Uspešno obrisan časopis {nazivCasopisa} kod manekena sa MBR-om {mbr}!");
    }
}

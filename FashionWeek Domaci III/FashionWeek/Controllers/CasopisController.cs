namespace FashionWeek.Controllers;

[ApiController]
[Route("[controller]")]
public class CasopisController : ControllerBase
{
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
}

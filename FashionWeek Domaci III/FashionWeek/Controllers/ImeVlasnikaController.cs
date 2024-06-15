namespace FashionWeek.Controllers;

[ApiController]
[Route("[controller]")]
public class ImeVlasnikaController : ControllerBase
{
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
}

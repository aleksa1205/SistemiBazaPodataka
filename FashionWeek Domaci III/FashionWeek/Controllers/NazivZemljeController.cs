namespace FashionWeek.Controllers;

[ApiController]
[Route("[controller]")]
public class NazivZemljeController : ControllerBase
{
    [HttpGet("VratiNaziveZemaljaInostraneAgencije/{pib}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
    public async Task<IActionResult> GetByInostranaAgencija(string pib)
    {
        var naziviZemalja = await DataProvider.VratiNaziveZemaljaInostraneAgencije(pib);
        if (naziviZemalja.IsError)
        {
            return StatusCode(naziviZemalja.Error.StatusCode, naziviZemalja.Error.Message);
        }
        return Ok(naziviZemalja.Data);
    }

    [HttpPost("DodajZemlju/{pib}/{nazivZemlje}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
    public async Task<IActionResult> AddZemlja(string pib, string nazivZemlje)
    {
        var check = await DataProvider.DodajZemlju(pib, nazivZemlje);
        if (check.IsError)
        {
            return StatusCode(check.Error.StatusCode, check.Error.Message);
        }
        return Ok($"Uspešno dodata zemlja {nazivZemlje} modnoj agenciji sa PIB-om {pib}!");
    }

    [HttpDelete("ObrisiZemlju/{pib}/{nazivZemlje}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
    public async Task<IActionResult> RemoveZemlja(string pib, string nazivZemlje)
    {
        var check = await DataProvider.ObrisiZemlju(pib, nazivZemlje);
        if (check.IsError)
        {
            return StatusCode(check.Error.StatusCode, check.Error.Message);
        }
        return Ok($"Uspešno obrisana zemlja {nazivZemlje} modnoj agenciji sa PIB-om {pib}!");
    }
}

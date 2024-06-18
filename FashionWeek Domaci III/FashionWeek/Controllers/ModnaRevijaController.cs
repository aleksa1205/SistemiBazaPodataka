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
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetByRBR(int rbr)
    {
        var modnaRevija = await DataProvider.VratiModnuReviju(rbr);
        if (modnaRevija.IsError)
        {
            return StatusCode(modnaRevija.Error.StatusCode, modnaRevija.Error.Message);
        }
        return Ok(modnaRevija.Data);
    }

    [HttpGet("VratiModneRevijeManekena/{mbr}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetByManeken(string mbr)
    {
        var modnaRevija = await DataProvider.VratiModneRevijeManekena(mbr);
        if (modnaRevija.IsError)
        {
            return StatusCode(modnaRevija.Error.StatusCode, modnaRevija.Error.Message);
        }
        return Ok(modnaRevija.Data);
    }

    [HttpGet("VratiModneRevijeModnogKreatora/{mbr}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetByModniKreator(string mbr)
    {
        var modneRevije = await DataProvider.VratiModneRevijeModnogKreatora(mbr);
        if (modneRevije.IsError)
        {
            return StatusCode(modneRevije.Error.StatusCode, modneRevije.Error.Message);
        }
        return Ok(modneRevije.Data);
    }

    [HttpGet("VratiModneRevijeOrganizatora/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetByOrganizator(int id)
    {
        var modneRevije = await DataProvider.VratiModneRevijeOrganizatora(id);
        if (modneRevije.IsError)
        {
            return StatusCode(modneRevije.Error.StatusCode, modneRevije.Error.Message);
        }
        return Ok(modneRevije.Data);
    }

    [HttpPost("DodajModnuReviju")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
    public async Task<IActionResult> AddModnaRevija([FromBody] ModnaRevijaView revija)
    {
        var check = await DataProvider.DodajModnuReviju(revija);
        if (check.IsError)
        {
            return StatusCode(check.Error.StatusCode, check.Error.Message);
        }
        return Ok($"Uspešno dodata modna revija!");
    }

    [HttpPut("AzurirajModnuReviju")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
    public async Task<IActionResult> UpdateModnaRevija([FromBody] ModnaRevijaView revija)
    {
        var check = await DataProvider.AzurirajModnuReviju(revija);
        if (check.IsError)
        {
            return StatusCode(check.Error.StatusCode, check.Error.Message);
        }
        return Ok($"Uspešno ažurirana modna revija {revija.RBR}!");
    }

    [HttpDelete("ObrisiModnuReviju/{rbr}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> RemoveModnaRevija(int rbr)
    {
        var check = await DataProvider.ObrisiModnuReviju(rbr);
        if (check.IsError)
        {
            return StatusCode(check.Error.StatusCode, check.Error.Message);
        }
        return Ok($"Uspešno obrisana modna revija sa rednim brojem {rbr}!");
    }
}

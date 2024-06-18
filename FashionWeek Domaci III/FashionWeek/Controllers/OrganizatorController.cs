using FashionWeek_Library.DTO.Basic;

namespace FashionWeek.Controllers;

[ApiController]
[Route("[controller]")]
public class OrganizatorController : ControllerBase
{
    [HttpGet("VratiSveOrganizatore")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> GetAll()
    {
        var organizatori = await DataProvider.VratiSveOrganizatore();
        if (organizatori.IsError)
        {
            return StatusCode(organizatori.Error.StatusCode, organizatori.Error.Message);
        }
        return Ok(organizatori.Data);
    }

    [HttpGet("VratiOrganizatora/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetByID(int id)
    {
        var organizator = await DataProvider.VratiOrganizatora(id);
        if (organizator.IsError)
        {
            return StatusCode(organizator.Error.StatusCode, organizator.Error.Message);
        }
        return Ok(organizator.Data);
    }

    [HttpPost("DodajOrganizatora")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
    public async Task<IActionResult> AddOrganizator([FromBody] OrganizatorBasic organizator)
    {
        var check = await DataProvider.DodajOrganizatora(organizator);
        if (check.IsError)
        {
            return StatusCode(check.Error.StatusCode, check.Error.Message);
        }
        return Ok($"Uspešno dodat organizator!");
    }


    [HttpPatch("DodajModnuRevijuOrganizatoru/{id}/{rbr}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> AddModnaRevijaToOrganizator(int id, int rbr)
    {
        var check = await DataProvider.DodajModnuRevijuOrganizatoru(id, rbr);
        if (check.IsError)
        {
            return StatusCode(check.Error.StatusCode, check.Error.Message);
        }
        return Ok($"Uspešno dodata modna revija sa rednim brojem {rbr} organizatoru sa ID-em {id}!");
    }

    [HttpPatch("ObrisiModnuRevijuOrganizatoru/{id}/{rbr}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> RemoveModnaRevijaFromOrganizator(int id, int rbr)
    {
        var check = await DataProvider.ObrisiModnuRevijuOrganizatoru(id, rbr);
        if (check.IsError)
        {
            return StatusCode(check.Error.StatusCode, check.Error.Message);
        }
        return Ok($"Uspešno obrisana modna revija sa rednim brojem {rbr} organizatoru sa ID-em {id}!");
    }

    [HttpDelete("ObrisiOrganizatora/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> RemoveOrganizator(int id)
    {
        var check = await DataProvider.ObrisiOrganizatora(id);
        if (check.IsError)
        {
            return StatusCode(check.Error.StatusCode, check.Error.Message);
        }
        return Ok($"Uspešno obrisan organizator sa ID-em {id}!");
    }
}

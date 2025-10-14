using racoon_api.Models;
using racoon_api.Services;

namespace racoon_api.Controllers;

[ApiController]
[Route("api/racoons")]
public class RacoonsController : ControllerBase
{
  private readonly RacoonsService _racoonsService;

  public RacoonsController(RacoonsService racoonsService)
  {
    _racoonsService = racoonsService;
  }


  [HttpGet]
  public ActionResult<List<Racoon>> getAllRacoons()
  {
    try
    {
      List<Racoon> racoons = _racoonsService.getAllRacoons();
      return Ok(racoons);
    }
    catch (Exception exception)
    {
      return BadRequest(exception.Message);
    }
  }














}
using racoon_api.Models;
using racoon_api.Repositories;

namespace racoon_api.Services;




public class RacoonsService
{


  private readonly RacoonsRepository _racoonsRepository;

  public RacoonsService(RacoonsRepository racoonsRepository)
  {
    _racoonsRepository = racoonsRepository;
  }


  public List<Racoon> getAllRacoons()
  {
    List<Racoon> racoons = _racoonsRepository.getAllRacoons();
    return racoons;
  }

  internal Racoon createRacoon(Racoon racoondata)
  {
    Racoon racoon = _racoonsRepository.createRacoon(racoondata);
    return racoon;
  }

  public void deleteRacoon(int racoonId)
  {
    _racoonsRepository.deleteRacoon(racoonId);
  }
}
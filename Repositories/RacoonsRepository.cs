using racoon_api.Models;

namespace racoon_api.Repositories;






public class RacoonsRepository
{

  private readonly IDbConnection _db;


  public RacoonsRepository(IDbConnection db)
  {
    _db = db;
  }


  public List<Racoon> getAllRacoons()
  {
    string sql = "SELECT * FROM racoons;";
    List<Racoon> racoons = _db.Query<Racoon>(sql).ToList();
    return racoons;
  }






}













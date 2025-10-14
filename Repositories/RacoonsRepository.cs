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

  internal Racoon createRacoon(Racoon racoondata)
  {
    string sql = @"
    INSERT INTO
    racoons
    (name, color, age, isCool)
    VALUES (@Name, @Color, @Age, @IsCool);
    SELECT * FROM racoons WHERE id = LAST_INSERT_ID();";

    Racoon racoon = _db.Query<Racoon>(sql, racoondata).SingleOrDefault();
    return racoon;
  }
}













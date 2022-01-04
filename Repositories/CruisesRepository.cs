using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using vacayBackend.Models;

namespace vacayBackend.Repositories
{
  public class CruisesRepository
  {
    private readonly IDbConnection _db;

    public CruisesRepository(IDbConnection db)
    {
      _db = db;
    }

    internal List<Cruise> Get()
    {
      string sql = @"
      SELECT * FROM cruises
      ;";
      return _db.Query<Cruise>(sql).ToList();
    }

  }
}
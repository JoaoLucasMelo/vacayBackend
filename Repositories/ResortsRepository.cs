using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using vacayBackend.Models;

namespace vacayBackend.Repositories
{
  public class ResortsRepository
  {
    private readonly IDbConnection _db;

    public ResortsRepository(IDbConnection db)
    {
      _db = db;
    }

    internal List<Resort> Get()
    {
      string sql = @"
      SELECT * FROM resorts
      ;";
      return _db.Query<Resort>(sql).ToList();
    }
  }
}
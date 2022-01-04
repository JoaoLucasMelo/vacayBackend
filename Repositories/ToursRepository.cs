using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using vacayBackend.Models;

namespace vacayBackend.Repositories
{
  public class ToursRepository
  {
    private readonly IDbConnection _db;

    public ToursRepository(IDbConnection db)
    {
      _db = db;
    }

    internal Tour Create(Tour newTour)
    {
      string sql = @"
      INSERT INTO tours
      (city, duration, price, cruiseId, resortId)
      VALUES
      (@City, @Duration, @Price, @CruiseId, @ResortId);
      SELECT LAST_INSERT_ID()
      ;";
      int id = _db.ExecuteScalar<int>(sql, newTour);
      newTour.Id = id;
      return newTour;
    }
    internal List<TourViewModel> GetToursByResort(int id)
    {
      string sql = @"
      SELECT
      t.*,
      r.*,
      c.*
      FROM tours t
      JOIN resorts r ON t.resortId = r.id
      JOIN cruises c ON t.cruiseId = c.id
      WHERE t.resortId = @id
      ;";
      return _db.Query<TourViewModel, Resort, Cruise, TourViewModel>(sql, (tvm, resort, cruise) =>
      {
        tvm.Cruise = cruise;
        tvm.Resort = resort;
        return tvm;
      }, new { id }).ToList();
    }


    internal List<TourViewModel> GetToursByCruise(int id)
    {
      string sql = @"
      SELECT
      t.*,
      r.*,
      c.*
      FROM tours t
      JOIN resorts r ON t.resortId = r.id
      JOIN cruises c ON t.cruiseId = c.id
      WHERE t.cruiseId = @id
      ;";
      return _db.Query<TourViewModel, Resort, Cruise, TourViewModel>(sql, (tvm, resort, cruise) =>
      {
        tvm.Cruise = cruise;
        tvm.Resort = resort;
        return tvm;
      }, new { id }).ToList();
    }
  }
}
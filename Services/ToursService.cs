using System;
using System.Collections.Generic;
using vacayBackend.Models;
using vacayBackend.Repositories;

namespace vacayBackend.Services
{
  public class ToursService
  {
    private readonly ToursRepository _repo;

    public ToursService(ToursRepository repo)
    {
      _repo = repo;
    }

    internal List<TourViewModel> GetTours(int id)
    {
      return _repo.GetToursByResort(id);
    }

    internal List<TourViewModel> GetToursByCruise(int id)
    {
      return _repo.GetToursByCruise(id);
    }

    internal Tour Create(Tour newTour)
    {
      return _repo.Create(newTour);
    }
  }
}
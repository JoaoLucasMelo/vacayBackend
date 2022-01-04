using System;
using System.Collections.Generic;
using vacayBackend.Models;
using vacayBackend.Repositories;

namespace vacayBackend.Services
{
  public class CruisesService
  {
    private readonly CruisesRepository _repo;

    public CruisesService(CruisesRepository repo)
    {
      _repo = repo;
    }

    internal List<Cruise> Get()
    {
      return _repo.Get();
    }
  }
}
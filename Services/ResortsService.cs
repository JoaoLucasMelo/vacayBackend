using System;
using System.Collections.Generic;
using vacayBackend.Models;
using vacayBackend.Repositories;

namespace vacayBackend.Services
{
  public class ResortsService
  {
    private readonly ResortsRepository _repo;

    public ResortsService(ResortsRepository repo)
    {
      _repo = repo;
    }

    internal List<Resort> Get()
    {
      return _repo.Get();
    }


  }
}
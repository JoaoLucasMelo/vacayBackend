using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using vacayBackend.Models;
using vacayBackend.Services;

namespace vacayBackend.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ResortsController : ControllerBase
  {
    private readonly ResortsService _rs;
    private readonly ToursService _ts;

    public ResortsController(ResortsService rs, ToursService ts)
    {
      _rs = rs;
      _ts = ts;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Resort>> Get()
    {
      {
        try
        {
          List<Resort> resorts = _rs.Get();
          return Ok(resorts);
        }
        catch (Exception e)
        {
          return BadRequest(e.Message);
        }
      }
    }

    [HttpGet("{id}/tours")]
    public ActionResult<IEnumerable<TourViewModel>> GetTours(int id)
    {
      try
      {
        List<TourViewModel> tours = _ts.GetTours(id);
        return Ok(tours);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using vacayBackend.Models;
using vacayBackend.Services;

namespace vacayBackend.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class CruisesController : ControllerBase
  {
    private readonly CruisesService _cs;
    private readonly ToursService _ts;

    public CruisesController(CruisesService cs, ToursService ts)
    {
      _cs = cs;
      _ts = ts;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Cruise>> Get()
    {
      try
      {
        List<Cruise> cruises = _cs.Get();
        return Ok(cruises);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpGet("{id}/tours")]
    public ActionResult<IEnumerable<TourViewModel>> GetToursByCruise(int id)
    {
      try
      {
        List<TourViewModel> cruises = _ts.GetToursByCruise(id);
        return Ok(cruises);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}
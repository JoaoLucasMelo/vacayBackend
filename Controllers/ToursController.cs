using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using vacayBackend.Models;
using vacayBackend.Services;

namespace vacayBackend.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ToursController : ControllerBase
  {
    private readonly ToursService _ts;

    public ToursController(ToursService ts)
    {
      _ts = ts;
    }

    [HttpPost]
    public ActionResult<Tour> Create([FromBody] Tour newTour)
    {
      try
      {
        Tour tour = _ts.Create(newTour);
        return Ok(tour);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

  }
}
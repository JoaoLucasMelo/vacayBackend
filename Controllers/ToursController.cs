using Microsoft.AspNetCore.Mvc;
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


  }
}
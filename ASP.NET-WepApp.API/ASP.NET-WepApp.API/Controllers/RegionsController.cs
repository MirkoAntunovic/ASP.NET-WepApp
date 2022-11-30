using ASP.NET_WepApp.API.Models.Domein;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_WepApp.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegionsController : Controller
    {
        [HttpGet]
        public IActionResult GetAllRegions()
        {

            var regions = new List<Region>()
            {

                new Region
                {

                    Id = Guid.NewGuid(),
                  Name = "Zagreb",
                  Code ="ZG",
                  Area=323232,
                  Lat=1.3232,
                  Long=299.3,
                  Population=90000

                },

                 new Region {


                  Id = Guid.NewGuid(),
                  Name = "Split",
                  Code ="st",
                  Area=323232,
                  Lat=1.3232,
                  Long=299.3,
                  Population=90000

              }




            };

            return Ok(regions);


        }

    }
}

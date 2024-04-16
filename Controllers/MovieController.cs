using Microsoft.AspNetCore.Mvc;
using movie_rating_backend.Models;
namespace movie_rating_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        

        [HttpGet]
        public IEnumerable<Movie> Get()
        {
          
        }
    }
}

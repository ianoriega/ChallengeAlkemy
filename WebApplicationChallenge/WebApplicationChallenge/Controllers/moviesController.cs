using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationChallenge.Clases;

namespace WebApplicationChallenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class moviesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Film>> Get(string name, int genre, string order)
        {
            if (name != null)
            {
                return Disney.FilmBuscarPorNombre(name);
            }
            else if (genre > 0)
            {
                return Disney.GetFilms();
            }
            else if (order !=null)
            {
                return Disney.GetFilms();
            }
            else
            {
                return Disney.GetFilms();
            }
            
            
            
        }
    }
}

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
    public class charactersController : ControllerBase
    {
        /// <summary>
        /// GET Permite obtener lista de los personajes o ejecutar busquedas en base a name,age,idmovies
        /// </summary>
        /// <param name="name">recibe el nombre a buscar</param>
        /// <param name="age">recibe la edad a buscar</param>
        /// <param name="movies">recib el di de la pelicula a buscar</param>
        /// <returns>List del tipo Personaje con los resultados de la busqueda o bien con todos los personajes</returns>
        [HttpGet]
        public ActionResult<List<Personaje>> Get(string name, int age, int movies)
        {            
            if (name != null)
            {
                return Disney.CharBuscarPorNombre(name);
            }
            else if (age > 0)
            {
                return Disney.CharBuscarPorEdad(age);
            }
            else if (movies >0 )
            {
                return Disney.CharBuscarPorIdMovie(movies);
            }
            else
            {
                return Ok(Disney.GetPersonajes());
            }
        }

         [HttpPost]
         public ActionResult<string> PostCrearPersonaje(Personaje personaje)
         {
             Disney.AgregarPersonaje(personaje);
             return $"personaje {personaje.Nombre} creado";
         }
       
        [HttpPut("{id}")]
        public Personaje Put(int id, Personaje personaje)
        {
            Personaje retorno = null;
 
            List<Personaje> listaux = Disney.GetPersonajes();
            foreach (var item in listaux)
            {
                if (item.Id == id)
                {
                    item.Nombre = personaje.Nombre;
                    item.Edad=personaje.Edad;
                    item.Peso=personaje.Peso;
                    item.Historia=personaje.Historia;
                    retorno =  item;
                    break;
                }
            }
            Disney.BajarIdPersonaje();
            return retorno;
        }

        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return Disney.EliminarPersonaje(id);    
        }


    }
}

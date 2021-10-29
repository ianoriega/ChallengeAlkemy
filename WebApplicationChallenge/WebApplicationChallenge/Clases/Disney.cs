using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace WebApplicationChallenge.Clases
{
    public static class Disney
    {
        static List<Film> films;
        static List<Personaje> personajes;
        static List<Genero> generos;
        static List<Usuario> usuarios;
        static int idPersonaje;
        static int idFilm;
        static int idGenero;

        static Disney()
        {
            personajes = new List<Personaje>();
            films = new List<Film>();
            films.Add(new Pelicula());
            films.Add(new Pelicula());

        }

        #region Id

        public static int PersonajeGenerarId()
        {
            idPersonaje++;
            return idPersonaje;
        }

        public static void BajarIdPersonaje()
        {
            idPersonaje--;
        }

        public static int FilmGenerarId()
        {
            idFilm++;
            return idFilm;
        }

        public static int GeneroGenerarId()
        {
            idGenero++;
            return idGenero;
        }

        #endregion
        
        #region Personajes
        /// <summary>
        /// Retorna los nombres de los personajes
        /// </summary>
        /// <returns>string con los nombres de los personajes</returns>
        public static string ListarPersonajes()
        {
            StringBuilder auxSb = new StringBuilder();
            foreach (var item in personajes)
            {
                auxSb.AppendLine(item.Nombre);
            }

            string aux = auxSb.ToString();
            return aux;
        }

        /// <summary>
        /// Permite agregar un personaje a la lista de personajes
        /// </summary>
        /// <param name="personaje"></param>
        public static void AgregarPersonaje(Personaje personaje)
        {
            personajes.Add(personaje);
        }

        /// <summary>
        /// Permite obtener el listado de personajes
        /// </summary>
        /// <returns>List de personajes</returns>
        public static List<Personaje> GetPersonajes()
        {
            return personajes;
        }


        /// <summary>
        /// Permite eliminar un personaje de la lista de personajes
        /// </summary>
        /// <param name="id"></param>
        /// <returns>true si pudo eliminar false si no pudo</returns>
        public static bool EliminarPersonaje(int id)
        {
            bool retorno = false;
            foreach (var item in personajes)
            {
                if (item.Id == id)
                {
                   retorno = personajes.Remove(item);
                    break;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Permite buscar un personaje por su nombre
        /// </summary>
        /// <param name="name"></param>
        /// <returns>list de personajes encontrados o null si no encontro coincidencias</returns>
        public static List<Personaje> CharBuscarPorNombre(string name)
        {
            List<Personaje> auxPersonajes = new List<Personaje>();
            foreach (var item in personajes)
            {
                if (item.Nombre == name)
                {
                    auxPersonajes.Add(item);
                }
            }
            return auxPersonajes;
        }

        /// <summary>
        /// Permite buscar un personaje por su edad
        /// </summary>
        /// <param name="edad"></param>
        /// <returns>list de personajes encontrados o null si no encontro coincidencias</returns>
        public static List<Personaje> CharBuscarPorEdad(int edad)
        {
            List<Personaje> auxPersonajes = new List<Personaje>();
            foreach (var item in personajes)
            {
                if (item.Edad == edad)
                {
                    auxPersonajes.Add(item);
                }
            }
            return auxPersonajes;
        }

        /// <summary>
        /// Permite obtener el personaje en base al id de una pelicula
        /// </summary>
        /// <param name="idMovie"></param>
        /// <returns>lista de tipo personaje con las coincidencias</returns>
        public static List<Personaje> CharBuscarPorIdMovie(int idMovie)
        {
            List<Personaje> auxPersonajes = new List<Personaje>();
            foreach (var item in personajes)
            {
                List<Film> auxFilms = item.Films;
                foreach (var film in auxFilms)
                {
                    if (film.Id == idMovie)
                    {
                        auxPersonajes.Add(item);
                    }
                }
            }
            return auxPersonajes;
        }

        #endregion

        #region Films

        /// <summary>
        /// Permite obtener la lista de films
        /// </summary>
        /// <returns></returns>
        public static List<Film> GetFilms()
        {
            return films;
        }

        /// <summary>
        /// Permite obtener la pelicula con el nombre indicado
        /// </summary>
        /// <param name="name"></param>
        /// <returns>lista con la pelicula de nombre buscado</returns>
        public static List<Film> FilmBuscarPorNombre(string name)
        {
            List<Film> auxfilms = new List<Film>();
            foreach (var item in films)
            {
                if (item.Titulo == name)
                {
                    auxfilms.Add(item);
                }
            }
            return auxfilms;
        }


        #endregion
    }
}

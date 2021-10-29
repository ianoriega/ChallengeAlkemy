using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationChallenge.Clases
{
    public abstract class Film
    {
        byte[] imagen;
        string titulo;
        DateTime fechaCreacion;
        int calificacion;
        List<Personaje> personajes;
        int id;
     



        public Film()
        {
            id = Disney.FilmGenerarId();
        }

        #region Propiedades


        public int Id
        {
            get { return id; }
        }

        public byte[] Imagen
        {
            set { imagen = value; }
            get { return imagen; }
        }

        public string Titulo
        {
            set { titulo = value; }
            get { return titulo; }
        }

        public DateTime FechaCreacion
        {
            set { fechaCreacion = value; }
            get { return fechaCreacion; }
        }

        public int Calificacion
        {
            set
            {
                if (value < 6 && value > 0)
                    calificacion = value;
            }
            get { return calificacion; }
        }

        #endregion
    }
}

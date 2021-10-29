using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationChallenge.Clases
{
    public class Genero
    {
        string nombre;
        byte[] imagen;
        List<Film> films;
        int id;

        public Genero()
        {
            id = Disney.GeneroGenerarId();
        }


        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public byte[] Imagen
        {
            set { imagen = value; }
            get { return imagen; }
        }

        public List<Film> Films
        {
            set { films = value; }
            get { return films; }
        }
    }
}

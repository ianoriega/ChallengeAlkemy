using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationChallenge.Clases
{
    public class Personaje
    {
        byte[] imagen;
        List<Film> films;
        int id;
        string nombre;
        int edad;
        float peso;
        string historia;
        

        public Personaje()
        {
            this.id = Disney.PersonajeGenerarId();
        }

        public Personaje(string nombre):this()
        {
            this.nombre = nombre;
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

        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public int Edad
        {
            set { edad = value; }
            get { return edad; }
        }

        public float Peso
        {
            set { peso = value; }
            get { return peso; }
        }

        public string Historia
        {
            set { historia = value; }
            get { return historia; }
        }
        
        public List<Film> Films
        {
            set { films = value; }
            get { return films; }
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationChallenge.Clases
{
    public class Usuario
    {
        string user;
        string pass;
        int id;

        public Usuario()
        {
            this.id = Disney.PersonajeGenerarId();
        }

        public string User
        {
            set { user = value; }
            get { return user; }
        }

        public string Pass
        {
            set { pass = value; }
            get { return pass; }
        }

        public int GetId()
        {
            return id;
        }
    }
}

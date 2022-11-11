using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG.Core.Armas
{
    public class Arma
    {
        private string nombre;
        public Arma(string unNombre)
        {
            nombre = unNombre;
        }
        public string unNombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public virtual int BrindarAtaque(Personaje personaje)
            => 0;
        public virtual int BrindarVelAtaque(Personaje personaje)
            => 0;
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Script
{
    public class Arma
    {
        private string nombre;
        public Arma(string Nombre)
        {
            nombre = Nombre;
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int BrindarAtaque(Personaje personaje)
        {
            
        }
        public int BrindarVelAtaque(Personaje personaje)
        {

        }
    }
}
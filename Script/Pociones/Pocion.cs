using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Script
{
    public class Pocion
    {
        private string nombre;

        public virtual Pocion(string Nombre, int PuntosVida, int PuntosAtaque, int PuntosVelocidad)
        {
            nombre = Nombre;
            puntosVida=PuntosVida;
            puntosAtaque=PuntosAtaque;
            puntosVelocidad=PuntosVelocidad;
        }

        public abstract void AfectarA(Personaje persona);

    }
}
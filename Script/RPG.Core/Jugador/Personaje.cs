using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG.Core.Jugador
{
    public class Personaje
    {
        private string nombre;
        private byte vida;
        private short velAtaqueBase, ataqueBase;
        private Arma arma;

        public Personaje(string unNombre, byte unaVida, short unVelAtaqueBase, short unAtaqueBase)
        {
            nombre = Nombre;
            vida = Vida;
            velAtaqueBase = VelAtaqueBase;
            ataqueBase = AtaqueBase;
            arma = new ManosDesnudas();
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Vida
        {
            get { return vida; }
            set { vida = value; }
        }
        public int VelAtaqueBase
        {
            get { return velAtaqueBase; }
            set { velAtaqueBase = value; }
        }
        public int AtaqueBase
        {
            get { return ataqueBase; }
            set { ataqueBase = value; }
        }
        public int SumarVida(int valor)
        {
            
        }
        public int RestarVida(int valor)
        {

        }
        public void EquiparArma(Arma arma)
        {
            this.arma = arma;
        }
        public int EquiparPocion(Pocion pocion)
        {

        }
        public virtual int AtaqueFinal
            => ataqueBase ;
    }
}
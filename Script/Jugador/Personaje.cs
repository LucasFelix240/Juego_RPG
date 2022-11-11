using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Script
{
    public class Personaje
    {
        private string nombre;
        private byte vida;
        private int velAtaqueBase;
        private int ataqueBase;

        public Personaje(string Nombre, byte Vida, int VelAtaqueBase, int AtaqueBase)
        {
            nombre = Nombre;
            vida = Vida;
            velAtaqueBase = VelAtaqueBase;
            ataqueBase = AtaqueBase;
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

        }
        public int EquiparPocion(Pocion pocion)
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Script.Pociones
{
    public class PocionDragon: Pocion
    {
        private int valor;
        public PocionDragon(int Valor)
        {
            valor=Valor;
        }
        public int Valor
        {
            get{return valor;}
            set{valor=value;}
        }
        
    }
}
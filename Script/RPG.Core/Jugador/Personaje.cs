using RPG.Core.Armas;
using RPG.Core.Pociones;

namespace RPG.Core.Jugador
{
    public abstract class Personaje
    {
        private string nombre;
        private byte vida;
        private short velAtaqueBase, ataqueBase;
        private Arma arma;

        public Personaje(string unNombre, byte unaVida, short unVelAtaqueBase, short unAtaqueBase)
        {
            nombre = unNombre;
            vida = unaVida;
            velAtaqueBase = unVelAtaqueBase;
            ataqueBase = unAtaqueBase;
            arma = new ManosDesnudas();
        }
        public int SumarVida(int valor)
        {
            return 0;
        }
        public int RestarVida(int valor)
        {
            return 0;
        }
        public void EquiparArma(Arma arma)
        {
            this.arma = arma;
        }
        public int EquiparPocion(Pocion pocion)
        {
            return 0;
        }


        public virtual int AtaqueFinal
            => ataqueBase + arma.BrindarAtaque(this);
        
        public void SacarVida(byte decrementoVida)
            => vida = (byte)(vida - decrementoVida);

        public virtual int VelocidadAtaqueFinal
        {
        }


        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void ReducirTiempoAtaque(short decremento)
            => velAtaqueBase = (short)(velAtaqueBase - decremento);
        public void IncrementoDaño(byte incremento)
            => ataqueBase = (short)(ataqueBase + incremento);
        public void CurarVida(byte aumento)
            => vida = (byte)(vida + aumento);
    }
}
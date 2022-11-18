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
        private Pocion? pocion;

        public Personaje(string unNombre, byte unaVida, short unVelAtaqueBase, short unAtaqueBase)
        {
            nombre = unNombre;
            vida = unaVida;
            velAtaqueBase = unVelAtaqueBase;
            ataqueBase = unAtaqueBase;
            arma = new ManosDesnudas();
            pocion = null;
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Esta por la mitad.
        public virtual void SumarVida(short valor)
        {
            vida = (byte)(vida + valor);
        }
        public virtual void RestarVida(short valor)
        {
            vida = (byte)(vida - valor);
        }
        public void EquiparArma(Arma arma)
        {
            this.arma = arma;
        }
        public void EquiparPocion(Pocion pocion)
        {
            this.pocion = pocion;
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Sin completar.
        public virtual int VelocidadAtaqueFinal
            => velAtaqueBase + arma.BrindarVelAtaque(this);
        public virtual int AtaqueFinal
            => ataqueBase + arma.BrindarAtaque(this);
        
        /*public void SacarVida(byte decrementoVida)
            => vida = (byte)(vida - decrementoVida);*/

        /*public virtual int VelocidadAtaqueFinal
        {
        }*/


        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Ya esta hecho.
        public void ReducirTiempoAtaque(short decremento)
            => velAtaqueBase = (short)(velAtaqueBase - decremento);
        public void IncrementoDaño(byte incremento)
            => ataqueBase = (short)(ataqueBase + incremento);
        public void CurarVida(byte aumento)
            => vida = (byte)(vida + aumento);
    }
}
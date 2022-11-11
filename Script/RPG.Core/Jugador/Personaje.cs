using RPG.Core.Armas;
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
            nombre = unNombre;
            vida = unaVida;
            velAtaqueBase = unVelAtaqueBase;
            ataqueBase = unAtaqueBase;
            arma = new ManosDesnudas();
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
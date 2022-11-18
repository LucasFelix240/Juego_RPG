using RPG.Core.Armas;
using RPG.Core.Pociones;

namespace RPG.Core.Jugador
{
    public abstract class Personaje
    {
        public string nombre { get; set; }
        public short vida { get; set; }
        public short velAtaqueBase {get; set;}
        public short ataqueBase { get; set; }
        private Arma arma;
        private List<Pocion> pociones;

        public Personaje(string unNombre, byte unaVida, short unVelAtaqueBase, short unAtaqueBase)
        {
            nombre = unNombre;
            vida = unaVida;
            velAtaqueBase = unVelAtaqueBase;
            ataqueBase = unAtaqueBase;
            arma = new ManosDesnudas();
            pociones = new List<Pocion>();
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
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
        public void EquiparPocion(Pocion pocion) => pociones.Add(pocion);

        public void TomatelasTodas()
        {
            pociones.ForEach(p=>p.AfectarA(this));
            pociones.Clear();
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        /////////////////////////////////////////////////////////////////////////////////////////////////////////

        public virtual int VelocidadAtaqueFinal
            => velAtaqueBase + arma.BrindarVelAtaque(this);
        public virtual int AtaqueFinal
            => ataqueBase + arma.BrindarAtaque(this);

        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Ya esta hecho.
        public void ReducirTiempoAtaque(short decremento)
            => velAtaqueBase = (short)(velAtaqueBase - decremento);
        public void IncrementoDaño(byte incremento)
            => ataqueBase = (short)(ataqueBase + incremento);
        public void CurarVida(byte aumento)
            => vida = (byte)(vida + aumento);
    }
}
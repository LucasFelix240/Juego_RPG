namespace RPG.Core.Jugador
{
    public class Daguero : Personaje
    {
        public Daguero(string unNombre, byte unaVida, short unVelAtaqueBase, short unAtaqueBase) : base(unNombre, unaVida, unVelAtaqueBase, unAtaqueBase)
        {
        }
        public override int VelocidadAtaqueFinal => base.AtaqueFinal + base.AtaqueFinal / 10;
    }
}
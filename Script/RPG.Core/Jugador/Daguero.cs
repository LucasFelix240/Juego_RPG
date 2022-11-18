namespace RPG.Core.Jugador
{
    public class Daguero : Personaje
    {
        public Daguero(string unNombre, byte unaVida, short unVelAtaqueBase, short unAtaqueBase) : base(unNombre, unaVida, unVelAtaqueBase, unAtaqueBase)
        {
        }
        public override int VelocidadAtaqueFinal => base.VelocidadAtaqueFinal - base.VelocidadAtaqueFinal / 10;
        public override void RestarVida(short valor)
        {
            valor = (short)(valor + valor / 10);
            base.RestarVida(valor);
        }
    }
}
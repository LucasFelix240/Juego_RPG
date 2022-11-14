namespace RPG.Core.Jugador
{
    public class Guerrero : Personaje
    {

        public Guerrero(string unNombre, byte unaVida, short unVelAtaqueBase, short unAtaqueBase) : base(unNombre, unaVida, unVelAtaqueBase, unAtaqueBase)
        {
        }
        public override int AtaqueFinal => base.AtaqueFinal + base.AtaqueFinal / 10;

        byte decremento;
        public override void AfectarA(Personaje persona) => persona.SacarVida(decremento);

        /*public byte DescontarVida(byte unaVida)
        {
            return (byte)(unaVida / 10);
        }*/
    }
}
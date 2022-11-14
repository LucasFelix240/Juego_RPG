namespace RPG.Core.Jugador
{
    public class Guerrero : Personaje
    {
        public Guerrero(string unNombre, byte unaVida, short unVelAtaqueBase, short unAtaqueBase) : base(unNombre, unaVida, unVelAtaqueBase, unAtaqueBase)
        {
        }
        public override int AtaqueFinal => base.AtaqueFinal + base.AtaqueFinal / 10;
        
        //
        //Hay que completar.
        //
        
        public override void RestarVida(short valor)
        {
            valor = (short)(valor -  valor / 10);
            base.RestarVida(valor);
        }
        short reducirvida;

        /*public byte DescontarVida(byte unaVida)
        {
            return (byte)(unaVida / 10);
        }*/     
    }
}
namespace RPG.Core.Jugador
{
    public class Alquimista : Personaje
    {
        public Alquimista(string unNombre, byte unaVida, short unVelAtaqueBase, short unAtaqueBase) : base(unNombre, unaVida, unVelAtaqueBase, unAtaqueBase)
        {
        }
        public override void SumarVida(short valor)
        {
            valor = (short)(valor + valor / 5);
            base.SumarVida(valor);
        }
    }
}
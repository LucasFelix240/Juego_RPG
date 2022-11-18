using RPG.Core.Jugador;
namespace RPG.Core.Pociones;
public class PocionRoja : Pocion
{
    byte puntosVida;
    public PocionRoja (byte unosPuntosDeVida)
    {
        puntosVida = unosPuntosDeVida;
    }

    public override void AfectarA(Personaje persona)
    {
        persona.CurarVida(puntosVida);
    }
}

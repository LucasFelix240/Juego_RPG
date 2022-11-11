using RPG.Core.Jugador;
namespace RPG.Core.Pociones;
public class PocionRoja : Pocion
{
    byte puntosVida;
    public override void AfectarA(Personaje persona)
    {
        persona.CurarVida(puntosVida);
    }
}

using RPG.Core.Jugador;

namespace RPG.Core.Pociones;
public class PocionConejo : Pocion
{
    private short TiempoAtaque;
    public override void AfectarA(Personaje persona)
    {
        persona.ReducirTiempoAtaque(TiempoAtaque);
    }
}
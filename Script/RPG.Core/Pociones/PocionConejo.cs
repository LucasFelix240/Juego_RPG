using RPG.Core.Jugador;

namespace RPG.Core.Pociones;
public class PocionConejo : Pocion
{
    private short TiempoAtaque;
    ///////////////////////////////////////////////////////////////////////////
    //No se sabe si esta correcto.
    public PocionConejo (short unTiempoAtaque)
    {
        TiempoAtaque = unTiempoAtaque;
    }
    ///////////////////////////////////////////////////////////////////////////
    public override void AfectarA(Personaje persona)
    {
        persona.ReducirTiempoAtaque(TiempoAtaque);
    }
}
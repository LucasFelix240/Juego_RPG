using RPG.Core.Jugador;

namespace RPG.Core.Pociones;
public class PocionDragon : Pocion
{
    private byte _aumentoDañoBase;

    public override void AfectarA(Personaje persona)
    {
        persona.IncrementoDaño(_aumentoDañoBase);
    }
}

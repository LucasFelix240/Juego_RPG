using RPG.Core.Jugador;

namespace RPG.Core.Armas;
public class DagaFeroz : Arma
{
    public DagaFeroz(string unNombre) : base(unNombre)
    {
    }
    public override int BrindarAtaque(Personaje personaje) => 2;
    public override int BrindarVelAtaque(Personaje personaje) => 2;
}
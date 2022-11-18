using RPG.Core.Jugador;

namespace RPG.Core.Armas;
public class EspadaSimple : Arma
{
    public EspadaSimple(string unNombre) : base(unNombre)
    {
    }
    public override int BrindarAtaque(Personaje personaje) => 15;
    public override int BrindarVelAtaque(Personaje personaje) => 10;
}
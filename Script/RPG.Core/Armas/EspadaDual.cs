using RPG.Core.Jugador;

namespace RPG.Core.Armas;
public class EspadaDual : Arma
{
    public EspadaDual(string unNombre) : base(unNombre)
    {
    }
    public override int BrindarAtaque(Personaje personaje) => 1;
    public override int BrindarVelAtaque(Personaje personaje) => 1;
}
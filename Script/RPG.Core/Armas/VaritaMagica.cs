using RPG.Core.Jugador;
namespace RPG.Core.Armas;
public class VaritaMagica: Arma
{
    public VaritaMagica(string unNombre) : base(unNombre)
    {
    }
    public override int BrindarAtaque(Personaje personaje) => 10;
    public override int BrindarVelAtaque(Personaje personaje) => 0;
}

using RPG.Core.Jugador;
namespace RPG.Core.Armas;
public class Arma
{
    public string nombre { get; set; }
    public Arma(string unNombre)
    {
        nombre = unNombre;
    }
    public virtual int BrindarAtaque(Personaje personaje)
        => 0;
    public virtual int BrindarVelAtaque(Personaje personaje)
        => 0;
}
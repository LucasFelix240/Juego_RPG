using RPG.Core.Jugador;
namespace RPG.Core.Armas;
public class Arma
{
    private string nombre;
    public Arma(string unNombre)
    {
        nombre = unNombre;
    }
    public string unNombre
    {
        get { return nombre; }
        set { nombre = value; }
    }
    public virtual int BrindarAtaque(Personaje personaje)
        => 0;
    public virtual int BrindarVelAtaque(Personaje personaje)
        => 0;
}
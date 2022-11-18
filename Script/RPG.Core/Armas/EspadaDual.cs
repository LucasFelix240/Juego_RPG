using RPG.Core.Jugador;

namespace RPG.Core.Armas;
public class EspadaDual : Arma
{
    byte pesoKilos;
    public EspadaDual(string unNombre, byte unPesoKilos) : base(unNombre)
    {
        pesoKilos = unPesoKilos;
    }
    public override int BrindarAtaque(Personaje personaje) => pesoKilos;
    public override int BrindarVelAtaque(Personaje personaje) => pesoKilos;
}
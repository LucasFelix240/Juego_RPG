using RPG.Core.Jugador;
using RPG.Core.Pociones;

namespace Rpg.Test;

public class RpgTest
{
    public Personaje Ulises { get; set; }
    public Pocion pocionRoja_20 { get; set; }
    public Pocion pocionConejo_1 { get; set; }
    
    public RpgTest()
    {
        Ulises = new Guerrero(unNombre: "Ulises", unaVida: 200, unAtaqueBase: 100, unVelAtaqueBase: 1500);
        pocionRoja_20 = new PocionRoja(unosPuntosDeVida: 20);
        pocionConejo_1 = new PocionConejo(unTiempoAtaque: 1);
    }
    
    [Fact]
    public void Constructor()
    {
        Assert.Equal("Ulises", Ulises.nombre);
        Assert.Equal(200, Ulises.vida);
        Assert.Equal(100, Ulises.ataqueBase);
        Assert.Equal(1500, Ulises.velAtaqueBase);
    }

    [Fact]
    public void EquiparPocion()
    {
        Ulises.EquiparPocion(pocionRoja_20);
        for (int i = 0; i < 5; i++)
        {
            Ulises.EquiparPocion(pocionConejo_1);
        }
    }

    [Fact]
    public void RestarVida()
    {
        Ulises.RestarVida(100);
    }
}
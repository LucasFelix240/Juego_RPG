using RPG.Core.Armas;
using RPG.Core.Jugador;
using RPG.Core.Pociones;

namespace Rpg.Test;

public class RpgTest
{
    public Personaje Ulises { get; set; }
    public Pocion pocionRoja_20 { get; set; }
    public Pocion pocionConejo_1 { get; set; }
    public Arma armaPersonaje { get; set; }
    public Arma espadaSimple_1 { get; set; }
    
    public RpgTest()
    {
        Ulises = new Guerrero(unNombre: "Ulises", unaVida: 200, unAtaqueBase: 100, unVelAtaqueBase: 1500);
        pocionRoja_20 = new PocionRoja(unosPuntosDeVida: 20);
        pocionConejo_1 = new PocionConejo(unTiempoAtaque: 1);
        armaPersonaje = new ManosDesnudas();
        espadaSimple_1 = new EspadaSimple(unNombre: "EspadaSimple");
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
        Assert.Equal(110, Ulises.vida);
        Assert.Equal(110, Ulises.AtaqueFinal);
        Assert.Equal("Manos Desnudas", armaPersonaje.nombre);
    }

    [Theory]
    [InlineData(10)]
    [InlineData(20)]
    [InlineData(30)]

    public void EquiparArma(int cantidadPociones)
    {
        Ulises.EquiparPocion(pocionRoja_20);
        for (int i = 0; i < cantidadPociones; i++)
        {
            Ulises.EquiparPocion(pocionConejo_1);
        }
        Ulises.EquiparArma(espadaSimple_1);
        Ulises.TomatelasTodas();
        Assert.Equal(220, Ulises.vida);
        Assert.Equal(1500 - cantidadPociones, Ulises.velAtaqueBase);
    }
}
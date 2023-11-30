using Fichilandia.Core;
namespace Fichilandia.Test;

public class TestAdoTarjeta : TestAdo

{
    [Theory]
    [InlineData(01, 10)]

    public void TraerListaTarjeta(int idTarjeta, decimal saldo)
    {
        var tarjetas = Ado.ObtenerTarjetas();

        Assert.NotEmpty(tarjetas);
        Assert.Contains(tarjetas, t => t.Saldo == 10);
    }

    [Fact]

    public void AltaTarjeta()
    {
        int idTarjeta = 02;
        decimal saldo = 10;

        //esto es instanciar//
        var nueva02 = new Tarjeta()
        {
            IdTarjeta = idTarjeta,
            Saldo = saldo
        };

        Ado.AltaTarjeta(nueva02);
        Assert.NotEqual(02, 10);

        var tarjetas = Ado.ObtenerTarjetas();

        Assert.NotNull(tarjetas);
        Assert.Contains(tarjetas, t=> t.Saldo ==10 && t.IdTarjeta== 02);
    }
}


// alta tarjeta y obtener tatjeta//
// despues de eso supuestamente me aprueba y que mi grupo se va a volver loco//

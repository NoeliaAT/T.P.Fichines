using Fichilandia.Core;
namespace Fichilandia.Test;

public class TestAdoTarjeta : TestAdo

{
    [Theory]
    [InlineData(01, 10.50)]

    public void TraerListaTarjeta(int idTarjeta, decimal saldo)
    {
        var tarjetas = Ado.ObtenerTarjetas();

        Assert.NotEmpty(tarjetas);
        Assert.Contains(saldo, tarjetas.Saldo);
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

        var mismaTarjeta = Ado.AltaTarjeta(Tarjeta);

        Assert.NotNull(mismaTarjeta);
        Assert.Equal(idTarjeta, mismaTarjeta.IdTarjeta);
        Assert.Equal(saldo, mismaTarjeta.Saldo);
    }
    [Fact]
    public void LlevarTarjeta(int idTarjeta, decimal saldo)
    {
        Ado.AltaTarjeta(tarjeta);

        Assert.NotNull(tarjeta);
        Assert.Equal(saldo, tarjeta.Saldo);
    }
}




//tengo que llevar tarjeta
//traer la lista de tarjetas
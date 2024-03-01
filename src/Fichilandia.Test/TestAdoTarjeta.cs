using Fichilandia.Core;
namespace Fichilandia.Test;
public class TestAdoTarjeta : TestAdo

{
    [Theory]
    [InlineData(321, 54321)]
    public void TraerTarjeta(int idTarjeta, uint dni)
    {
        var tarjetas = Ado.ObtenerTarjetas();

        Assert.NotEmpty(tarjetas);
        Assert.Contains(tarjetas, t => t.Dni == dni && t.IdTarjeta == idTarjeta);
    }

    [Fact]

    public void AltaTarjeta()
    {
        int idTarjeta = 2;
        uint dni = 12346;
        decimal saldo = 10;

        //esto es instanciar//
        var nueva02 = new Tarjeta()
        {
            IdTarjeta = idTarjeta,
            Dni = dni,
            Saldo = saldo
        };

        Ado.AltaTarjeta(nueva02);

        var tarjetas = Ado.ObtenerTarjetas();

        Assert.NotNull(tarjetas);
        Assert.Contains(tarjetas, t=>  t.Dni == dni && t.Saldo == saldo &&t.IdTarjeta== idTarjeta);
    }
}

// alta tarjeta y obtener tarjeta//
// Ayuda //
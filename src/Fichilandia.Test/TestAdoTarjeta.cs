using Fichilandia.Core;
namespace Fichilandia.Test;

public class TestAdoTarjeta : TestAdo

{
    [Theory]
    [InlineData(01, 10.50)]
    public void LlevarTarjeta(int idTarjeta, decimal saldo)
    {
        Ado.AltaTarjeta(Tarjeta);

        Assert.NotNull(tarjeta);
        Assert.Equal(saldo, tarjeta.Saldo);
    }

    [Theory]
    [InlineData(10, "NoExisto")]
    [InlineData(11, "yoTampoco")]
    public void TarjetasNoExisten(int idTarjeta, decimal saldo)
    {
        var tarjeta = Ado.CajeroPorPass(dni, pass);

        Assert.Null(cajero);
    }

    [Fact]

    public void AltaTarjeta()
    {
        int idTarjeta = 01;
        decimal saldo = 10.50;

        var nuevaTarjeta = new Tarjeta()
        {
            IdTarjeta = idTarjeta,
            Saldo = saldo
        };

        Ado.AltaTarjeta(nuevaTarjeta);

        var mismaTarjeta = Ado.AltaTarjeta(Tarjeta);

        Assert.NotNull(mismaTarjeta);
        Assert.Equal(idTarjeta, mismaTarjeta.IdTarjeta);
        Assert.Equal(saldo, mismaTarjeta.Saldo);
    }
}

////////////

    [Theory]
    [InlineData(100,"Pepe", "zapatos")]
    [InlineData(90,"Moni", "cafecito")]
    public void TraerCajero(uint dni, string nombre, string pass)
    {
        var cajero = Ado.CajeroPorPass(dni, pass);

        Assert.NotNull(cajero);
        Assert.Equal(nombre, cajero.Nombre);
        Assert.Equal<uint>(dni, cajero.Dni);
    }

    [Theory]
    [InlineData(10, "NoExisto")]
    [InlineData(11, "yoTampoco")]
    public void CajerosNoExisten(uint dni, string pass)
    {
        var cajero = Ado.CajeroPorPass(dni, pass);

        Assert.Null(cajero);
    }
    [Fact]









    public void TraerCliente(int dni, string nombre, string apellido)
    {
    // instanciar cliente (como si fuese un objeto?)
        Ado.AltaCliente(cliente);

        Assert.NotNull(cliente);
        Assert.Equal(nombre, cliente.Nombre);
        Assert.Equal<uint>(dni, cliente.DNI);
    }

    [Fact]

    public void AltaCliente()
    {
        int dni = 12345;
        string nombre = "nuevo";
        string apellido = "Terrazas";
        string mail = "@mail";

// esto es instanciar
        var terrazas = new Cliente()
        {
            DNI = dni,
            Nombre = nombre,
            Apellido = apellido,
            Mail = mail
        };

        Ado.AltaCliente(terrazas);

        var mismoCliente = Ado.AltaCliente(Cliente);

        Assert.NotNull(mismoCliente);
        Assert.Equal(nombre, mismoCliente.Nombre);
        Assert.Equal(apellido, mismoCliente.Apellido);
        Assert.Equal(mail, mismoCliente.Mail);
    }
}
// usar test ado cajero como ejemplo //





//tengo que llevar tarjeta
//traer la lista de tarjetas
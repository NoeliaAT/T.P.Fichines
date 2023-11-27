using Fichilandia.Core;
namespace Fichilandia.Test;

public class TestAdoCliente : TestAdo
{
    [Theory]
    [InlineData(12345, "Noelia", "Almaraz")] // poner numero de tarjeta y de DNI//

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
        uint dni = 12345;
        string nombre = "nuevo";
        string apellido = "Terrazas";
        string mail = "@mail";

        Ado.AltaCliente(cliente);

        Assert.Null(cliente);

        var nuevoTerrazas = new Cliente(dni, nombre, apellido, mail);

        Ado.AltaCliente(nuevoTerrazas);

        var mismoCliente = Ado.AltaCliente(Cliente);

        Assert.NotNull(mismoCliente);
        Assert.Equal(nombre, mismoCliente.Nombre);
        Assert.Equal(apellido, mismoCliente.Apellido);
        Assert.Equal(mail, mismoCliente.Mail);
    }
}
// usar test ado cajero como ejemplo //

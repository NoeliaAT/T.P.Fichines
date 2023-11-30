using Fichilandia.Core;
namespace Fichilandia.Test;

public class TestAdoCliente : TestAdo
{
    [Theory]
    [InlineData(12345, "Noelia", "Almaraz")] // poner numero de tarjeta y de DNI//

    public void TraerCliente(int dni, string nombre, string apellido)
    {
    // instanciar cliente (como si fuese un objeto?)
        var clientes = Ado.TraerCliente();

        Assert.NotNull(clientes);
        Assert.Contains(clientes, c => c.DNI == 12345 && c.Nombre == "Nombre" && c.Apellido == "Almaraz");
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


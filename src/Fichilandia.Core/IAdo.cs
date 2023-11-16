namespace Fichilandia.Core;

public interface IAdo
{
    void AltaFichin(Fichin fichin);
    List<Fichin> ObtenerFichines();
    void AltaRecarga(Recarga recarga);
    List<Recarga> ObtenerRecargas();
    void AltaCliente(Cliente cliente);
    List<Cliente> ObtenerClientes();
}
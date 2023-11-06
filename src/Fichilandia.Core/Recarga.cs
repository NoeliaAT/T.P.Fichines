using System.Dynamic;

namespace Fichilandia.Core;
public class Recarga
{

    public int IdRecarga { get; set; }
    public int DNI { get; set; }
    public int IdTarjeta { get; set; }
    public DateTime FechayHora { get; set; }
    public decimal MontoRecargado { get; set; }

    public Recarga (int idRecarga, int dni, int idTarjeta, DateTime fechayHora, decimal montoRecargado)
    {
        this.IdRecarga = idRecarga;
        this.DNI = dni;
        this.IdTarjeta = idTarjeta;
        this.FechayHora = fechayHora;
        this.MontoRecargado = montoRecargado;
    }
}

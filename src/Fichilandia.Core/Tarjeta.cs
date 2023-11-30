namespace Fichilandia.Core;
public class Tarjeta
{

    public int IdTarjeta { get; set; }
    public decimal Saldo { get; set; }

    public Tarjeta (int idTarjeta, decimal saldo)
    {
        this.IdTarjeta = idTarjeta;
        this.Saldo = saldo;
    }

    public Tarjeta()
    {
    }
}
namespace Fichilandia.Core;
public class JuegaFichin
{
    public int IdJuegaFichin { get; set; }
    public int DNI { get; set; }
    public int IdTarjeta { get; set; }
    public int IdFichin { get; set; }
    public DateTime FechayHora { get; set; }
    public decimal Gasto { get; set; }
    public JuegaFichin (int idJuegaFichin, int dni, int idTarjeta, int idFichin, DateTime fechayHora, decimal gasto)
    {
        this.IdJuegaFichin = idJuegaFichin;
        this.DNI = dni;
        this.IdTarjeta = idTarjeta;
        this.IdFichin = idFichin;
        this.FechayHora = fechayHora;
        this.Gasto = gasto;
    }
}

using System.Dynamic;

namespace Fichilandia.Core;
public class Fichin
{

    public int IdFichin { get; set; }
    public string Nombre { get; set; }
    public DateTime Lanzamiento { get; set; }
    public int Precio { get; set; }

    public Fichin (int idFichin, string nombre, DateTime lanzamiento, int precio)
    {
        this.IdFichin = idFichin;
        this.Nombre = nombre;
        this.Lanzamiento = lanzamiento;
        this.Precio = precio;
    }
}

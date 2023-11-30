namespace Fichilandia.Core;
public class Cliente
{

    public int DNI { get; set; }
    public string Nombre{ get; set; }
    public string Apellido { get; set; }
    public string Mail { get; set; }
    public Tarjeta Tarjeta { get; set; }
    public decimal saldo {get; set; }

// No esun tipo de dato primitivo (int) //

    public Cliente (int dni, string nombre, string apellido, string mail, Tarjeta tarjeta)
    {
        this.DNI = dni;
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.Mail = mail;
        this.Tarjeta = tarjeta;
    }

}

// la cliente le manda mensaje a la tarjeta //

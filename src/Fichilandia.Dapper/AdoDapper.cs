using System.Data;
using Dapper;
using MySqlConnector;
using Fichilandia.Core;

namespace Fichilandia.Dapper;
public class AdoDapper : IAdo
{

    private readonly IDbConnection _conexion;

    public AdoDapper(IDbConnection conexion) => this._conexion = conexion;

    //Este constructor usa por defecto la cadena para un conector MySQL
    public AdoDapper(string cadena) => _conexion = new MySqlConnection(cadena);


#region AltaCliente

    private static readonly string _queryAltaCliente
        = "SELECT------------ ";

    public void AltaCliente(Cliente cliente)
    {
        //Preparo los parametros del Stored Procedure
        var parametros = new DynamicParameters();
        parametros.Add("@unDNI", cliente.DNI);
        parametros.Add("@unnombre", cliente.Nombre);
        parametros.Add("@unapellido", cliente.Apellido);
        parametros.Add("@unMail", cliente.Mail);
        parametros.Add("@unatarjeta", cliente.Tarjeta);
        parametros.Add("@unsaldo", cliente.saldo);

        try
        {
            _conexion.Execute("registraCliente", parametros);

            //Obtengo el valor de parametro de tipo salida
            cliente.DNI = parametros.Get<byte>("unDNI");
        }
        catch (MySqlException e)
        {
            if (e.ErrorCode == MySqlErrorCode.DuplicateKeyEntry)
            {
                throw new ConstraintException(cliente.Nombre + " ya se encuentra en uso.");
            }
            throw;
        }
    }
}

#endregion

#region AltaFichin

    private static readonly string _queryAltaFichin
        = "SELECT------------ ";

    public void AltaFichin(Fichin fichin)
    {
        //preparo los parametros del Stored Procedure
        var parametros = new DynamicParameters();
        parametros.Add("@unidFichin",fichin.IdFichin);
        parametros.Add("@unNombre", fichin.Nombre);
        parametros.Add("@unLanzamiento", fichin.Lanzamiento);
        parametros.Add("@unPrecio", fichin.Precio);

        try
        {
            _conexion.Execute("altaFichin", parametros);

            //Obtengo el valor de parametro de tipo salida
            fichin.IdFichin = parametros.Get<byte>("unidFichin");
        }
        catch (MySqlException e)
        {
            if (e.ErrorCode == MySqlErrorCode.DuplicateKeyEntry)
            {
                throw new ConstraintException(fichin.Nombre + "ya se encuentra en uso.");
            }
        }
    }



#endregion

#region AltaRecarga

    private static readonly string _queryAltaRecarga
        = "SELECT------------ ";


    public void AltaRecarga(Recarga recarga)
    {
        //preparo los parametros del Stored Procedure
        var parametros = new DynamicParameters();
        parametros.Add("@unDNI", recarga.DNI);
        parametros.Add("@unaFechayHora", recarga.FechayHora);
        parametros.Add("@unMontoRecargado", recarga.MontoRecargado);

        try
        {
            _conexion.Execute("altaRecarga", parametros);

            // Obtengo el valor de parametro de tipo salida
            recarga.DNI = parametros.Get<byte>("unDNI");
        }

        catch (MySqlException e)
        {
            if (e.ErrorCode == MySqlErrorCode.DuplicateKeyEntry)
            {
                throw new ConstraintException(recarga.FechayHora + "ya se encuentra en uso");
            }
        }
    }

#endregion
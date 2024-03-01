using Fichilandia.Core;
using Fichilandia.Dapper;

namespace Fichilandia.Test;
/// <summary>
/// El objetivo de esta clase es brindar una instancia de Ado para los test
/// </summary>
public class TestAdo
{
    protected readonly IAdo Ado;
    private const string _cadena = "Server=localhost;Database=5to_Fichines;Uid=root;pwd=root;Allow User Variables=True";
    public TestAdo() => Ado = new AdoDapper(_cadena);
    public TestAdo(string cadena) => Ado = new AdoDapper(cadena);
}

using System.Data.SqlClient;
using Newtonsoft.Json;

public class DatabaseService
{
    private readonly string _connectionString;

    public DatabaseService(string connectionString)
    {
        _connectionString = connectionString;
    }

    public void InsertDeclaracion(string numeroTransaccion, DateTime fechaHoraTrn, DateTime fechaAConsultar, int cuentaDeclaraciones, string datosComprimidos)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            connection.Open();
            var command = new SqlCommand("INSERT INTO Declaraciones (NumeroTransaccion, FechaHoraTrn, FechaAConsultar, CuentaDeclaraciones, DatosComprimidos) VALUES (@NumeroTransaccion, @FechaHoraTrn, @FechaAConsultar, @CuentaDeclaraciones, @DatosComprimidos)", connection);
            command.Parameters.AddWithValue("@NumeroTransaccion", numeroTransaccion);
            command.Parameters.AddWithValue("@FechaHoraTrn", fechaHoraTrn);
            command.Parameters.AddWithValue("@FechaAConsultar", fechaAConsultar);
            command.Parameters.AddWithValue("@CuentaDeclaraciones", cuentaDeclaraciones);
            command.Parameters.AddWithValue("@DatosComprimidos", datosComprimidos);
            command.ExecuteNonQuery();
        }
    }
}

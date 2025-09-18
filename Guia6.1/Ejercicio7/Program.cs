using Microsoft.Data.SqlClient;

namespace Ejercicio7
{
    internal class Program
    {
        async static Task Main(string[] args)
        {
            string query = "sp_CalcularAreas";

            string stringConnection = "Data Source=DESKTOP-TEDVE8G;Initial Catalog=Guia6_1Ejercicio1_db;Integrated Security=True;Pooling=False;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Name=vscode-mssql;Connect Retry Count=1;Connect Retry Interval=10;Command Timeout=30";

            try
            {
                using SqlConnection conn = new SqlConnection(stringConnection);
                await conn.OpenAsync();

                using SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                await cmd.ExecuteNonQueryAsync();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
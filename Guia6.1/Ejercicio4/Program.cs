using Microsoft.Data.SqlClient;

namespace Ejercicio4
{
    internal class Program
    {
        
        async static Task Main(string[] args)
        {
            
            int? tipo = 1;
            double? ancho = 23;
            double? largo = 12;

            double? area = 0;
            double? radio = 0;
            #region simulo la actualización - ejemplo calculando el area.
            if (tipo == 1)
                area = ancho * largo;
            else if (tipo == 2)
                area = Math.PI * Math.Pow(radio ?? 0, 2);
            #endregion

            string query = @"
INSERT INTO Figuras (Tipo, Ancho, Largo, Radio)
OUTPUT INSERTED.Id
VALUES
(@Tipo, @Ancho, @Largo, @Radio)
";

            string stringConnection = "Data Source=DESKTOP-TEDVE8G;Initial Catalog=Guia6_1Ejercicio1_db;Integrated Security=True;Pooling=False;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Name=vscode-mssql;Connect Retry Count=1;Connect Retry Interval=10;Command Timeout=30";

            try
            {
                using SqlConnection conn = new SqlConnection(stringConnection);
                await conn.OpenAsync();

                using SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Tipo", tipo);
                cmd.Parameters.AddWithValue("@Ancho", ancho);
                cmd.Parameters.AddWithValue("@Largo", largo);
                cmd.Parameters.AddWithValue("@Radio", largo);

                object idObject = await cmd.ExecuteScalarAsync();

                Console.WriteLine($"Id Figura insertada: {Convert.ToInt32(idObject)}");
                Console.WriteLine($"{"Id",10}|{"Tipo",10}|{"Area",10}|{"Ancho",10}|{"Largo",10}|{"Radio",10}");
                Console.WriteLine($"{idObject,10}|{1,10}|{area,10}|{ancho,10}|{largo,10}|{radio,10}");
                
               
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex}");
            }
        }

    }
}

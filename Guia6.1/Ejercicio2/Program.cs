using Microsoft.Data.SqlClient;
namespace Ejercicio2
{
    internal class Program
    {
        //Task me permite usar la palabra reservada "await"
        // async para que la conexion sea asincrona
        async static Task Main(string[] args)
        {
            //Consulta que realizo
            string query = @"SELECT f.Id,
		Tipo = CASE WHEN f.Tipo = 1 THEN 'Rectangulo'
			 WHEN f.Tipo = 2 THEN 'Circulo'
			 ELSE 'No identificado'
			 END,
	   f.Area,
	   f.Ancho,
	   f.Largo,
	   f.Radio
FROM Figuras f
ORDER BY f.Id";

            //Cadena de conexion -VER nombre de la base de datos y servidor.
            string stringConnection = "Data Source=DESKTOP-KSDEE1M;Initial Catalog=Guia6_1Ejercicio1_db;Integrated Security=True;Pooling=False;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Name=vscode-mssql;Connect Retry Count=1;Connect Retry Interval=10;Command Timeout=30";

            //Creo la conexion
            SqlConnection conn = new SqlConnection(stringConnection);
            //Abre la conexion //asíncrono - el await espera a que termine.
            await conn.OpenAsync();
            //Creo un comando con la consulta y la conexion.
            using SqlCommand cmd = new SqlCommand(query, conn); 

            using SqlDataReader dataReader = await cmd.ExecuteReaderAsync();

            Console.WriteLine($"{"Id",10}|{"Tipo",10}|{"Area",10}|{"Ancho",10}|{"Largo",10}|{"Radio",10}");
            while (await dataReader.ReadAsync())
            {
                int id = dataReader["Id"] != DBNull.Value ? Convert.ToInt32(dataReader["Id"]) : 0;

                string? tipo = dataReader["Tipo"] != DBNull.Value ? Convert.ToString(dataReader["Tipo"]) : null;
                double? area = Convert.ToInt32(dataReader["Area"] != DBNull.Value ? dataReader["Area"] : null);
                double? ancho = Convert.ToInt32(dataReader["Ancho"] != DBNull.Value ? dataReader["Ancho"] : null);
                double? largo = Convert.ToInt32(dataReader["Largo"] != DBNull.Value ? dataReader["Largo"] : null);
                double? radio = Convert.ToInt32(dataReader["Radio"] != DBNull.Value ? dataReader["Radio"] : null);

                Console.WriteLine($"{id,10}|{tipo,10}|{area,10:f2}|{ancho,10:f2}|{largo,10:f2}|{radio,10:f2}");
            }

            await conn.CloseAsync();
        }
    }
    
}

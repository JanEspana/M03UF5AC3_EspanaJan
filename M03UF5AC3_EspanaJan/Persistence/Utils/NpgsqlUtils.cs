using Microsoft.Extensions.Configuration;
using Npgsql;
using M03UF5AC3_EspanaJan.DTOs;

namespace M03UF5AC3_EspanaJan.Persistence.Utils
{
    public class NpgsqlUtils
    {
        public static string OpenConnection()
        {
            //ruta absoluta
            string path;
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile(path, optional: false, reloadOnChange: true)
                .Build();

            return config.GetConnectionString("MyPostgresConn");
        }

        public static ConsumDTO GetConsum(NpgsqlDataReader reader)
        {
            ConsumDTO c = new ConsumDTO
            {
                Any = reader.GetInt32(0),
                CodiComarca = reader.GetInt32(1),
                Comarca = reader.GetString(2),
                Poblacio = reader.GetInt32(3),
                DomesticXarxa = reader.GetDouble(4),
                ActivitatsEconomiquesIFontsPropies = reader.GetDouble(5),
                Total = reader.GetDouble(6),
                ConsumDomesticPerCapita = reader.GetDouble(7)
            };
            return c;
        }
    }
}

using M03UF5AC3_EspanaJan.DTOs;
using M03UF5AC3_EspanaJan.Persistence.DAO;
using Npgsql;
using M03UF5AC3_EspanaJan.Persistence.Utils;

namespace M03UF5AC3_EspanaJan.Persistence.Mapping
{
    public class ConsumDAO : IConsumDAO
    {
        private readonly string connectionString;
        public ConsumDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public List<ConsumDTO> GetAllConsum()
        {
            List<ConsumDTO> consums = new List<ConsumDTO>();
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                string query = "SELECT * FROM consum";
                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                conn.Open();
                NpgsqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ConsumDTO consum = NpgsqlUtils.GetConsum(reader);
                    consums.Add(consum);
                }
            }
            return consums;
        }
        public void AddConsum(ConsumDTO consum)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                string query = "INSERT INTO consum VALUES (@Any, @CodiComarca, @Comarca, @Poblacio, @DomesticXarxa, @ActivitatsEconomiquesIFontsPropies, @Total, @ConsumDomesticPerCapita)";
                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Any", consum.Any);
                cmd.Parameters.AddWithValue("@CodiComarca", consum.CodiComarca);
                cmd.Parameters.AddWithValue("@Comarca", consum.Comarca);
                cmd.Parameters.AddWithValue("@Poblacio", consum.Poblacio);
                cmd.Parameters.AddWithValue("@DomesticXarxa", consum.DomesticXarxa);
                cmd.Parameters.AddWithValue("@ActivitatsEconomiquesIFontsPropies", consum.ActivitatsEconomiquesIFontsPropies);
                cmd.Parameters.AddWithValue("@Total", consum.Total);
                cmd.Parameters.AddWithValue("@ConsumDomesticPerCapita", consum.ConsumDomesticPerCapita);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}

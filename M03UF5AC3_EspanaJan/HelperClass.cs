using CsvHelper;
using CsvHelper.Configuration;
using M03UF5AC3_EspanaJan.DTOs;
using System.Globalization;
using System.Xml.Linq;
namespace M03UF5AC3_EspanaJan
{
    public class HelperClass
    {
        public static List<ConsumDTO> ReadCsv()
        {
            //read csv file
            using var reader = new StreamReader(@"../../../Consum_d_aigua_a_Catalunya_per_comarques_20240402.csv");
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            var records = csv.GetRecords<ConsumDTO>().ToList();
            return records;
        }
        public static List<string> ReadXml()
        {
            XDocument doc = XDocument.Load(@"../../../ConsumAiguaCatalunya.xml");
            var query = from c in doc.Descendants("Comarca")
                        select c.Value;
            return query.ToList();
        }
        public static void CreateTable(DataGridView grid)
        {
            grid.DataSource = ReadCsv();
        }
        public static void Append(ConsumDTO consum)
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = false,
            };
            using var stream = File.Open(@"../../../Consum_d_aigua_a_Catalunya_per_comarques_20240402.csv", FileMode.Append);
            using var writer = new StreamWriter(stream);
            using var csv = new CsvWriter(writer, config);
            var records = new List<ConsumDTO> { consum };
            csv.WriteRecords(records);
        }
    }
}

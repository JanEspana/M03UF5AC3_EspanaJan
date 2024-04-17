using System.Text.RegularExpressions;
using System.Windows.Forms;
using M03UF5AC3_EspanaJan.Persistence.Utils;
using M03UF5AC3_EspanaJan.Persistence.Mapping;
using M03UF5AC3_EspanaJan.Persistence.DAO;
using M03UF5AC3_EspanaJan.DTOs;

namespace M03UF5AC3_EspanaJan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var csv = HelperClass.ReadCsv();
            var lastRow = csv.Last();
            int lastYear = lastRow.Any;
            HelperClass.CreateTable(grid);
            for (int i = lastYear; i <= 2050; i++)
            {
                year.Items.Add(i);
            }
            var xml = HelperClass.ReadXml();
            foreach (var item in xml)
            {
                if (!comarca.Items.Contains(item))
                {
                    comarca.Items.Add(item);
                }
            }
        }
        private void clean_Click(object sender, EventArgs e)
        {
            //reset form
            year.Text = "";
            comarca.Text = "";
            population.Text = "";
            consumDomestic.Text = "";
            domesticXarxa.Text = "";
            activitats.Text = "";
            total.Text = "";
        }

        private void year_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void saveEntry_Click(object sender, EventArgs e)
        {
            Regex digitos = new Regex(@"^\d+$");
            Regex decimales = new Regex(@"^\d+(\.\d{2})?$|^\d+$");
            if (!comarca.Items.Contains(comarca.Text) || !year.Items.Contains(int.Parse(year.Text)) || !digitos.IsMatch(population.Text) || !digitos.IsMatch(population.Text) || !digitos.IsMatch(domesticXarxa.Text) || !digitos.IsMatch(activitats.Text) || !digitos.IsMatch(total.Text) || !decimales.IsMatch(consumDomestic.Text))
            {
                if (!digitos.IsMatch(population.Text) || population.Text == "")
                {
                    errorPoblacio.SetError(population, "Debe ser un numero mayor a 0 sin decimales");
                }
                if (!digitos.IsMatch(domesticXarxa.Text) || domesticXarxa.Text == "")
                {
                    errorXarxa.SetError(domesticXarxa, "Debe ser un numero mayor a 0 sin decimales");
                }
                if (!digitos.IsMatch(activitats.Text) || activitats.Text == "")
                {
                    errorActivitats.SetError(activitats, "Debe ser un numero mayor a 0 sin decimales");
                }
                if (!digitos.IsMatch(total.Text) || total.Text == "")
                {
                    errorTotal.SetError(total, "Debe ser un numero mayor a 0 sin decimales");
                }
                if (!decimales.IsMatch(consumDomestic.Text) || consumDomestic.Text == "")
                {
                    errorConsumCapita.SetError(consumDomestic, "Debe ser un numero mayor a 0 i como màximo con 2 decimales");
                }
                if (!comarca.Contains(comarca) || comarca.Text == "")
                {
                    errorComarca.SetError(comarca, "Debe seleccionar una comarca");
                }
                if (!year.Contains(year) || year.Text == "")
                {
                    errorAny.SetError(year, "Debe seleccionar un año");
                }
            }
            else
            {
                errorAny.Clear();
                errorActivitats.Clear();
                errorComarca.Clear();
                errorConsumCapita.Clear();
                errorPoblacio.Clear();
                errorTotal.Clear();
                errorXarxa.Clear();

                ConsumDTO consum = new ConsumDTO();
                consum.Any = int.Parse(year.Text);
                consum.CodiComarca = comarca.SelectedIndex;
                consum.Comarca = comarca.Text;
                consum.Poblacio = int.Parse(population.Text);
                consum.DomesticXarxa = double.Parse(domesticXarxa.Text);
                consum.ActivitatsEconomiquesIFontsPropies = double.Parse(activitats.Text);
                consum.Total = double.Parse(total.Text);
                consum.ConsumDomesticPerCapita = double.Parse(consumDomestic.Text);
                HelperClass.Append(consum);
                HelperClass.CreateTable(grid);
            }
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if cell is not header
            if (e.RowIndex != -1)
            {
                if (grid.Rows[e.RowIndex].Cells["Poblacio"].Value != null)
                {
                    if (int.Parse(grid.Rows[e.RowIndex].Cells["Poblacio"].Value.ToString()) > 20000)
                    {
                        morethan20000.Text = "True";
                    }
                    else
                    {
                        morethan20000.Text = "False";
                    }
                }
                double sum = 0;
                int rowCount = 0;
                for (int i = 0; i < grid.Rows.Count; i++)
                {
                    if (grid.Rows[i].Cells["Comarca"].Value.ToString() == grid.Rows[e.RowIndex].Cells["Comarca"].Value.ToString())
                    {
                        sum += double.Parse(grid.Rows[i].Cells["ConsumDomesticPerCapita"].Value.ToString());
                        rowCount++;
                    }
                }
                avgConsum.Text = Math.Round((sum / rowCount), 2).ToString();
                double highest = 0;
                for (int i = 0; i < grid.Rows.Count; i++)
                {
                    if (grid.Rows[i].Cells["Comarca"].Value.ToString() == grid.Rows[e.RowIndex].Cells["Comarca"].Value.ToString())
                    {
                        if (double.Parse(grid.Rows[i].Cells["ConsumDomesticPerCapita"].Value.ToString()) > highest)
                        {
                            highest = double.Parse(grid.Rows[i].Cells["ConsumDomesticPerCapita"].Value.ToString());
                        }
                    }
                }
                if (double.Parse(grid.Rows[e.RowIndex].Cells["ConsumDomesticPerCapita"].Value.ToString()) == highest)
                {
                    higherCons.Text = "True";
                }
                else
                {
                    higherCons.Text = "False";
                }
                double lowest = 1000000;
                for (int i = 0; i < grid.Rows.Count; i++)
                {
                    if (grid.Rows[i].Cells["Comarca"].Value.ToString() == grid.Rows[e.RowIndex].Cells["Comarca"].Value.ToString())
                    {
                        if (double.Parse(grid.Rows[i].Cells["ConsumDomesticPerCapita"].Value.ToString()) < lowest)
                        {
                            lowest = double.Parse(grid.Rows[i].Cells["ConsumDomesticPerCapita"].Value.ToString());
                        }
                    }
                }
                if (double.Parse(grid.Rows[e.RowIndex].Cells["ConsumDomesticPerCapita"].Value.ToString()) == lowest)
                {
                    lowerCons.Text = "True";
                }
                else
                {
                    lowerCons.Text = "False";
                }
            }
        }

        private void persistButton_Click(object sender, EventArgs e)
        {
            //saves data to database
            var connectionString = NpgsqlUtils.OpenConnection();
            ConsumDAO consumDAO = new ConsumDAO(connectionString);
            var consums = HelperClass.ReadCsv();
            foreach (var consum in consums)
            {
                consumDAO.AddConsum(consum);
            }
            HelperClass.CreateTable(grid);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
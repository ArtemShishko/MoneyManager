using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using LiveCharts;
using LiveCharts.Wpf;

namespace qq
{
    /// <summary>
    /// Interaction logic for UserControlChar.xaml
    /// </summary>
    public partial class UserControlChar : UserControl
    {
        SqlConnection connection = new SqlConnection(@"Data Source=NOTEPAD\SQLEXPRESS; Initial catalog=manager; Integrated security=True;");
        public SeriesCollection SeriesCollection { get; set; }
        public UserControlChar()
        {
            InitializeComponent();

            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Transactions WHERE Username = (SELECT Username FROM SelectedUser WHERE Username = Username) AND Type = 'Expense'", connection);
            SqlCommand comm = new SqlCommand("SELECT * FROM Transactions WHERE Username = (SELECT Username FROM SelectedUser WHERE Username = Username) AND Type = 'Income'", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            SqlDataAdapter data = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            DataTable dataTable = new DataTable();
            data.Fill(dataTable);
            adapter.Fill(dt);
            Func<ChartPoint, string> labelPoint = chartPoint =>
            string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            ChartValues<double> cht_y_values = new ChartValues<double>();

            LiveCharts.SeriesCollection series = new LiveCharts.SeriesCollection();

            foreach (DataRow dr in dt.Rows)
            {
                PieSeries ps = new PieSeries
                {
                    Title = dr["Category"].ToString(),
                    Values = new ChartValues<double> {
                                double.Parse(dr["Amount"].ToString())},
                    DataLabels = true,
                    LabelPoint = labelPoint,
                };
                series.Add(ps);
            }
            chart.Series = series;
            chart.LegendLocation = LegendLocation.Right;
            chart.ChartLegend.Foreground = Brushes.WhiteSmoke;

            ChartValues<double> values = new ChartValues<double>();

            LiveCharts.SeriesCollection ser = new LiveCharts.SeriesCollection();

            foreach (DataRow dr in dataTable.Rows)
            {
                PieSeries ps = new PieSeries
                {
                    Title = dr["Category"].ToString(),
                    Values = new ChartValues<double> {
                                double.Parse(dr["Amount"].ToString())},
                    DataLabels = true,
                    LabelPoint = labelPoint,
                };
                ser.Add(ps);
            }
            chartExpense.Series = ser;
            chartExpense.LegendLocation = LegendLocation.Right;
            chartExpense.ChartLegend.Foreground = Brushes.WhiteSmoke;
        }
    }
}

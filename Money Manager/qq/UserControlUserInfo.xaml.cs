using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace qq
{
    /// <summary>
    /// Interaction logic for UserControlUserInfo.xaml
    /// </summary>
    public partial class UserControlUserInfo : UserControl
    {
        SqlConnection connection = new SqlConnection(@"Data Source=NOTEPAD\SQLEXPRESS; Initial catalog=manager; Integrated security=True;");
        public UserControlUserInfo()
        {
            InitializeComponent();
            using (connection)
            {
                SqlCommand command = new SqlCommand("SELECT SUM([Amount]) FROM Transactions WHERE Type = 'Expense' AND Username = (SELECT Username FROM SelectedUser WHERE Username = Username)", connection);
                SqlCommand comm = new SqlCommand("SELECT SUM([Amount]) FROM Transactions WHERE Type = 'Income' AND Username = (SELECT Username FROM SelectedUser WHERE Username = Username)", connection);
                SqlCommand user = new SqlCommand("SELECT Username FROM SelectedUser", connection);
                SqlCommand balance = new SqlCommand("SELECT (MainWallet + OtherWallet) FROM Users WHERE Username = (SELECT Username FROM SelectedUser WHERE Username = Username)", connection);
                connection.Open();
                object sumExpense = command.ExecuteScalar();
                txtAmountOfExpenses.Text = sumExpense.ToString();
                object sumIncome = comm.ExecuteScalar();
                txtAmountOfIncome.Text = sumIncome.ToString();
                object username = user.ExecuteScalar();
                txtUsername.Text = username.ToString();
                object userBalance = balance.ExecuteScalar();
                txtBalance.Text = userBalance.ToString();
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            gridHome.Children.Clear();
            gridHome.Children.Add(new UserControlHome());
        }
    }
}

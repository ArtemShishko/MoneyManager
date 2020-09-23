using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for UserControlLogin.xaml
    /// </summary>
    public partial class UserControlLogin : UserControl
    {
        public UserControlLogin()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            if (Username.Text == "" || Password.Password == "")
            {
                lb.Content = "Enter all strings";
            }
            else
            {
                SqlConnection connection = new SqlConnection(@"Data Source=localhost\MSSQLSERVER02; Initial catalog=manager; Integrated security=True;");
                string query = "SELECT * FROM Users WHERE Username = '"+ Username.Text +"' AND Password = '"+ Password.Password +"'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                if (table.Rows.Count == 1)
                {
                    string queryEtc = "INSERT INTO [dbo].[SelectedUser] ([Username]) VALUES ('"+Username.Text+"') ";
                    SqlDataAdapter sql = new SqlDataAdapter(queryEtc, connection);
                    DataTable dataTable = new DataTable();
                    sql.Fill(dataTable);
                    MainWindow main = new MainWindow();
                    main.Show();
                    main.txtUsername.Text = Username.Text;
                    Window.GetWindow(this).Close();
                }
                else
                {
                    lb.Content = "Incorrect username or password";
                }
            }
        }
    }
}

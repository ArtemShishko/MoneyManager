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
    public partial class UserControlReg : UserControl
    {
        public UserControlReg()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Password == "" || txtPasswordConfirm.Password == "")
            {
                lb.Content = "All fields must be filled";
                
            }
            else
            {
                if (txtPassword.Password == txtPasswordConfirm.Password)
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=NOTEPAD\SQLEXPRESS; Initial catalog=manager; Integrated security=True;");
                    SqlCommand command = new SqlCommand(@"INSERT INTO[dbo].[Users]([Username], [Password]) VALUES ('" + txtUsername.Text + "', '" + txtPassword.Password + "')", connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    gridHome.Children.Clear();
                    gridHome.Children.Add(new UserControlLogin());
                }
                else
                {
                    lb.Content = "Passwords do not match";
                }
            }
        }
    }
}

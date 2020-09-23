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
    /// Interaction logic for UserControlWallet.xaml
    /// </summary>
    public partial class UserControlWallet : UserControl
    {
        SqlConnection connection = new SqlConnection(@"Data Source=NOTEPAD\SQLEXPRESS; Initial catalog=manager; Integrated security=True;");
        public UserControlWallet()
        {
            InitializeComponent();

            using (connection)
            {
                SqlCommand user = new SqlCommand("SELECT MainWallet FROM Users WHERE Username = (SELECT Username FROM SelectedUser WHERE Username = Username)", connection);
                SqlCommand comm = new SqlCommand("SELECT OtherWallet FROM Users WHERE Username = (SELECT Username FROM SelectedUser WHERE Username = Username)", connection);
                connection.Open();
                object main = user.ExecuteScalar();
                txtBalance.Text = main.ToString();
                object other = comm.ExecuteScalar();
                txtOtherBalance.Text = other.ToString();
            }
        }

        private void lvEdit_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = lvEdit.SelectedIndex;
            switch (index)
            {
                case 0:
                    SqlConnection connection = new SqlConnection(@"Data Source=NOTEPAD\SQLEXPRESS; Initial catalog=manager; Integrated security=True;");
                    SqlCommand edit = new SqlCommand("UPDATE Users SET MainWallet = '"+ txtBalance.Text +"' WHERE Username = (SELECT Username FROM SelectedUser WHERE Username = Username)", connection);
                    connection.Open();
                    edit.ExecuteNonQuery();
                    connection.Close();
                    txtBalance.IsReadOnly = true;
                    break;
                case 1:
                    txtBalance.IsReadOnly = false;
                    break;
                default:
                    break;
            }
        }

        private void otherEdit_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = lvEdit.SelectedIndex;
            switch (index)
            {
                case 0:
                    SqlConnection connection = new SqlConnection(@"Data Source=NOTEPAD\SQLEXPRESS; Initial catalog=manager; Integrated security=True;");
                    SqlCommand edit = new SqlCommand("UPDATE Users SET OtherWallet = '" + txtOtherBalance.Text + "' WHERE Username = (SELECT Username FROM SelectedUser WHERE Username = Username)", connection);
                    connection.Open();
                    edit.ExecuteNonQuery();
                    connection.Close();
                    txtOtherBalance.IsReadOnly = true;
                    break;
                case 1:
                    txtOtherBalance.IsReadOnly = false;
                    break;
                default:
                    break;
            }
        }
    }
}

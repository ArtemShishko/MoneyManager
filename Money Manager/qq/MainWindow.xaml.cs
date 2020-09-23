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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection connection = new SqlConnection(@"Data Source=NOTEPAD\SQLEXPRESS; Initial catalog=manager; Integrated security=True;");

        public MainWindow()
        {
            InitializeComponent();

            gridHome.Children.Clear();
            gridHome.Children.Add(new UserControlHome());
        }

        private void buttonClose_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string sql = string.Format("DELETE from SelectedUser WHERE Username = Username");
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            Application.Current.Shutdown();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void LoadPageList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = LoadPageList.SelectedIndex;
            switch (index)
            {
                case 0:
                    gridHome.Children.Clear();
                    gridHome.Children.Add(new UserControlHome());
                    break;
                case 1:
                    gridHome.Children.Clear();
                    gridHome.Children.Add(new UserControlChar());
                    break;
                case 2:
                    gridHome.Children.Clear();
                    gridHome.Children.Add(new UserControlWallet());
                    break;
                default:
                    break;
            }
        }

        private void btnHelp_Click(object sender, RoutedEventArgs e)
        {
            gridHome.Children.Clear();
            gridHome.Children.Add(new UserControlHelp());
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            string sql = string.Format("DELETE from SelectedUser WHERE Username = Username");
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            loginWindow.Show();
            Window.GetWindow(this).Close();
        }

        private void btnAccount_Click(object sender, RoutedEventArgs e)
        {
            gridHome.Children.Clear();
            gridHome.Children.Add(new UserControlUserInfo());
        }
    }
}

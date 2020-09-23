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
using System.Windows.Shapes;

namespace qq
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();

            gridHome.Children.Clear();
            gridHome.Children.Add(new UserControlLogin());
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            gridHome.Children.Clear();
            gridHome.Children.Add(new UserControlLogin());
        }

        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            gridHome.Children.Clear();
            gridHome.Children.Add(new UserControlReg());
        }
    }
}

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

namespace qq
{
    public partial class UserControlHelp : UserControl
    {
        public UserControlHelp()
        {
            InitializeComponent();

            gridExtra.Children.Clear();
            gridExtra.Children.Add(new UserControlHelpAboutHome());
        }

        private void lvHelp_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = lvHelp.SelectedIndex;
            switch (index)
            {
                case 0:
                    gridExtra.Children.Clear();
                    gridExtra.Children.Add(new UserControlHelpAboutHome());
                    break;
                case 1:
                    gridExtra.Children.Clear();
                    gridExtra.Children.Add(new UserControlHelpAboutChart());
                    break;
                case 2:
                    gridExtra.Children.Clear();
                    gridExtra.Children.Add(new UserControlHelpAboutWallet());
                    break;
                default:
                    break;
            }
        }
    }
}

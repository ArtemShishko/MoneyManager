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
    /// Interaction logic for UserControlAddTransaction.xaml
    /// </summary>
    public partial class UserControlAddTransaction : UserControl
    {
        SqlConnection connection = new SqlConnection(@"Data Source=NOTEPAD\SQLEXPRESS; Initial catalog=manager; Integrated security=True;");
        public UserControlAddTransaction()
        {
            InitializeComponent();
        }

        private void btnChangeToExpense_Click(object sender, RoutedEventArgs e)
        {

            btnSave.Content = "Save an expense";

            int index = int.Parse(((Button)e.Source).Uid);
            GridCursor.Margin = new Thickness(0 + (400 * index), 0, 0, 0);
        }

        private void btnChangeToIncome_Click(object sender, RoutedEventArgs e)
        {
            btnSave.Content = "Save an income";
           

            int index = int.Parse(((Button)e.Source).Uid);
            GridCursor.Margin = new Thickness(0 + (400 * index), 0, 0, 0);
        }

        private void SaveAnExpense_Click(object sender, RoutedEventArgs e)
        {
            if (btnSave.Content.ToString() == "Save an income")
            {
                if (txtCount.Text == "" || txtCategory.Text == "" || txtDate.Text == "" || txtWallet.Text == "" || Time.Text == "")
                {
                    lb.Content = "All fields must be filled";
                }
                else
                {
                    if (txtWallet.Text == "Main")
                    {
                        SqlCommand command = new SqlCommand(@"INSERT INTO[dbo].[Transactions]([Type], [Amount], [Date], [Time], [Category], [Wallet], [Username]) VALUES ('Income', '" + txtCount.Text + "', '" + txtDate.SelectedDate + "', '" + Time.SelectedTime + "', '" + txtCategory.Text + "', '" + txtWallet.Text + "', (SELECT Username FROM SelectedUser WHERE Username = Username)) UPDATE Users SET MainWallet = MainWallet + '" + txtCount.Text + "' WHERE Username = (SELECT Username FROM SelectedUser WHERE Username = Username)", connection);
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }

                    if (txtWallet.Text == "Other")
                    {
                        SqlCommand command = new SqlCommand(@"INSERT INTO[dbo].[Transactions]([Type], [Amount], [Date], [Time], [Category], [Wallet], [Username]) VALUES ('Income', '" + txtCount.Text + "', '" + txtDate.SelectedDate + "', '" + Time.SelectedTime + "', '" + txtCategory.Text + "', '" + txtWallet.Text + "', (SELECT Username FROM SelectedUser WHERE Username = Username)) UPDATE Users SET OtherWallet = OtherWallet + '" + txtCount.Text + "' WHERE Username = (SELECT Username FROM SelectedUser WHERE Username = Username)", connection);
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }

                    gridHome.Children.Clear();
                    gridHome.Children.Add(new UserControlHome());
                }
            }

            if (btnSave.Content.ToString() == "Save an expense")
            {
                if (txtCount.Text == "" || txtCategory.Text == "" || txtDate.Text == "" || txtWallet.Text == "" || Time.Text == "")
                {
                    lb.Content = "All fields must be filled";
                }
                else
                {
                    if (txtWallet.Text == "Main")
                    {
                        SqlCommand command = new SqlCommand(@"INSERT INTO[dbo].[Transactions]([Type], [Amount], [Date], [Time], [Category], [Wallet], [Username]) VALUES ('Expense', '" + txtCount.Text + "', '" + txtDate.SelectedDate + "', '" + Time.SelectedTime + "', '" + txtCategory.Text + "', '" + txtWallet.Text + "', (SELECT Username FROM SelectedUser WHERE Username = Username)) UPDATE Users SET MainWallet = MainWallet - '" + txtCount.Text + "' WHERE Username = (SELECT Username FROM SelectedUser WHERE Username = Username)", connection);
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }

                    if (txtWallet.Text == "Other")
                    {
                        SqlCommand command = new SqlCommand(@"INSERT INTO[dbo].[Transactions]([Type], [Amount], [Date], [Time], [Category], [Wallet], [Username]) VALUES ('Expense', '" + txtCount.Text + "', '" + txtDate.SelectedDate + "', '" + Time.SelectedTime + "', '" + txtCategory.Text + "', '" + txtWallet.Text + "', (SELECT Username FROM SelectedUser WHERE Username = Username)) UPDATE Users SET OtherWallet = OtherWallet - '" + txtCount.Text + "' WHERE Username = (SELECT Username FROM SelectedUser WHERE Username = Username)", connection);
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }

                    gridHome.Children.Clear();
                    gridHome.Children.Add(new UserControlHome());
                }
            }
        }
    }
}

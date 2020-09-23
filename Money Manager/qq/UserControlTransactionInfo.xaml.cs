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
    public partial class UserControlTransactionInfo : UserControl
    {
        SqlConnection connection = new SqlConnection(@"Data Source=NOTEPAD\SQLEXPRESS; Initial catalog=manager; Integrated security=True;");
        public UserControlTransactionInfo()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            gridHome.Children.Clear();
            gridHome.Children.Add(new UserControlHome());
        }

        private void lstChange_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            stackpanel.IsEnabled = true;
            btnSave.Visibility = Visibility.Visible;

            if (txtWallet.Text == "Main")
            {
                SqlCommand back = new SqlCommand("UPDATE Users SET MainWallet = MainWallet + '" + txtCount.Text + "' WHERE Username = (SELECT Username FROM SelectedUser WHERE Username = Username)", connection);
                connection.Open();
                back.ExecuteNonQuery();
                connection.Close();
            }

            if (txtWallet.Text == "Other")
            {
                SqlCommand back = new SqlCommand("UPDATE Users SET OtherWallet = OtherWallet + '" + txtCount.Text + "' WHERE Username = (SELECT Username FROM SelectedUser WHERE Username = Username)", connection);
                connection.Open();
                back.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (txtType.Text == "Expense")
            {
                if (txtWallet.Text == "Main")
                {
                    SqlCommand command = new SqlCommand(@"UPDATE Transactions SET Type = @Type, Category = @Category, Amount = @Amount, Date = @Date, Time = @Time, Wallet = @Wallet WHERE Id = @Id UPDATE Users SET MainWallet = MainWallet - '" + txtCount.Text + "' WHERE Username = (SELECT Username FROM SelectedUser WHERE Username = Username)", connection);
                    using (connection)
                    {
                        connection.Open();
                        using (command)
                        {
                            command.Parameters.AddWithValue("@Id", lb.Content);
                            command.Parameters.AddWithValue("@Type", txtType.Text);
                            command.Parameters.AddWithValue("@Category", txtCategory.Text);
                            command.Parameters.AddWithValue("@Amount", txtCount.Text);
                            command.Parameters.AddWithValue("@Date", txtDate.Text);
                            command.Parameters.AddWithValue("@Time", Time.Text);
                            command.Parameters.AddWithValue("@Wallet", txtWallet.Text);

                            command.ExecuteNonQuery();
                        }
                    }
                }
                if (txtWallet.Text == "Other")
                {
                    SqlCommand command = new SqlCommand(@"UPDATE Transactions SET Type = @Type, Category = @Category, Amount = @Amount, Date = @Date, Time = @Time, Wallet = @Wallet WHERE Id = @Id UPDATE Users SET OtherWallet = OtherWallet - '" + txtCount.Text + "' WHERE Username = (SELECT Username FROM SelectedUser WHERE Username = Username)", connection);
                    using (connection)
                    {
                        connection.Open();
                        using (command)
                        {
                            command.Parameters.AddWithValue("@Id", lb.Content);
                            command.Parameters.AddWithValue("@Type", txtType.Text);
                            command.Parameters.AddWithValue("@Category", txtCategory.Text);
                            command.Parameters.AddWithValue("@Amount", txtCount.Text);
                            command.Parameters.AddWithValue("@Date", txtDate.Text);
                            command.Parameters.AddWithValue("@Time", Time.Text);
                            command.Parameters.AddWithValue("@Wallet", txtWallet.Text);

                            command.ExecuteNonQuery();
                        }
                    }
                }
            }

            if (txtType.Text == "Income")
            {
                if (txtWallet.Text == "Main")
                {
                    SqlCommand command = new SqlCommand(@"UPDATE Transactions SET Type = @Type, Category = @Category, Amount = @Amount, Date = @Date, Time = @Time, Wallet = @Wallet WHERE Id = @Id UPDATE Users SET MainWallet = MainWallet + '" + txtCount.Text + "' WHERE Username = (SELECT Username FROM SelectedUser WHERE Username = Username)", connection);
                    using (connection)
                    {
                        connection.Open();
                        using (command)
                        {
                            command.Parameters.AddWithValue("@Id", lb.Content);
                            command.Parameters.AddWithValue("@Type", txtType.Text);
                            command.Parameters.AddWithValue("@Category", txtCategory.Text);
                            command.Parameters.AddWithValue("@Amount", txtCount.Text);
                            command.Parameters.AddWithValue("@Date", txtDate.Text);
                            command.Parameters.AddWithValue("@Time", Time.Text);
                            command.Parameters.AddWithValue("@Wallet", txtWallet.Text);

                            command.ExecuteNonQuery();
                        }
                    }
                }
                if (txtWallet.Text == "Other")
                {
                    SqlCommand command = new SqlCommand(@"UPDATE Transactions SET Type = @Type, Category = @Category, Amount = @Amount, Date = @Date, Time = @Time, Wallet = @Wallet WHERE Id = @Id UPDATE Users SET OtherWallet = OtherWallet + '" + txtCount.Text + "' WHERE Username = (SELECT Username FROM SelectedUser WHERE Username = Username)", connection);
                    using (connection)
                    {
                        connection.Open();
                        using (command)
                        {
                            command.Parameters.AddWithValue("@Id", lb.Content);
                            command.Parameters.AddWithValue("@Type", txtType.Text);
                            command.Parameters.AddWithValue("@Category", txtCategory.Text);
                            command.Parameters.AddWithValue("@Amount", txtCount.Text);
                            command.Parameters.AddWithValue("@Date", txtDate.Text);
                            command.Parameters.AddWithValue("@Time", Time.Text);
                            command.Parameters.AddWithValue("@Wallet", txtWallet.Text);

                            command.ExecuteNonQuery();
                        }
                    }
                }
            }

            gridHome.Children.Clear();
            gridHome.Children.Add(new UserControlHome());
        }

        private void lstDelete_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (txtWallet.Text == "Main")
            {
                SqlCommand update = new SqlCommand("UPDATE Users SET MainWallet = MainWallet + '"+ txtCount.Text +"'", connection);
                connection.Open();
                update.ExecuteNonQuery();
                connection.Close();
            }
            if (txtWallet.Text == "Other")
            {
                SqlCommand update = new SqlCommand("UPDATE Users SET OtherWallet = OtherWallet + '" + txtCount.Text + "'", connection);
                connection.Open();
                update.ExecuteNonQuery();
                connection.Close();
            }
            SqlCommand delete = new SqlCommand("DELETE FROM Transactions WHERE Id = '"+ lb.Content +"'", connection);
            connection.Open();
            delete.ExecuteNonQuery();
            connection.Close();

            UserControlHome home = new UserControlHome();

            home.lbCategory.Content = txtCategory.Text;
            home.lbTime.Content = Time.Text;
            home.lbType.Content = txtType.Text;
            home.lbWallet.Content = txtWallet.Text;
            home.lbCategory.Content = txtCategory.Text;
            home.lbAmount.Content = txtCount.Text;
            home.lbDate.Content = txtDate.Text;
            home.lvDeletedRecord.Visibility = Visibility.Visible;

            gridHome.Children.Clear();
            gridHome.Children.Add(home);
        }

      
    }
}

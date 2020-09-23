using qq.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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


    public partial class UserControlHome : UserControl
    {
        SqlConnection connection = new SqlConnection(@"Server=localhost\MSSQLSERVER02;Database=manager;Integrated security=True;");
        List<Transaction> transactions = new List<Transaction>();
        public UserControlHome()
        {
            InitializeComponent();
            UpdateBinding();
            SqlConnection connection = new SqlConnection(@"Server=localhost\MSSQLSERVER02;Database=manager;Integrated security=True;");
            DataAccess db = new DataAccess();
            db.GetTransactions();
            UpdateBinding();

            
            /*SqlCommand command = new SqlCommand("SELECT Id, Type, Amount, Date, Time, Category, Wallet FROM Transactions WHERE Username = (SELECT Username FROM SelectedUser WHERE Username = Username)", connection);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);
            datagrid.ItemsSource = table.DefaultView;
            command.Dispose();
            connection.Close();*/

        }

        private void UpdateBinding()
        {
            datagrid.ItemsSource = transactions;
            datagrid.DisplayMemberPath = "FullInfo";
        }

         private void AddTransaction_SelectionChanged(object sender, SelectionChangedEventArgs e)
         {
             gridHome.Children.Clear();
             gridHome.Children.Add(new UserControlAddTransaction());
         }

         private void datagrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
         {
             UserControlTransactionInfo transactionInfo = new UserControlTransactionInfo();
             DataGrid dataGrid = (DataGrid)sender;
             DataRowView rowView = dataGrid.SelectedItem as DataRowView;

             if (rowView != null)
             {
                 transactionInfo.lb.Content = rowView["Id"].ToString();
                 transactionInfo.txtType.Text = rowView["Type"].ToString();
                 transactionInfo.txtCount.Text = rowView["Amount"].ToString();
                 transactionInfo.txtDate.Text = rowView["Date"].ToString();
                 transactionInfo.Time.Text = rowView["Time"].ToString();
                 transactionInfo.txtCategory.Text = rowView["Category"].ToString();
                 transactionInfo.txtWallet.Text = rowView["Wallet"].ToString();
             }

             gridHome.Children.Clear();
             gridHome.Children.Add(transactionInfo);
         }

         private void lvDeletedRecord_SelectionChanged(object sender, SelectionChangedEventArgs e)
         {
             if (lbType.Content.ToString() == "Expense")
             {
                 if (lbWallet.Content.ToString() == "Main")
                 {
                     SqlCommand comm = new SqlCommand(@"INSERT INTO[dbo].[Transactions]([Type], [Amount], [Date], [Time], [Category], [Wallet], [Username]) VALUES (@Type, @Amount, @Date, @Time, @Category, @Wallet, (SELECT Username FROM SelectedUser WHERE Username = Username)) UPDATE Users SET MainWallet = MainWallet - '" + lbAmount.Content + "' WHERE Username = (SELECT Username FROM SelectedUser WHERE Username = Username)", connection);
                     using (connection)
                     {
                         connection.Open();
                         using (comm)
                         {
                             comm.Parameters.AddWithValue("@Type", lbType.Content);
                             comm.Parameters.AddWithValue("@Amount", lbAmount.Content);
                             comm.Parameters.AddWithValue("@Date", lbDate.Content);
                             comm.Parameters.AddWithValue("@Time", lbTime.Content);
                             comm.Parameters.AddWithValue("@Category", lbCategory.Content);
                             comm.Parameters.AddWithValue("@Wallet", lbWallet.Content);

                             comm.ExecuteNonQuery();
                         }
                     }
                 }
                 if (lbWallet.Content.ToString() == "Other")
                 {
                     SqlCommand comm = new SqlCommand(@"INSERT INTO[dbo].[Transactions]([Type], [Amount], [Date], [Time], [Category], [Wallet], [Username]) VALUES (@Type, @Amount, @Date, @Time, @Category, @Wallet, (SELECT Username FROM SelectedUser WHERE Username = Username)) UPDATE Users SET OtherWallet = OtherWallet - '" + lbAmount.Content + "' WHERE Username = (SELECT Username FROM SelectedUser WHERE Username = Username)", connection);
                     using (connection)
                     {
                         connection.Open();
                         using (comm)
                         {
                             comm.Parameters.AddWithValue("@Type", lbType.Content);
                             comm.Parameters.AddWithValue("@Amount", lbAmount.Content);
                             comm.Parameters.AddWithValue("@Date", lbDate.Content);
                             comm.Parameters.AddWithValue("@Time", lbTime.Content);
                             comm.Parameters.AddWithValue("@Category", lbCategory.Content);
                             comm.Parameters.AddWithValue("@Wallet", lbWallet.Content);

                             comm.ExecuteNonQuery();
                         }
                     }
                 }
             }
             if (lbType.Content.ToString() == "Income")
             {
                 if (lbWallet.Content.ToString() == "Main")
                 {
                     SqlCommand comm = new SqlCommand(@"INSERT INTO[dbo].[Transactions]([Type], [Amount], [Date], [Time], [Category], [Wallet], [Username]) VALUES (@Type, @Amount, @Date, @Time, @Category, @Wallet, (SELECT Username FROM SelectedUser WHERE Username = Username)) UPDATE Users SET MainWallet = MainWallet + '" + lbAmount.Content + "' WHERE Username = (SELECT Username FROM SelectedUser WHERE Username = Username)", connection);
                     using (connection)
                     {
                         connection.Open();
                         using (comm)
                         {
                             comm.Parameters.AddWithValue("@Type", lbType.Content);
                             comm.Parameters.AddWithValue("@Amount", lbAmount.Content);
                             comm.Parameters.AddWithValue("@Date", lbDate.Content);
                             comm.Parameters.AddWithValue("@Time", lbTime.Content);
                             comm.Parameters.AddWithValue("@Category", lbCategory.Content);
                             comm.Parameters.AddWithValue("@Wallet", lbWallet.Content);

                             comm.ExecuteNonQuery();
                         }
                     }
                 }
                 if (lbWallet.Content.ToString() == "Other")
                 {
                     SqlCommand comm = new SqlCommand(@"INSERT INTO[dbo].[Transactions]([Type], [Amount], [Date], [Time], [Category], [Wallet], [Username]) VALUES (@Type, @Amount, @Date, @Time, @Category, @Wallet, (SELECT Username FROM SelectedUser WHERE Username = Username)) UPDATE Users SET OtherWallet = OtherWallet + '" + lbAmount.Content + "' WHERE Username = (SELECT Username FROM SelectedUser WHERE Username = Username)", connection);
                     using (connection)
                     {
                         connection.Open();
                         using (comm)
                         {
                             comm.Parameters.AddWithValue("@Type", lbType.Content);
                             comm.Parameters.AddWithValue("@Amount", lbAmount.Content);
                             comm.Parameters.AddWithValue("@Date", lbDate.Content);
                             comm.Parameters.AddWithValue("@Time", lbTime.Content);
                             comm.Parameters.AddWithValue("@Category", lbCategory.Content);
                             comm.Parameters.AddWithValue("@Wallet", lbWallet.Content);

                             comm.ExecuteNonQuery();
                         }
                     }
                 }
             }

             gridHome.Children.Clear();
             gridHome.Children.Add(new UserControlHome());
         }
     
    }
}

using Dapper;
using qq.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qq
{
    public class DataAccess
    {
        public List<Transaction> GetTransactions()
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("manager")))
            {
                var output = connection.Query<Transaction>($"select * from Transactions").ToList();
                return output;
            }
        }
    }
}

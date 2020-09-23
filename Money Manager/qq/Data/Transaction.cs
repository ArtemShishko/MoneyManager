using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qq.Data
{
    public class Transaction
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }
        //public DateTime Time { get; set; }
        public string Category { get; set; }
        public string Wallet { get; set; }

        public string FullInfo 
        {
            get { return $"{ Id } { Type } { Amount } { Date } { Category } { Wallet }"; }
        }
    }
}

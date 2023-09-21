using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boolean.CSharp.Main.Interfaces;

namespace Boolean.CSharp.Main.Accounts
{
    public class CurrentAccount : IAccount
    {
        public string Name { get; set; }
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }

        public CurrentAccount(string Name, string AccountNumber, decimal Balance) 
        {
            this.Name = Name;
            this.AccountNumber = AccountNumber;
            this.Balance = Balance;

        }
    }
}

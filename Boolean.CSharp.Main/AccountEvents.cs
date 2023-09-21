using Boolean.CSharp.Main.Accounts;
using Boolean.CSharp.Main.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main
{
    public class AccountEvents
    {
        private List<IAccount> _accounts {  get; set; } = new List<IAccount>();
        //private CurrentAccount _currentAccount;
        public List<IAccount> Transactions { get { return _accounts; } }

        public void AddToCurrentAccount(IAccount accounts)
        {
            _accounts.Add(accounts);
        }
    }
}

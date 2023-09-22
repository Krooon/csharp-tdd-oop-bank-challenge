using Boolean.CSharp.Main.Accounts;
using Boolean.CSharp.Main.Interfaces;
using Microsoft.VisualBasic;
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
        private List<IBankStatement> _bankStatements { get; set; } = new List<IBankStatement>();
        public List<IBankStatement> BankStatements { get {  return _bankStatements; } }

        public decimal AddToCurrentAccount(IAccount accounts)
        {
            decimal totalBalance = _accounts.Sum(x => x.Balance);
            return totalBalance; 
        }

        public void AddToSavingsAccount(IAccount accounts)
        {
            _accounts.Add(accounts);
        }

        public decimal CalculateTotalBalance(IAccount accounts)
        {
            decimal totalBalance = _accounts.Sum(x => x.Balance);
            return totalBalance;
        }

        public IBankStatement GenerateBankStatement(IBankStatement bankStatement)
        {
            DateTime dateTime = bankStatement.Date;
            decimal oldBalance = _bankStatements.Sum(x => x.OldBalance);
            decimal amount = _bankStatements.Sum(x => x.Amount);
            decimal newBalance = oldBalance + amount;
            //return oldBalance, amount, newBalance, dateTime;
            return bankStatement;

        }

        public IBankStatement GenerateBankAnotherStatement(IBankStatement bankStatement)
        {
            DateTime dateTime = bankStatement.Date;
            decimal oldBalance = bankStatement.OldBalance;
            decimal amount = bankStatement.Amount;
            decimal newBalance = oldBalance + amount;

            // Maak een nieuw IBankStatement-object met bijgewerkte gegevens
            IBankStatement updatedStatement = new BankStatements(dateTime, oldBalance, amount, newBalance);
            //{
            //    Date = dateTime,
            //    OldBalance = oldBalance,
            //    Amount = amount,
            //    NewBalance = newBalance
            //};

            // Retourneer het bijgewerkte IBankStatement-object
            _bankStatements.Add(updatedStatement);
            return updatedStatement;
        }


    }
}

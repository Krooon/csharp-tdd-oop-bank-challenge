using Boolean.CSharp.Main.Accounts;
using Boolean.CSharp.Main.Interfaces;
using Microsoft.VisualBasic;
using NUnit.Framework.Constraints;
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
            decimal totalBalance = _accounts.Sum(x => x.Amount);
            return totalBalance; 
        }

        public void AddToSavingsAccount(IAccount accounts)
        {
            _accounts.Add(accounts);
        }

        public decimal CalculateTotalBalance(IAccount accounts)
        {
            decimal totalBalance = _accounts.Sum(x => x.Amount);
            return totalBalance;
        }

        //public IBankStatement GenerateBankStatement(IBankStatement bankStatement)
        //{
        //    DateTime dateTime = bankStatement.Date;
        //    decimal oldBalance = _bankStatements.Sum(x => x.OldBalance);
        //    decimal amount = _bankStatements.Sum(x => x.Amount);
        //    decimal newBalance = oldBalance + amount;
        //    //return oldBalance, amount, newBalance, dateTime;
        //    return bankStatement;

        //}

      /*  public IBankStatement GenerateAnotherBankstatement2(List<IBankStatement> statements)
        {
            _bankStatements.AddRange(statements);
            return bank
        }*/



        public void GenerateBankAnotherStatement(IBankStatement bankStatement1, IBankStatement bankStatement2, IBankStatement bankStatement3)
        {
            DateTime dateTime1 = bankStatement1.Date;
            decimal oldBalance1 = bankStatement1.OldBalance;
            decimal amount1 = bankStatement1.Amount;
            decimal newBalance1 = oldBalance1 + amount1;

            DateTime dateTime2 = bankStatement2.Date;
            decimal oldBalance2 = bankStatement2.OldBalance;
            decimal amount2 = bankStatement2.Amount;
            decimal newBalance2 = oldBalance2 + amount2;

            DateTime dateTime3 = bankStatement3.Date;
            decimal oldBalance3 = bankStatement3.OldBalance;
            decimal amount3 = bankStatement3.Amount;
            decimal newBalance3 = oldBalance3 + amount3;


            IBankStatement updatedStatement1 = new Transaction(dateTime1, oldBalance1, amount1, newBalance1);
            IBankStatement updatedStatement2 = new Transaction(dateTime2, oldBalance2, amount2, newBalance2);
            IBankStatement updatedStatement3 = new Transaction(dateTime3, oldBalance3, amount3, newBalance3);
            //{
            //    Date = dateTime,
            //    OldBalance = oldBalance,
            //    Amount = amount,
            //    NewBalance = newBalance
            //};

            _bankStatements.Add(bankStatement1);
            _bankStatements.Add(bankStatement2);
            _bankStatements.Add(bankStatement3);


            /*_bankStatements.Add(updatedStatement1);
            _bankStatements.Add(updatedStatement2);
            _bankStatements.Add(updatedStatement3);*/

            /*IBankStatement updatedStatement = new (updatedStatement1, updatedStatement2, updatedStatement3)*/;
            /*return updatedStatement1;
            return updatedStatement2;*/
            /*return updatedStatement3;*/
        }


    }
}

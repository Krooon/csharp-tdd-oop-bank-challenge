using Boolean.CSharp.Main;
using Boolean.CSharp.Main.Accounts;
using Boolean.CSharp.Main.Interfaces;
using NUnit.Framework;

namespace Boolean.CSharp.Test
{
    [TestFixture]
    public class MainTest
    {
       
        [Test]
        public void StoreInCurrentAccount()
        {
            // arrange
            AccountEvents accountEvents = new AccountEvents();

            accountEvents.Transactions.Add(new CurrentAccount("Max Kroon", "NL 78 INGB 0004 7844 1234 5678", 1000m));
            accountEvents.Transactions.Add(new CurrentAccount("Max Kroon", "NL 78 INGB 0004 7844 1234 5678", 1000m));
            accountEvents.Transactions.Add(new CurrentAccount("Max Kroon", "NL 78 INGB 0004 7844 1234 5678", 1000m));

            // act

            decimal result = accountEvents.AddToCurrentAccount(new SavingsAccount("Max Kroon", "NL 78 INGB 0004 7844 1234 5678", 3000m));

            // arrange
            //Assert.AreEqual(true, accountEvents.Transactions.Any(x => x.Balance == 1000m));
            Assert.AreEqual(result, 3000m);
           

        }

        [Test]
        public void StoreInSavingsAccount()
        {
            AccountEvents accountEvents = new AccountEvents();

            accountEvents.Transactions.Add(new SavingsAccount("Max Kroon", "NL 78 INGB 0004 7844 1234 5678", 12599m));

            Assert.AreEqual(true, accountEvents.Transactions.Any(x => x.Amount == 12599m));
        }

        [Test]
        public void TransactionRecords()
        {
            AccountEvents accountEvents = new AccountEvents();
            DateTime transactionDate1 = new DateTime(2012, 01, 10);
            IBankStatement bankStatement1 = new Transaction(transactionDate1, 4500m, 1000m, 5500m);

            DateTime transactionDate2 = new DateTime(2012, 01, 13);
            IBankStatement bankStatement2 = new Transaction(transactionDate2, 5500m, 2000m, 7500m);

            DateTime transactionDate3 = new DateTime(2012, 01, 14);
            IBankStatement bankStatement3 = new Transaction(transactionDate3, 7500m, -500m, 7000m);
            accountEvents.GenerateBankAnotherStatement(bankStatement1, bankStatement2, bankStatement3);

            List<IBankStatement> bankStatements = accountEvents.BankStatements;

            
            Assert.AreEqual(3, bankStatements.Count);  

            
            IBankStatement addedBankStatement = bankStatements[2];

            
            Assert.AreEqual(transactionDate3, addedBankStatement.Date);
            Assert.AreEqual(7500m, addedBankStatement.OldBalance);
            Assert.AreEqual(-500m, addedBankStatement.Amount);
            Assert.AreEqual(7000m, addedBankStatement.NewBalance);
        }

        [Test]

        public void DepositCurrentAccount()
        {
            var accountEvents = new AccountEvents();

            accountEvents.Transactions.Add(new SavingsAccount("Max Kroon", "NL 78 INGB 0004 7844 1234 5678", 12.99m));
            accountEvents.Transactions.Add(new SavingsAccount("Bol.com", "NL 78 INGB 0004 7844 1234 5678", -35m));
            accountEvents.Transactions.Add(new SavingsAccount("Max Kroon", "NL 78 INGB 0004 7844 1234 5678", 70m));

            decimal result = accountEvents.Transactions.Sum(x => x.Amount);

            Assert.AreEqual(result, 47.99m);



        }

    }
}
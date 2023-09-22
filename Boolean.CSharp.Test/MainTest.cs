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

            Assert.AreEqual(true, accountEvents.Transactions.Any(x => x.Balance == 12599m));
        }

        [Test]
        public void TransactionRecords()
        {
            AccountEvents accountEvents = new AccountEvents();
            DateTime transactionDate1 = new DateTime(2012, 10, 1);


            IBankStatement bankStatement = new BankStatements(transactionDate1, 4500m, 1000m, 5500m);
            accountEvents.GenerateBankAnotherStatement(bankStatement);

            List<IBankStatement> bankStatements = accountEvents.BankStatements;

            // Controleer of het bankafschrift is toegevoegd aan de lijst
            Assert.AreEqual(1, bankStatements.Count); // Er moet één bankafschrift in de lijst zijn

            // Haal het eerste bankafschrift uit de lijst
            IBankStatement addedBankStatement = bankStatements[0];

            // Controleer of de waarden overeenkomen met wat je hebt toegevoegd
            Assert.AreEqual(transactionDate1, addedBankStatement.Date);
            Assert.AreEqual(1000m, addedBankStatement.Amount);
            Assert.AreEqual(4500m, addedBankStatement.OldBalance);
            Assert.AreEqual(5500m, addedBankStatement.NewBalance);
        }

    }
}
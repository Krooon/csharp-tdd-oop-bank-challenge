using Boolean.CSharp.Main;
using Boolean.CSharp.Main.Accounts;
using NUnit.Framework;

namespace Boolean.CSharp.Test
{
    [TestFixture]
    public class MainTest
    {
       
        [Test]
        public void StroreInCurrentAccount()
        {
            // arrange
            AccountEvents accountEvents = new AccountEvents();

            // act
            accountEvents.Transactions.Add(new CurrentAccount("Max Kroon", "NL 78 INGB 0004 7844 1234 5678", 1000m));

            // arrange
            Assert.AreEqual(true, accountEvents.Transactions.Any(x => x.Balance == 1000m));

        }

    }
}
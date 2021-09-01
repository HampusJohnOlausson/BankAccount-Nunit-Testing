using NUnit.Framework;
using Bank;

namespace Bank.NunitTests
{
    public class BackAccountTests
    {
        
        [Test]
        public void Adding_Funds_Updates_Balance()
        {
            // Arrange
            var account = new BankAccount(1000);

            // Act
            account.Add(500);

            // Assert
            Assert.AreEqual(1500, account.Balance);

        }
    }
}

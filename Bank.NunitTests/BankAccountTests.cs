using NUnit.Framework;
using Bank;
using System;

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

        [Test]
        public void Adding_Negative_Funds_Updates_Balance()
        {
            // Arrange
            var account = new BankAccount(1000);

            // Act + Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => account.Add(-500));
        }

        [Test]
        public void Withdrawing_Funds_Updates_Balance()
        {
            // Arrange
            var account = new BankAccount(1000);

            // Act
            account.Withdraw(500);

            // Assert
            Assert.AreEqual(500, account.Balance);

        }

        [Test]
        public void Transfering_Funds_Updates_Balance()
        {
            // Arrange
            var account = new BankAccount(1000);
            var otherAccount = new BankAccount();

            // Act
            account.TransferFundsTo(otherAccount, 500);

            // Assert
            Assert.AreEqual(500, account.Balance);
            Assert.AreEqual(500, otherAccount.Balance);

        }
    }
}

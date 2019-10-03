using Xunit;
using BankOperation;
using System;
using System.Reflection;

namespace BankDetailsTests
{
    public class ManageAccountsTests
    {
        [Fact]
        public void Debit_LessThanZero_ThrowInvalidArgument()
        {
            //Arrange
            string name = "Shubham";
            double availableBalance = 100;
            double debitAmount = -2;
            MangeAccount account = new MangeAccount(name, availableBalance);

            //Act
            account.Debit(debitAmount);

            //Assert.Throws<InvalidOperationException>(() => account.Debit(debitAmount));

            //Assert
            Assert.Equal("excpetion occured.", MangeAccount.msg);
        }
       
        [Fact]
        public void Debit_WhenAmountIsGreaterThanBalance_ShouldThrowArgumentOutOfRange()
        {
            //Arrange
            string name = "Shubham";
            double availableBalance = 100;
            double debitAmount = 102;
            MangeAccount account = new MangeAccount(name, availableBalance);

            //Act
            account.Debit(debitAmount);

            //Act and Assert
            //Assert.Throws<Exception>(() => account.Debit(debitAmount));
            Assert.Equal("excpetion occured.", MangeAccount.msg);
        }

        [Fact]
        public void Debit_ValidInputs_ReturnRemainingBalance()
        {
            //Arrange
            string name = "Shubham";
            double balance = 100;
            double debitAmount = 55;
            double expectedAmount = 45;
            MangeAccount account = new MangeAccount(name, availableBalance: balance);

            //Act
            account.Debit(debitAmount);

            //Assert
            double availableBalance = account.GetBalance();
            Assert.Equal(expectedAmount, availableBalance);
        }

        [Fact]
        private void AmountWithTax_ValidAmount_ReturnAmountWithTax()
        {
            //Arrange
            string name = "Shubham";
            double balance = 100;
            double expectedAmount = 100;
            MangeAccount objUnderTest = new MangeAccount(name, balance);
            MethodInfo methodInfo = objUnderTest.GetType().GetMethod("AmountWithTax", BindingFlags.NonPublic | BindingFlags.Instance);

            //Act
            var result = methodInfo.Invoke(objUnderTest, new object[] { 100 });

            //Assert
            Assert.Equal(expectedAmount, result);
        }
    }
}

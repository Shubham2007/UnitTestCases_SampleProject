using System;
using Moq;
using Xunit;
using BankOperation;

namespace BankDetailsTests
{
    public class ManageTests
    {
        [Fact]
        public void GetMessage_EmptyString_ReturnNotValid()
        {
            //Arrange
            var mock = new Mock<Manage>() { CallBase = true };
            string expected = "hello";
            //mock.Setup(m => m.SetMessage("hello")).Returns(expected);

            //Act
            string actual = mock.Object.SetMessage("hello");

            //Assert
            Assert.Contains(expected, actual);
        }
    }
}

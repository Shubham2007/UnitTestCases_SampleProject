using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReservationTestCaseProject;

namespace ReservationTestCaseProjectUnitTests
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void CanCancelledBy_UserIsAdmin_ReturnTrue()
        {
            //Arrange
            Reservation reservation = new Reservation();
            User user = new User() { IsAdmin = true };

            //Act
            var result = reservation.CanCancelledBy(user);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanCancelledBy_SameUser_ReturnTrue()
        {
            //Arrange
            Reservation reservation = new Reservation();
            User user = new User();
            reservation.myUser = user;

            //Act
            var result = reservation.CanCancelledBy(user);

            //Assert
            Assert.IsTrue(result);
            //Assert.That(result == true);
        }

        [TestMethod]
        public void CanCancelledBy_User_ReturnsFalse()
        {
            //Arrrange
            Reservation reservation = new Reservation() { myUser = new User()};

            //Act
            var result = reservation.CanCancelledBy(new User());

            //Assert
            Assert.IsFalse(result);

        }
    }
}

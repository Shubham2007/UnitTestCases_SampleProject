using System;
using System.Collections.Generic;
using System.Text;

namespace ReservationTestCaseProject
{
    public class Reservation
    {
        public User myUser { get; set; }

        public bool CanCancelledBy(User user)
        {
            //if (user.IsAdmin)
            //    return true;

            //if (user == myUser)
            //    return true;

            //return false;

            return (user.IsAdmin || myUser == user);
        }
    }

    public class User
    {
        public bool IsAdmin { get; set; }
    }
}

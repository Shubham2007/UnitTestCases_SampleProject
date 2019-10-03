using System;

namespace ReservationTestCaseProject
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User { IsAdmin = true };
            bool status = new Reservation().CanCancelledBy(user);
            string reservationStatus = status ? "cancelled" : "booked";
            Console.WriteLine("Reservation status is now " + reservationStatus);
        }
    }
}

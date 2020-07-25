using System;
using Xunit;
namespace UnitProject
{
    // MethodName_Scenario_ExpectedBehavior()
    /* when write unite test for this method , we will test all scenarios what is scnarios we have here
     we have three scnarios ?
     user is an admin 
     the user is the same person who made the reservation 
     someone else try to cancel the reservation
 */
    public class ReservationTests
    {
        [Fact]
        public void CanCancelledBy_UserIsAdmin_ReturnTrue() 
        {
            // arrange initialize an objects 
            var reservation = new Reservation();
            //act method we are going to test 
          var result =  reservation.CanCancelledBy(new User { IsAdmin = true });
            //assert verify result it should be true
            Assert.True(result);
        }
        [Fact]
        public void CanCancelledBy_SameUserCancellingReservation_ReturnTrue()
        {
            // arrange initialize an objects 
            var user = new User();
            var reservation = new Reservation { MadeBy = user };
            //act method we are going to test 
            var result = reservation.CanCancelledBy(user);
            //assert verify result it should be true
            Assert.True(result);
        }
        [Fact]
        public void CanCancelledBy_AnotherUserCancellingReservation_ReturnFalse()
        {
            // arrange initialize an objects 
            var reservation = new Reservation { MadeBy = new User()};
            //act method we are going to test 
            var result = reservation.CanCancelledBy(new User());
            //assert verify result it should be true
            Assert.False(result);
        }
        
    }
}

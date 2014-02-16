using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Laboration.DoggieDayCare.WebService.Models
{
    public interface IBookingRepository
    {
        IQueryable<Booking> GetBookings();
        Booking GetBooking(int id);
        Booking AddBooking(Booking booking);
        Booking EndBooking(Booking booking);
        bool SaveChanges();
    }
}

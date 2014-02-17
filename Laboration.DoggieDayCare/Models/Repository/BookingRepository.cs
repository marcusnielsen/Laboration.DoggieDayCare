using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboration.DoggieDayCare.WebService.Models
{
    public class BookingRepository : IBookingRepository 
    {

        private DoggieDayCareContext DoggieDayCareContext { get; set; }

        public BookingRepository(DoggieDayCareContext doggieDayCareContext)
        {
            DoggieDayCareContext = doggieDayCareContext;
        }

        public IQueryable<Booking> GetBookings()
        {
            return DoggieDayCareContext.Bookings;
        }

        public Booking GetBooking(int id)
        {
            return DoggieDayCareContext.Bookings.FirstOrDefault(booking => booking.Id == id);
        }

        public Booking AddBooking(Booking booking)
        {
            booking.DogBreed = DoggieDayCareContext.DogBreeds.FirstOrDefault(dogBreed => dogBreed.BreedName == booking.DogBreed.BreedName);

            if (booking.DogBreed == null)
            {
                throw new NullReferenceException("Booking with ID: " + booking.Id + " did not have a specified dog breed.");
            }

            booking.DogBreed.BaseCosts =
                DoggieDayCareContext.BaseCostses.FirstOrDefault(baseCost => baseCost.Title == booking.DogBreed.BaseCosts.Title);
            
            return DoggieDayCareContext.Bookings.Add(booking);
        }

        public Booking EndBooking(Booking booking)
        {
            var oldBooking = DoggieDayCareContext.Bookings.Include("DogBreed.BaseCosts").FirstOrDefault(bookingComparison => bookingComparison.Id == booking.Id);

            if (oldBooking == null)
            {
                throw new NullReferenceException("Could not find booking with ID: " + booking.Id);
            }

            oldBooking.CheckOut = booking.CheckOut;
            oldBooking.CheckOutFoodWeight = booking.CheckOutFoodWeight;

            return oldBooking;
        }

        public bool SaveChanges()
        {
            return DoggieDayCareContext.SaveChanges() > 0;
        }
    }
}
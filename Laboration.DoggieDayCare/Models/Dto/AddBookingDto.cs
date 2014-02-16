using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboration.DoggieDayCare.WebService.Models
{
    public class AddBookingDto
    {
        public Booking Booking { get; private set; }

        public string DogBreedName
        {
            get { return Booking.DogBreed.BreedName; }
            set
            {
                Booking.DogBreed = DogBreed.GetBreedByName(value);
            }
        }

        public String OwnerCivicRegistrationNumber
        {
            get { return Booking.OwnerCivicRegistrationNumber; }
            set { Booking.OwnerCivicRegistrationNumber = value; }
        }

        public String DogRegistrationNumber
        {
            get { return Booking.DogRegistrationNumber; }
            set { Booking.DogRegistrationNumber = value; }
        }

        public DateTime CheckIn
        {
            get { return Booking.CheckIn; }
            set
            {
                Booking.CheckIn = value;
                Booking.CheckOut = value; // TODO: Make optional.
            }
        }

        public Decimal CheckInFoodWeight
        {
            get { return Booking.CheckInFoodWeight; }
            set { Booking.CheckInFoodWeight = value; }
        }

        public Dictionary<string, string> Data
        {
            get { return Booking.Data; }
            set { Booking.Data = value; }
        }

        public AddBookingDto()
        {
            Booking = new Booking();
        }
    }
}
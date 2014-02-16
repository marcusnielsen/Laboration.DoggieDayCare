using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboration.DoggieDayCare.WebService.Models.Dto
{
    public class EndBookingDto
    {
        public Booking Booking { get; private set; }

        public int Id
        {
            get { return Booking.Id; }
            set { Booking.Id = value; }
        }

        public DateTime CheckOut
        {
            get { return Booking.CheckOut; }
            set { Booking.CheckOut = value; }
        }

        public Decimal CheckOutFoodWeight
        {
            get { return Booking.CheckOutFoodWeight; }
            set { Booking.CheckOutFoodWeight = value; }
        }

        public Dictionary<string, string> Data { get; set; }

        public EndBookingDto()
        {
            Booking = new Booking();
        }
    }
}
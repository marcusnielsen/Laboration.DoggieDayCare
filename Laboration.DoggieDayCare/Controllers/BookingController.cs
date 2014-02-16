using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Laboration.DoggieDayCare.WebService.Models;
using Laboration.DoggieDayCare.WebService.Models.Dto;

namespace Laboration.DoggieDayCare.WebService.Controllers
{
    public class BookingController : ApiController
    {
        IBookingRepository BookingRepository { get; set; }

        public BookingController(IBookingRepository bookingRepository)
        {
            BookingRepository = bookingRepository;
        }

        // GET api/<controller>
        public IEnumerable<Booking> Get()
        {
            return BookingRepository.GetBookings();
        }

        // GET api/<controller>/5
        public Booking Get(int id)
        {
            return BookingRepository.GetBooking(id);
        }

        // POST api/<controller>
        public int Post([FromBody]AddBookingDto addBooking)
        {
            // TODO: Save Changes returns the real bool value.
            var result = BookingRepository.AddBooking(addBooking.Booking);
            BookingRepository.SaveChanges();
            return result.Id;
        }

        // PUT api/<controller>/5
        public Booking Put([FromBody] EndBookingDto endBooking)
        {
            var bookingResult = BookingRepository.EndBooking(endBooking.Booking);
            BookingRepository.SaveChanges();
            return bookingResult;
        }
    }
}
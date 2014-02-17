Laboration.DoggieDayCare
========================

Start the web service project.

Open the index.html in the web client project. Do not use chrome, it will not work right now.

Add a booking with the topmost form. The result will be the ID that you can use to "end" the booking (just a post right now).

Future versions should refactor BaseCosts and DogBreed so it's a lookup table in the DB.
BaseCosts should not be referenced by the DogBreed but by a Booking.
A Company object should be present.
The Data property of Booking should be working from client to DB. Right now it is just a null Dictionary. A Customer should be able to add arbitrary data on a Booking.

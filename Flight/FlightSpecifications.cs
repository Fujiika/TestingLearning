using FluentAssertions;
using Domain;

namespace FlightTest
{
    public class FlightSpecifications
    {
        [Fact]
        public void Booking_reduces_the_number_of_seats()
        {
            var flight = new Flight(seatCapacity: 3);

            flight.Book("lmao@gmail.com", 1);

            flight.RemainingNumberOfSeats.Should().Be(2);
        }

        [Fact]
        public void Avoids_overbooking()
        {
            var flight = new Flight(seatCapacity: 3);

            flight.Book("lmao@gmail.com", 3);


            flight.RemainingNumberOfSeats.Should().Be(1);
        }
    }
}
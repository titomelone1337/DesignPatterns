using ex04_Facade;

class Program
{
    static void Main(string[] args)
    {

        var search = new BookingSystemFacade();
        search.Search("New York", "Los Angeles", "Los Angeles", DateTime.Now);
        
        var reserveFlightHotelCar = new BookingSystemFacade();
        reserveFlightHotelCar.BookFlightHotelCar("New York", "Los Angeles", "Los Angeles", DateTime.Now);

        
        var reserveFlightHotel = new BookingSystemFacade(new classFlights(), new classHotels(), null); 
        reserveFlightHotel.BookFlightHotel("New York", "Miami", "Miami", DateTime.Now);

        var reserveFlightCar = new BookingSystemFacade(new classFlights(), null, new classRentACar());
        reserveFlightCar.BookFlightCar("New York", "Miami", "Miami", DateTime.Now);


        var cancelCompleteReservation = new BookingSystemFacade();
        cancelCompleteReservation.CancelFlightHotelCar("New York", "Miami", "Miami", DateTime.Now);

        var cancelFlightHotel = new BookingSystemFacade();
        cancelFlightHotel.CancelFlightHotel("New York", "Miami", "Miami", DateTime.Now);

        var cancelFlightCar = new BookingSystemFacade();
        cancelFlightCar.CancelFlightCar("New York", "Miami", "Miami", DateTime.Now);

    }
}

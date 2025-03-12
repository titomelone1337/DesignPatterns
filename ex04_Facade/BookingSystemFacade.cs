using System;

namespace ex04_Facade
{
    public class BookingSystemFacade
    {
        private readonly classFlights _flights;
        private readonly classHotels _hotels;
        private readonly classRentACar _rentACar;

        // Default Constructor (Creates new instances)
        public BookingSystemFacade()
        {
            _flights = new classFlights();
            _hotels = new classHotels();
            _rentACar = new classRentACar();
        }

        // Overloaded Constructor with Optional Parameters (Dependency Injection)
        public BookingSystemFacade(classFlights flights = null, classHotels hotels = null, classRentACar rentACar = null)
        {
            _flights = flights ?? new classFlights();   // Use provided instance or create a default one
            _hotels = hotels ?? new classHotels();
            _rentACar = rentACar ?? new classRentACar();
        }

        public void Search(string from, string to, string city, DateTime date)
        {
            Console.WriteLine("Searching for available flights, hotels, and rental cars...");
            _flights.SearchFlights(from, to, date);
            _hotels.SearchHotels(city, date);
            _rentACar.SearchCars(city, date);
        }

        public void BookFlightHotelCar(string from, string to, string city, DateTime date)
        {
            Console.WriteLine("\nBooking Flight, Hotel, and Rental Car...");
            _flights.BookFlight(from, to, date);
            _hotels.BookHotel(city, date);
            _rentACar.RentCar(city, date);
        }

        public void BookFlightHotel(string from, string to, string city, DateTime date)
        {
            Console.WriteLine("\nBooking Flight and Hotel...");
            _flights.BookFlight(from, to, date);
            _hotels.BookHotel(city, date);
        }

        public void BookFlightCar(string from, string to, string city, DateTime date)
        {
            Console.WriteLine("\nBooking Flight and Rental Car...");
            _flights.BookFlight(from, to, date);
            _rentACar.RentCar(city, date);
        }

        public void CancelFlightHotelCar(string from, string to, string city, DateTime date)
        {
            Console.WriteLine("\nCancelling Flight, Hotel, and Rental Car...");
            _flights.CancelFlight(from, to, date);
            _hotels.CancelHotel(city, date);
            _rentACar.CancelCar(city, date);
        }

        public void CancelFlightHotel(string from, string to, string city, DateTime date)
        {
            Console.WriteLine("\nCancelling Flight and Hotel...");
            _flights.CancelFlight(from, to, date);
            _hotels.CancelHotel(city, date);
        }

        public void CancelFlightCar(string from, string to, string city, DateTime date)
        {
            Console.WriteLine("\nCancelling Flight and Rental Car...");
            _flights.CancelFlight(from, to, date);
            _rentACar.CancelCar(city, date);
        }
    }
}

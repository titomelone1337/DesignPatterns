using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ex04_Facade
{
    public class classFlights
    {
        public void SearchFlights(string from, string to, DateTime date)
        {
            Console.WriteLine("Searching flights from {0} to {1} on {2}", from, to, date);
        }

        public void BookFlight(string from, string to, DateTime date)
        {
            Console.WriteLine("Booking flight from {0} to {1} on {2}", from, to, date);
        }


        public void CancelFlight(string from, string to, DateTime date)
        {
            Console.WriteLine("Cancelling flight from {0} to {1} on {2}", from, to, date);
        }
    }
}

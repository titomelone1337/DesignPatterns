using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex04_Facade
{
    public class classHotels
    {

        public void SearchHotels(string city, DateTime date)
        {
            Console.WriteLine("Searching hotels in {0} on {1}", city, date);
        }

        public void BookHotel(string city, DateTime date)
        {
            Console.WriteLine("Booking hotel in {0} on {1}", city, date);
        }

        public void CancelHotel(string city, DateTime date)
        {
            Console.WriteLine("Cancelling hotel in {0} on {1}", city, date);
        }
    }
}

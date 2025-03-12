using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex04_Facade
{
    public class classRentACar
    {

        public void SearchCars(string city, DateTime date)
        {
            Console.WriteLine("Searching cars in {0} on {1}", city, date);
        }

        public void RentCar(string city, DateTime date)
        {
            Console.WriteLine("Renting car in {0} on {1}", city, date);
        }


        public void CancelCar(string city, DateTime date)
        {
            Console.WriteLine("Cancelling car in {0} on {1}", city, date);
        }
    }
}

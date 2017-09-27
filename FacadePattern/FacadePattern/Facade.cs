using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    // Provide a unified interface to a set of interfaces in a subsystem
    class Facade
    {
        private Airline flight = new Airline();
        private Hotel hotel = new Hotel();
        private RentalCar car = new RentalCar();

        public int flt;    // Cost of flight
        public int flt_rb; // Cost of Roundabout flight
        public int htl;    // Cost of Hotel
        public int rtl;    // Cost of Rental Car
        public int total;  // Total Cost

        // Adds together all values chosen by user, checks if roundabout is selected
        public void Total()
        {
            if (flt_rb > 0)
            {
                total = (flt_rb + htl + rtl);
            }
            else
            total = (flt + flt_rb  + htl + rtl);
        }
    }
}
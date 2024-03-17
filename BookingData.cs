using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group10_HotelSystem
{
    public class BookingData
    {
        //private attributes
        static string Data;

        //property structures
        public static string propData { get => Data; set => Data = value; }

        //Default constructor
        public BookingData()
        {
            propData = "";
        }

        //Parameterised constructor
        public BookingData(string D)
        {
            propData = D;
        }

    }

}

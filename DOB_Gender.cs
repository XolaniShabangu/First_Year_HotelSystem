using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group10_HotelSystem
{
    public class DOB_Gender
    {
        //private attributes
        private string IDNo;

        //property structures
        public string propIDNo { get => IDNo; set => IDNo = value; }

        //default constructor
        public DOB_Gender()
        {
            IDNo = "";

        }

        //parameterised constructor
        public DOB_Gender(string Id)
        {
            IDNo = Id;
        }

        //Methods
        public DateTime getDOB()
        {
            
                int Y, M, D;
                Y = int.Parse(IDNo.Substring(0, 2));
                M = int.Parse(IDNo.Substring(2, 2));
                D = int.Parse(IDNo.Substring(4, 2));

                if (Y > 99 || Y < DateTime.Now.Year - 2000)
                    Y = Y + 2000;
                else
                    Y = Y + 1900;
                string DOB = $"{Y}/{M}/{D}";
                return (DateTime.Parse(DOB));
            
        }

        public string getGender()
        {
            int x;
            x = int.Parse(IDNo.Substring(6, 4));
            if (x > 4999)
                return ("Male");
            else
                return ("Female");
       
        }

    }
}

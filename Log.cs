using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group10_HotelSystem
{
    public class Log
    {
        
        //Private attributes
        private string Name;
        private string Surname;
        private string DOB;
        private string ConfPassword;
        private string Email;
        private string Password;
        private string Phone;
        private string ID;

        //Property Structures
        public string propName { get => Name; set => Name = value; }
        public string propSurname { get => Surname; set => Surname = value; }
        public string propDOB { get => DOB; set => DOB = value; }
        public string propConfPassword { get => ConfPassword; set => ConfPassword = value; }
        public string propEmail { get => Email; set => Email = value; }
        public string propPassword { get => Password; set => Password = value; }
        public string propPhone { get => Phone; set => Phone = value; }
        public string propID { get => ID; set => ID = value; }


        //Default Constructors
        public Log()
        {
            propEmail = "";
            propPassword = "";
            propName = "";
            propSurname = "";
            propDOB = "";
            propConfPassword = "";
            propPhone = "";
            propID = "";
        }

        //Parameterised Constructors
        public Log(string E, string P, string N, string S, string D, string C, string PH, string I)
        {
            propEmail = E;
            propPassword = P;
            propName = N;
            propSurname = S;
            propDOB = D;
            propConfPassword = C;
            propPhone = PH;
            propID = I;
        }



        //Methods
        public string Register()
        {
            //write to txt file
            try
            {
                string filePath = @"C:\Users\xolan\OneDrive\Desktop" + "\\Code TextFiles\\" + propEmail + ".txt";
                StreamWriter Write = new StreamWriter(filePath);
                using (Write)
                {
                    Write.WriteLine("Name:" + propName);
                    Write.WriteLine("Surname:" + propSurname);
                    Write.WriteLine("Phone Number:" + propPhone);
                    Write.WriteLine("ID Number:" + propID);
                    Write.WriteLine("Password:" + propPassword);
                    Write.WriteLine("Email:" + propEmail);
                }
                MessageBox.Show("Registered sucessfully", "Success");
            }
            catch (Exception)
            {
                MessageBox.Show("Error has occurred.");
            }
            return ("Error");
        }

        public string LogOn() //read from txt file
        {
            string feedback = "";
            string filePath = @"C:\Users\xolan\OneDrive\Desktop" + "\\Code TextFiles\\" + propEmail + ".txt";
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        string[] lineArray = new string[2];
                        lineArray = line.Split(':');
                        if (lineArray[1] == Password)
                        {
                            feedback = "Access Granted";
                            return feedback;
                        }
                        else
                        {
                            feedback = "Incorrect details";
                        }
                        line = reader.ReadLine();
                    }
                }
            }
            catch (Exception)
            {
                feedback = "Incorrect email address";
            }
            return (feedback);
        }     
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV321_CSharp
{
    internal class Student
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public DateTime BirthDay { get; set; }
        public string StudentCardNumber { get; set; } = "";


        public void Print()
        {
            Console.WriteLine($"{LastName.PadRight(15)} " +
                $"{FirstName.PadRight(10)} " +
                $"{BirthDay.ToShortDateString()} " +
                $"{StudentCardNumber}");
        }
    }
}

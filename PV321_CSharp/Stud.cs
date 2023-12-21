using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV321_CSharp
{
    public class Stud
    {
        public const int id = 44;

        public static int group;

        public readonly int age;

        public readonly int[] marks = { 10, 10, 12 };

        string name;

        static Stud()
        {
            group = 5;
        }

        public Stud(): this(0, new int[3]) { }

        public Stud(int age, int[] marks)
        {
            this.age = age;
            this.marks = marks;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName() 
        { 
            return this.name; 
        }


        int num;
        public int Number
        {
            get { return num; }
            set { num = value; }
        }


        private DateTime myVar;

        public DateTime BirthDay
        {
            get { return myVar; }
            set 
            { 
                myVar = value < DateTime.MinValue ? DateTime.MinValue : value;
            }
        }

        public string Name { get; set; } = "No Name";

        public Stud getStudent()
        {
            return this;
        }

        public int MyProperty { get; private set; }

        
    }
}

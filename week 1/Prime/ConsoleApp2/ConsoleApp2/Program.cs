using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Student
    {
        public string firstName;
        public string lastName;

        public float gpa;

        public Student()
        {
            firstName = "Ali";
            lastName = "Kurban";

            gpa = 4;

        }
        public override string ToString()
        {
            return this.firstName + " " + lastName + " " + gpa;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
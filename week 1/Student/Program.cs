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
            firstName = "Kurban";
            lastName = "ALI";

            gpa = 4;

        }
        public Student(string a, string c, int b){
            firstName = a;
            lastName = lname2;

            gpa = b;

   
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

            Student s2 = new Student("fname1", 3.4);
            Console.WriteLine(s2.ToString);
            Console.ReadKey();
        }
    }
}
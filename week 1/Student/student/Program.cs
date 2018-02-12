using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    class Student
    {
        public string name;
        public int age;
        public double gpa;

        public Student()
        {
            name = "Arman";
            age = 18;
            gpa = 4;
        }
        public Student(string s, int b)
        {
            name = s;
            age = b;
            gpa = 4;

        }

        public Student(double b)
        {
            gpa = b;
        }

        public override string ToString()
        {
            return name + " " + age + " " + gpa;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Student s = new Student();
            Student s2 = new Student("jhhj", 18);

            Student s3 = new Student(3.7);

            Console.WriteLine(s3);
            Console.WriteLine(s);
            Console.WriteLine(s2);
            Console.ReadKey();

        }
    }
}
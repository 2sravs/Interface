using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Student : IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public int StudentId { get; set; }
        public Student(string name, int age, string address, int id)
        {
            Name = name;
            Age = age;
            Address = address;
            StudentId = id;

        }
        public void DisplayDetails()
        {
            Console.WriteLine("Student Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("Student ID: " + StudentId);
            Console.WriteLine();
        }



    }
}

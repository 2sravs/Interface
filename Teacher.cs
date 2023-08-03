using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{

    public class Teacher : IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Subject { get; set; }

        public Teacher(string name, int age, string address, string subject)
        {
            Name = name;
            Age = age;
            Address = address;
            Subject = subject;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Teacher Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("Subject: " + Subject);
            Console.WriteLine();
        }
    }

}

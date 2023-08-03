using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class OfficeStaff : IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Role { get; set; }

        public OfficeStaff(string name, int age, string address, string role)
        {
            Name = name;
            Age = age;
            Address = address;
            Role = role;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Office Staff Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("Role: " + Role);
            Console.WriteLine();
        }
    }

}

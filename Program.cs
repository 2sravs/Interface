using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IPerson student1 = new Student("sandy", 18, "Santhish nagar", 1001);
            IPerson teacher1 = new Teacher("sanjana", 30, "yachavaram", "Mathematics");
            IPerson officeStaff1 = new OfficeStaff("kalpana", 25, "RaithuBazar", "Receptionist");

            student1.DisplayDetails();
            teacher1.DisplayDetails();
            officeStaff1.DisplayDetails();
            Console.ReadKey();
        }


    }

}


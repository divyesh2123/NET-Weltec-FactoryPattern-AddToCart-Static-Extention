using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    public class Employee
    {
       public static List<string>  phonenumbers = new List<string>();

        public int employeeId = 0;

        public void addNumbers(string numbers)
        {
            phonenumbers.Add(numbers);  
        }

        public void display()
        {
            Console.WriteLine("employeeID" + employeeId);
            foreach (string number in phonenumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}

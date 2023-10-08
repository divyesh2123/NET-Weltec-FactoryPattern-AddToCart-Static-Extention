using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    public class EmailNotification : INotification
    {
        public void SendNotification()
        {
            Console.WriteLine("Email Notfication");
        }
    }
}

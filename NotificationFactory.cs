using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    public class NotificationFactory : INotificationFactory
    {
        public INotification GetFactory(string type)
        {
            switch(type)
            {
                case "SMS" : 

                    return new SMSNotfication();

                case "Email": 

                    return new EmailNotification();


                default:

                    return new SMSNotfication();

            }
        }
    }
}

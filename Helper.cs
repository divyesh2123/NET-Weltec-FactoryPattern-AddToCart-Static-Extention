using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    //E0001;
   public static class Helper
    {

        public static int HRNID(this string  hrnNumber)
        {

            return Convert.ToInt32(hrnNumber.Substring(hrnNumber.Length-1));

        }
        
    }
}

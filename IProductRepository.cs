using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal interface IProductRepository
    {
        void Add(IProduct product);

        void ListProduct();

        int TotalDiscount();

        Dictionary<string, int> GetCartWithDiscount();
    }
}

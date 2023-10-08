using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    public class ProductRepository : IProductRepository
    {
       static public List<IProduct> MyProducts { get; set; }    

        public ProductRepository()
        {
            MyProducts = new List<IProduct>();  
        }
        public Dictionary<string, int> GetCartWithDiscount()
        {
            var d = MyProducts.Select(y =>
           new
           {
               ProductName = y.ProductNme,
               Price = y.Price,
               Category = y.Price > 0 && y.Price < 500 ? "Cheap" : "Moderate"

           }).GroupBy(y => y.Category).Select(y =>
           new
           {
               Name = y.Key,
               Count = y.Count()


           }).ToDictionary(y => y.Name, y => y.Count);

            return d;
        }

        public void ListProduct()
        {
            foreach(var t in MyProducts)
            {
                Console.WriteLine(t.ProductNme  + "  " + t.Price);
            }
        }

        public int TotalDiscount()
        {
            var d = MyProducts.Select(y =>
            new
            {
                ProductName = y.ProductNme,
                Price = y.Price,
                Discount = y.Price > 0 && y.Price < 500 ? y.Price * 10 / 100 : y.Price * 20 / 100

            }).Sum(y=>y.Discount);

            return d;
        }

        void IProductRepository.Add(IProduct product)
        {
            MyProducts.Add(product);


        }
    }
}

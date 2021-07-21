using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    //public class ShoppingCart : IEnumerable<Product>
    //{
    //    public IEnumerable<Product> Products { get; set; }


    //   public  IEnumerator<Product> GetEnumerator()
    //    {
    //        return Products.GetEnumerator();
    //    }
    //    IEnumerator IEnumerable.GetEnumerator()
    //    {
    //        yield return GetEnumerator();
    //    }

    //}

    public class ShoppingCart : IProductSelection
    {
        private List<Product> products = new List<Product>();

        public ShoppingCart(params Product[] products)
        {
            products.AddRange(products);
        }

        public IEnumerable<Product> Products { get => products; }

    }
}

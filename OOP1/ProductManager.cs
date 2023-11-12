using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    //Bu tarz isimlendirmelerde içinde ürünle ilgili operasyonlar olur.
    //encapsulation 
    public class ProductManager
    {
        public void Add(Product product)//101
        {
           
            Console.WriteLine(product.ProductName + "eklendi");

        }
        public void Update(Product product)
        {
            
            
            Console.WriteLine(product.ProductName + "güncellendi");


        }

       


    }
}

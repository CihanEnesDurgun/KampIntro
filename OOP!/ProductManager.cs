using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_
{
    class ProductManager
    {
        //encapsulation
        // void'i şöyle düşünebiliriz. bir emir kipinde işlemini yapıyor ve bitiriyor.
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + "eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi.");
        }
    }
}

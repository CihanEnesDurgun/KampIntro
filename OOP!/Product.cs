using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_
{
    class Product
    {
        public int Id { get; set; }
        //ürün ID'si
        public int  CategoryId { get; set; }
        //ürünün katageori ID'si
        public string ProductName { get; set; }
        //ürün adı
        public double UnitPrice { get; set; }
        //ürün fiyatı
        public int UnitsInStock { get; set; }
        //ürün stoğu
    }
}

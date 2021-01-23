using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Coorporate
    class TuzelMusteri:Musteri

     //miras-inheritance
     //sonradan iki nokta ile eklediğimiz müsteri kısmınıtüm müsatei çeşitlerini topğlamak için ekledik. 
     //bu şekilde müşteride olan herşey tüzel müşteri de de bulunmuş olacak
    {
        
        
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}

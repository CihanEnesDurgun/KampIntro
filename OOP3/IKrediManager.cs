using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //okunurluğu attırmak için interface lerin başına I yazarız
    interface IKrediManager
        //genelde operasyonel işlemlerde interface kullanırız.
    {
        void Hesapla();
        void BiseyYap();

    }
}

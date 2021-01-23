using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //interfaceleri operasonları aynı olan ama kod içerikleri farklı olan sınıflarda kullanırız
    interface ICreditManager
    {
        void Calc();
        void BiseyYap();
        
    }
}//eğerki birisi bu interface kullanırsa o arkadaşım şu metodu içermek zorunda

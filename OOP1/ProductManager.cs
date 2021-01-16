using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {

        //encapsulation
        //void anahtar kelimesi metodlara emir vermek için kullanılır işlem sonucun ne olduğuna dari bir bilgiye ihtiyacın yoksa void kullanırız
        //yani void değer döndürmez gider yapar bitirir
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " Eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " Güncellendi.");
        }

    }
}

using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{

    //Arrayleri yani dizileri genişletemiyoruz sabitlik olduğu için koleksiyonları kullanıyoruz koleksiyonlara sonradan değer eklebiliriz
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin", "Abdullah", "Yasin", "Kerem", "Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //Console.WriteLine(isimler[4]);

            //isimler = new string[5];
            //isimler[5] = "Hüseyin";
            //Console.WriteLine(isimler[5]);
            //Console.WriteLine(isimler[0]);

            List<string> isimler2 = new List<string> { "Engin", "Abdullah", "Yasin", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[4]);

            isimler2.Add("Hüseyin");
            Console.WriteLine(isimler2[5]);
            Console.WriteLine(isimler2[0]);

            Console.ReadLine();
        }
    }
}

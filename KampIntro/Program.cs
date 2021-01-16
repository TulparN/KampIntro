using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety = tip güvenliği
            string kategoriEtiketi = "Katagori";
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmısMı = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if(dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Eşittir Butonu");
            }

            if (sistemeGirisYapmısMı == true)
            {
                Console.WriteLine("Giriş Yapıldı!");
            }
            else
            {
                Console.WriteLine("Giriş Yapınız!");
            }

            Console.WriteLine(kategoriEtiketi);
            Console.ReadLine();
            
        }
    }
}

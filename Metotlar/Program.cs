using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            //type safe - tip güvenli
            foreach (Urun urun in urunler)
            {
                Console.WriteLine("Ürün Adı : {0} \nFiyat    : {1} \nAçıklama : {2}", urun.Adi, urun.Fiyati, urun.Aciklama);
                Console.WriteLine("----------------------------------------------");
            }

            Console.WriteLine("-------------------Metotlar-------------------");
            //İnstance - örnek
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);


            sepetManager.Ekle2("Armut", "Yaşil", 12, 20);
            sepetManager.Ekle2("Elma", "Amasya", 16, 10);
            sepetManager.Ekle2("Karpuz", "Diyarbakır", 100, 2);

            Console.ReadLine();
        }
    }
}


//Dont Repeat yourself - DRY - Clean Code - Best Practice
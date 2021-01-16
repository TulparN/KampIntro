using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.FirstName = "Engin";
            musteri1.LastName = "DEMİROĞ";
            musteri1.Salary = 30000;
            Musteri musteri2 = new Musteri();
            musteri2.FirstName = "Abdullah";
            musteri2.LastName = "ÇETİN";
            musteri2.Salary = 3000;
            Musteri musteri3 = new Musteri();
            musteri3.FirstName = "Yasin";
            musteri3.LastName = "ÇETİN";
            musteri3.Salary = 2500;

            Musteri[] musteriler = new Musteri[] { musteri1,musteri2,musteri3};

            MusteriManager musteriTakip = new MusteriManager();

            musteriTakip.Ekle(musteriler);
            musteriTakip.MusterileriGoster(musteriler);
            musteriTakip.Sil(musteri3);
            Console.ReadLine();
        }
    }
}

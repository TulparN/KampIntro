using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri[] musteriEkle)
        {
            foreach (Musteri musteri1 in musteriEkle)
            {
                Console.WriteLine("{0}: isimli yeni müşteri takip listesine başarıyla eklendi", musteri1.FirstName);
                Console.WriteLine("-------------------------------------------------------------------------------");
            }
        }
        public void MusterileriGoster(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşterinin Adı    : {0} \nMüşterinin Soyadı : {1} \nMüşterinin Maaşı  : {2}",musteri.FirstName,musteri.LastName,musteri.Salary);
                Console.WriteLine("---------------------------------------------");
            }
        }

        public void Sil(Musteri musteriSil)
        {
            Console.WriteLine("{0} : isimli müşteri takip listesinden çıkarılmıştır",musteriSil.FirstName);
        }
        
    }
}

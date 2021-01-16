using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {

            //int decimal float double bool değer tipler
            // array class interface referans tipler
            //bellekte stack ve heap diye 2 alan var değer tipler stackte saklanıyor
            //değer tiplerde eşitleme yaptığın zaman stack alanında bir kere eşitleme yapar ondan sonra sayi1 in sayi2 ile bağlantısı kalmaz
            //sayı2 yi istediğin kadar değiştirsende sayi1 ilk aşamada eşitlemede verilen değeri döndürür
            //referans tipleride ise sayılar1 ve sayilar2 heap te bir id ile tutulur sayilar1 ve sayilar2 eşitlenme yapıldığında sayilar birin array id si sayilar2 nin
            //id sine eşitlenir sen sayilar2 nin 0. elemanının değerini değiştirdiğin için bu id ile sayilar1 inde 0. elemanı değişmiş oluyor
            int sayi1 = 10;
            int sayi2 = 30;

            sayi1 = sayi2;

            sayi2 = 65;
            //sayi1 30 döndürür

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };

            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //Sayilar1 in 0. değeri o yüzden 999 döndürür
            
        }
    }
}

using System;

namespace Classıntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string Adi = "Engin";
            int Yas = 36;
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Hüseyin";
            kurs2.IzlenmeOrani = 90;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Seda";
            kurs3.IzlenmeOrani = 100;

            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen + " " + kurs1.IzlenmeOrani);
            //Console.WriteLine(kurs2.KursAdi + " " + kurs2.Egitmen + " " + kurs2.IzlenmeOrani);
            //Console.WriteLine(kurs3.KursAdi + " " + kurs3.Egitmen + " " + kurs3.IzlenmeOrani);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };

            foreach (var kurs in kurslar)
            {
                string i;
                if (kurs.IzlenmeOrani == 100)
                {
                    i = " Tebrikler";
                    Console.WriteLine(kurs.KursAdi + " " + kurs.Egitmen + " " + kurs.IzlenmeOrani + " Tamamlandı" + i);
                }
                else
                {
                    Console.WriteLine(kurs.KursAdi + " " + kurs.Egitmen + " " + kurs.IzlenmeOrani + " Tamamlandı");
                }

            }


            Console.ReadLine();
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}

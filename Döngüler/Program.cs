using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirme Kursu";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "C++";
            string kurs5 = "Python";


            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);

            //array - dizi

            string[] kurslar = new string[] { "Yazılım Geliştirme Kursu", "Programlamaya başlangıç için temel kurs", "Java","Python","C++"};



            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For Bitti\n");
            
            foreach (string kurs in kurslar) //Dizilere uygulanır dizileri tek tek dolaşmaya yarıyor
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu");
            Console.ReadLine();
        }
    }
}

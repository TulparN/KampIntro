using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Customer customer1 = new Customer();
            //customer1.FirstName = "Engin";
            //customer1.SecondName = "Demiroğ";
            //customer1.Id = 1;
            //customer1.TcNo = "2222";
            //customer1.CustomerId = "11111";
            //customer1.CompanyName = "?";//sen şahıssın bu özelliğin burda olmaması gerekiyordu soyutlamada hata var

            //Gerçek - Tüzel iki nesnem var bunlar sırf bir birine benziyor diye bir birinin yerine kullanılamazlar
            //SOLID bu prensibi solidin l harfi söylüyor


            IndividualCustomer customer1 = new IndividualCustomer();

            customer1.FirstName = "Engin";
            customer1.SecondName = "Demiroğ";
            customer1.Id = 1;
            customer1.CustomerId = "112";
            customer1.TcNo = "12345";

            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.CompanyName = "Kodlama.ıo";
            customer2.Id = 2;
            customer2.CustomerId = "113";
            customer2.VergiNo = "13245";
            

            //customer sınıfı hem gerçek hem tüzel müşterinin referansını tutabiliyor
            Customer customer3 = new IndividualCustomer(); //gerçek müşteri bir yerde new görürsek o bellekte referans no sunu tutuyor anlamında
            Customer customer4 = new CorporateCustomer(); //tüzel müşteri
            
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);




        }
    }
}

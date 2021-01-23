using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class IndividualCustomer : Customer //Bireysel Müşteri
    {
       
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string TcNo { get; set; } //bir veri üzerinde matematiksel işlem yapmıyorsan bu verileri metinsel olarak tutmak daha sağlıklı
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class CorporateCustomer : Customer //Bu olaya inheritiance diyoruz yani miras //Tüzel Müşteri
    {
        
        public string CompanyName { get; set; }
        public string VergiNo { get; set; }//farklı ortamlarda çalışırken bunu yapmak veri uyumsuzluğunun önüne geçer
    }
}

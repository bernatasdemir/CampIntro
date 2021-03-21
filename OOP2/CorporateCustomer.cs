using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //tüzel müşteri
    // miras inheritance
    class CorporateCustomer:Customer
    {
        
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
    }
}

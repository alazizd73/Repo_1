using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Groep9_SE7
{
   public class Customer
    {
        public int ID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Address_1 { get; set; }
        public string Address_2 { get; set; }
        public string City { get; set; }
        public int? Country { get; set; }
        public string State { get; set; }
        public string Region { get; set; }
        public string Zip_Code { get; set; }
        public string Phone { get; set; }
        public string Company_Name { get; set; }
        public int? Type { get; set; }
        public char? Big_small { get; set; }
        public int? Max_Quantity_Order { get; set; }
        public decimal? Discount { get; set; }

    }
}

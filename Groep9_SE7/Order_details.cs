using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Groep9_SE7
{
   public class Order_Details
    {
        [Key]
        public int Order_detail_code { get; set; }
        public int Order_number { get; set; }
        public int Quantity { get; set; }
        public decimal? Unit_cost { get; set; }
        public decimal? Unit_price { get; set; }
        public decimal? Unit_sale_price { get; set; }
        public DateTime Ship_date { get; set; }
        public int Prod_ID { get; set; }
        public int? Dept_ID { get; set; }
    }
}

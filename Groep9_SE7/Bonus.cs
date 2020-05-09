using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Groep9_SE7 {
    public class Bonus {
        public int Emp_ID { get; set; }
        public DateTime Bonus_date { get; set; }
        public decimal Bonus_amount { get; set; }

        public override string ToString()
        {
            return $"${Bonus_amount} on {Bonus_date.ToShortDateString()}";
        }
    }
}

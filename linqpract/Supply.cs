using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqpract
{
    internal class Supply
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
        public string VendorName { get; set; }
        public int SupplyQuantity { get; set; }
        public double Price { get; set; }
    }
}

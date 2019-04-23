using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxCodeSample
{
    public class RegisterTape
    {
        public List<Product> _myProducts = new List<Product>();
        public double SalesTax { get; set; }

        public double SalesTotal { get; set; }
    }
}

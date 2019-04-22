using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxCodeSample
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal SalesTax { get; set; }
        public decimal ImportTax { get; set; }
        public bool Taxable { get; set; }
        public bool Imported { get; set; }
        public bool Calculated { get; set; }
        public int Quantity { get; set; }
        public string Type { get; set; }



        public void CalculateCost()
        {
            if (Quantity > 1)
            {
                TotalPrice = UnitPrice * Quantity;
            }
            if (Imported)
            {
                ImportTax = (UnitPrice * .05M);
                TotalPrice += ImportTax;
            }
            if (Taxable)
            {
                SalesTax = (TotalPrice * .1M);
                TotalPrice += SalesTax;
                TotalPrice = Utilities.Round(TotalPrice);
            }
            Calculated = true;


        }
    }
}

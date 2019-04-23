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
        public decimal BasePrice { get; set; }
        public decimal SalesTax { get; set; }
        public decimal ImportTax { get; set; }
        public bool Taxable { get; set; }
        public bool Imported { get; set; }
        public bool Calculated { get; set; }
        public int Quantity { get; set; }
        public string Type { get; set; }
               
        public void CalculateCost(bool RoundingOn)
        {
            Utilities util = new Utilities();
            BasePrice = UnitPrice;

            if (Type.ToUpper() != "FOOD" && Type.ToUpper() != "MEDICINE" && Type.ToUpper() != "BOOK")
            {
                if (Taxable)
                {
                    SalesTax = (UnitPrice * .1M);
                    UnitPrice += SalesTax;
                    UnitPrice = util.Round(UnitPrice, RoundingOn);
                }
            }
            if (Imported)
            {
                decimal UnitPriceImportTax = (BasePrice * .05m);
                ImportTax = util.Round(UnitPriceImportTax, true);
                UnitPrice += util.Round(UnitPriceImportTax, true);
            }
            if (Quantity > 1)
            {
                TotalPrice = UnitPrice * Quantity;
            }
            else
            {
                TotalPrice = UnitPrice;
            }
            Calculated = true;
        }
    }
}

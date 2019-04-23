using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxCodeSample
{
    public class InventoryEmulator
    {
        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();

            products.Add(LoadProduct(1, "book", 12.49m, 12.49m, 0.00m, 0.00m, false, false, false, 1, "BOOK"));
            products.Add(LoadProduct(2, "Music CD", 14.99m, 14.99m, 0.00m, 0.00m, true, false, false, 1, "TAXABLE"));
            products.Add(LoadProduct(3, "Chocolate bar", .85m, .85m, 0.00m, 0.00m, false, false, false, 1, "FOOD"));

            products.Add(LoadProduct(4, "Imported box of chocolates", 10.00m, 10.00m, 0.00m, 0.00m, false, true, false, 1, "FOOD"));
            products.Add(LoadProduct(5, "Imported bottle of perfume", 47.50m, 47.50m, 0.00m, 0.00m, true, true, false, 1, "TAXABLE"));

            products.Add(LoadProduct(6, "bottle of perfume", 18.99m, 18.99m, 0.00m, 0.00m, true, false, false, 1, "TAXABLE"));
            products.Add(LoadProduct(7, "packet of headache pills", 9.75m, 9.75m, 0.00m, 0.00m, false, false, false, 1, "MEDICINE"));
            products.Add(LoadProduct(8, "Imported bottle of perfume", 27.99m, 27.99m, 0.00m, 0.00m, true, true, false, 1, "TAXABLE"));
            products.Add(LoadProduct(4, "Imported box of chocolates", 11.25m, 11.25m, 0.00m, 0.00m, false, true, false, 1, "FOOD"));




            return products;
        }

        public void SaveProducts(List<Product> _list)
        {
            throw new NotImplementedException();
        }

        public Product LoadProduct(
            int Id,
            string Name,
            decimal TotalPrice,
            decimal UnitPrice,
            decimal SalesTax,
            decimal ImportTax,
            bool Taxable,
            bool Imported,
            bool Calculated,
            int Quantity,
            string Type)
        {
            return new Product
            {
                Id = Id,
                Name = Name,
                TotalPrice = TotalPrice,
                UnitPrice = UnitPrice,
                SalesTax = SalesTax,
                ImportTax = ImportTax,
                Taxable = Taxable,
                Imported = Imported,
                Calculated = Calculated,
                Quantity = Quantity,
                Type = Type
            };
            }
        }
    }

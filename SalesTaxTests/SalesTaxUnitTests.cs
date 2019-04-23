using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SalesTaxTests
{
    [TestClass]
    public class SalesTaxUnitTests
    {
        [TestMethod]
        public void TestRound()
        {
            bool RoundingOn = true;
            //Test each step of round up process to nearest 5 cents
            SalesTaxCodeSample.Utilities util = new SalesTaxCodeSample.Utilities();
            decimal[] tests = new decimal[5]; //
            tests[0] = 6.16m;
            tests[1] = 6.17m;
            tests[2] = 6.18m;
            tests[3] = 6.19m;
            tests[4] =  6.2m;
            for (int i = 0; i<=4; i++)
            {
                decimal result = util.Round(tests[i], RoundingOn);
                if(result != 6.2m)
                {
                    Assert.Fail();
                }
            }
        }

        [TestMethod]
        public void TestSalesTaxCalc()
        {
            bool RoundingOn = true;
            SalesTaxCodeSample.Product product = new SalesTaxCodeSample.Product();
            //Test Music CD value with Sales Tax
            product.Name = "Music CD";
            product.UnitPrice = 14.99m;
            product.TotalPrice = 14.99m;
            product.Type = "TAXABLE";
            product.Taxable = true;
            product.CalculateCost(RoundingOn);
            if (product.Calculated)
            {
                Assert.AreEqual(16.5m, product.TotalPrice);
            }
            else
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestNonTaxableItem()
        {
            bool RoundingOn = true;
            SalesTaxCodeSample.Product product = new SalesTaxCodeSample.Product();
            //Test with a book  should not calculate sales tax
            product.Name = "book";
            product.UnitPrice = 12.49m;
            product.TotalPrice = 12.49m;
            product.Taxable = false;
            product.Type = "BOOK";
            product.Imported = false;
            product.CalculateCost(RoundingOn);

            if (product.Calculated)
            {
                Assert.AreEqual(12.49m, product.TotalPrice);
            }
            else
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestMultipleItems()
        {
            bool RoundingOn = true;
            SalesTaxCodeSample.Product product = new SalesTaxCodeSample.Product();
            //Test with a book multiple items gets calculated correctly
            product.Name = "book";
            product.UnitPrice = 12.49m;
            product.TotalPrice = 12.49m;
            product.Taxable = false;
            product.Type = "BOOK";
            product.Imported = false;
            product.Quantity = 2;
            product.CalculateCost(RoundingOn);

            if (product.Calculated)
            {
                Assert.AreEqual(24.98m, product.TotalPrice);
            }
            else
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestImportedItem()
        {
            bool RoundingOn = true;
            SalesTaxCodeSample.Product product = new SalesTaxCodeSample.Product();
            //Test with bottle of perfume should calculate both import and sales taxes on this item
            product.Name = "Imported bottle of perfume";
            product.UnitPrice = 47.50m;
            product.TotalPrice = 47.50m;
            product.Taxable = true;
            product.Type = "TAXABLE";
            product.Imported = true;
            product.CalculateCost(RoundingOn);

            if (product.Calculated)
            {
                Assert.AreEqual(54.65m, product.TotalPrice);
            }
            else
            {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void TestImportedItemInQuantity()
        {
            bool RoundingOn = true;
            SalesTaxCodeSample.Product product = new SalesTaxCodeSample.Product();
            //Test with bottle of perfume should calculate both import and sales taxes on this item
            product.Name = "Imported bottle of perfume";
            product.UnitPrice = 47.50m;
            product.TotalPrice = 47.50m;
            product.Taxable = true;
            product.Type = "TAXABLE";
            product.Imported = true;
            product.Quantity = 2;
            product.CalculateCost(RoundingOn);

            if (product.Calculated)
            {
                Assert.AreEqual(109.30m, product.TotalPrice);
            }
            else
            {
                Assert.Fail();
            }
        }

        public void Test2ImportedItemInQuantity()
        {
            bool RoundingOn = true;
            SalesTaxCodeSample.Product product = new SalesTaxCodeSample.Product();
            //Test with bottle of perfume should calculate both import and sales taxes on this item
            product.Name = "Imported box of chocolates";
            product.UnitPrice = 11.25m;
            product.TotalPrice = 11.25m;
            product.Taxable = false;
            product.Type = "FOOD";
            product.Imported = true;
            product.Quantity = 2;
            product.CalculateCost(RoundingOn);

            if (product.Calculated)
            {
                Assert.AreEqual(23.70m, product.TotalPrice);
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}

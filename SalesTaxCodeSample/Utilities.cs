using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SalesTaxCodeSample
{
    public class Utilities
    {
        public void DisplayTape(ref ListView lvRegisterTape, ref Label SalesTaxValue, ref Label TotalCostValue, List<Product> _list, bool RoundingOn)
        {
            lvRegisterTape.Items.Clear();
            Utilities util = new Utilities();

            decimal SalesTaxTotal = 0M;
            decimal BasketTotal = 0M;

            foreach (Product product in _list)
            {
                if (!product.Calculated)
                {
                    product.CalculateCost(RoundingOn);
                }
                SalesTaxTotal += (product.SalesTax * product.Quantity);
                SalesTaxTotal += (product.ImportTax * product.Quantity);
                BasketTotal += product.TotalPrice;

                if (product.Quantity > 1)
                {
                    string UnitPrice = $"({product.Quantity} @ {util.FormattedAmount(product.UnitPrice)})";

                    var item01 = new ListViewItem(new[] { product.Name, util.FormattedAmount(product.TotalPrice), UnitPrice });
                    lvRegisterTape.Items.Add(item01);
                }
                else
                {
                    var item = new ListViewItem(new[] { product.Name, util.FormattedAmount(product.TotalPrice) });
                    lvRegisterTape.Items.Add(item);
                }
            }
            SalesTaxValue.Text = util.FormattedAmount(util.Round(SalesTaxTotal, RoundingOn));
            TotalCostValue.Text = util.FormattedAmount(BasketTotal);
        }

        public string FormattedAmount(decimal input)
        {
            return input.ToString("0.00");
        }

        public decimal Round(decimal input, bool RoundingOn)
        {
            if (RoundingOn)
            {
                var ceilingValue = Math.Ceiling(input * 20);
                if (ceilingValue == 0)
                {
                    return 0;
                }
                return ceilingValue / 20;
            }
            else
            {
                return input;
            }
        }
    }
}

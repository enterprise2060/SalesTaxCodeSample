using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesTaxCodeSample
{
    public partial class Form1 : Form
    {
        public int currentID = 0;
        public List<Product> _list = null;
        public Form1()
        {
            InitializeComponent();
            InitializeForm();
        }

        public void InitializeForm()
        {
            lvGM.Columns.Clear();
            lvGM.Columns.Add("ID", 30, HorizontalAlignment.Center);
            lvGM.Columns.Add("Name", 125, HorizontalAlignment.Left);
            lvGM.Columns.Add("Price", 125, HorizontalAlignment.Left);
            lvGM.View = View.Details;
            lvGM.FullRowSelect = true;

            lvFood.Columns.Clear();
            lvFood.Columns.Add("ID", 30, HorizontalAlignment.Center);
            lvFood.Columns.Add("Name", 125, HorizontalAlignment.Left);
            lvFood.Columns.Add("Price", 125, HorizontalAlignment.Left);
            lvFood.View = View.Details;
            lvFood.FullRowSelect = true;

            lvMedicine.Columns.Clear();
            lvMedicine.Columns.Add("ID", 30, HorizontalAlignment.Center);
            lvMedicine.Columns.Add("Name", 125, HorizontalAlignment.Left);
            lvMedicine.Columns.Add("Price", 125, HorizontalAlignment.Left);
            lvMedicine.View = View.Details;
            lvMedicine.FullRowSelect = true;

            lvBooks.Columns.Clear();
            lvBooks.Columns.Add("ID", 30, HorizontalAlignment.Center);
            lvBooks.Columns.Add("Name", 125, HorizontalAlignment.Left);
            lvBooks.Columns.Add("Price", 125, HorizontalAlignment.Left);
            lvBooks.View = View.Details;
            lvBooks.FullRowSelect = true;

            lvRegisterTape.Columns.Clear();
            lvRegisterTape.Columns.Add("Item", 100, HorizontalAlignment.Center);
            lvRegisterTape.Columns.Add("Price", 100, HorizontalAlignment.Left);
            lvRegisterTape.Columns.Add("Unit Price", 100, HorizontalAlignment.Left);
            lvRegisterTape.View = View.Details;
            lvRegisterTape.FullRowSelect = true;

            rbTaxable.Checked = true;

            _list = new List<Product>();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            currentID++;
            Product product = new Product { Id = currentID, Name = tbItemName.Text, TotalPrice = Convert.ToDecimal(tbCost.Text), UnitPrice = Convert.ToDecimal(tbCost.Text) };
            if (cbImported.Checked)
            {
                product.Imported = true;
            }

            var item = new ListViewItem(new[] { currentID.ToString(), tbItemName.Text,
                                tbCost.Text});

            if (rbTaxable.Checked)
            {
                product.Type = "TAXABLE";
                product.Taxable = true;
                item.Tag = product;
                lvGM.Items.Add(item);
            }
            if (rbFood.Checked)
            {
                product.Type = "FOOD";
                product.Taxable = false;
                item.Tag = product;
                lvFood.Items.Add(item);
            }
            if (rbMedical.Checked)
            {
                product.Type = "MEDICINE";
                product.Taxable = false;
                item.Tag = product;
                lvFood.Items.Add(item);
            }
            if (rbBooks.Checked)
            {
                product.Type = "BOOK";
                product.Taxable = false;
                item.Tag = product;
                lvBooks.Items.Add(item);
            }

            rbTaxable.Checked = true;
            tbItemName.Text = string.Empty;
            tbCost.Text = string.Empty;
            statusMSG.Text = "Enter the name of your new product";
            tbItemName.Select();

        }

        private void BtnGMToCart_Click(object sender, EventArgs e)
        {
            ListViewItem selected = lvGM.SelectedItems[0] as ListViewItem;
            Product product = selected.Tag as Product;
            //TODO figure if more than one item 
            if (!DuplicateItem(product))
            {
                product.Quantity = 1;
                _list.Add(product);
            }

            DisplayTape();
        }

        private void DisplayTape()
        {
            lvRegisterTape.Items.Clear();

            decimal SalesTaxTotal = 0M;
            decimal BasketTotal = 0M;

            foreach (Product product in _list)
            {
                if (!product.Calculated)
                {
                    product.CalculateCost();
                }
                SalesTaxTotal += product.SalesTax;
                BasketTotal += product.TotalPrice;
                if (product.Quantity > 1)
                {
                    string UnitPrice = $"({product.Quantity} @ {Utilities.FormattedAmount(product.UnitPrice)})";

                    var item01 = new ListViewItem(new[] { product.Name, Utilities.FormattedAmount(product.TotalPrice), UnitPrice });
                    lvRegisterTape.Items.Add(item01);
                }
                else
                {

                    var item = new ListViewItem(new[] { product.Name, Utilities.FormattedAmount(product.TotalPrice) });
                    lvRegisterTape.Items.Add(item);
                }
            }

            lbSalesTaxValue.Text = Utilities.FormattedAmount(SalesTaxTotal);
            lbTotalValue.Text = Utilities.FormattedAmount(BasketTotal);
        }

        private bool DuplicateItem(Product newproduct)
        {
            foreach (Product product in _list)
            {

                if (product.Id == newproduct.Id)
                {
                    product.Quantity += 1;
                    product.TotalPrice += newproduct.UnitPrice;
                    return true;
                }
            }
            return false;
        }

        private void TbItemName_TextChanged(object sender, EventArgs e)
        {
            if (tbItemName.Text.ToUpper().Contains("IMPORTED"))
            {
                cbImported.Checked = true;
            }
            if (tbItemName.Text.ToUpper().Contains("BOOK"))
            {
                rbBooks.Checked = true;
            }
            if (tbItemName.Text.ToUpper().Contains("MEDICINE"))
            {
                rbMedical.Checked = true;
            }
            if (tbItemName.Text.ToUpper().Contains("FOOD"))
            {
                rbFood.Checked = true;
            }
        }

        private void BtnAddFoodToCart_Click(object sender, EventArgs e)
        {
            ListViewItem selected = lvFood.SelectedItems[0] as ListViewItem;
            Product product = selected.Tag as Product;
            //TODO figure if more than one item 
            if (!DuplicateItem(product))
            {
                product.Quantity = 1;
                _list.Add(product);
            }

            DisplayTape();
        }

        private void BtnAddMedicineToCart_Click(object sender, EventArgs e)
        {
            ListViewItem selected = lvMedicine.SelectedItems[0] as ListViewItem;
            Product product = selected.Tag as Product;
            //TODO figure if more than one item 
            if (!DuplicateItem(product))
            {
                product.Quantity = 1;
                _list.Add(product);
            }

            DisplayTape();
        }

        private void BtnAddImportedGoodsToCart_Click(object sender, EventArgs e)
        {
            ListViewItem selected = lvBooks.SelectedItems[0] as ListViewItem;
            Product product = selected.Tag as Product;
            //TODO figure if more than one item 
            if (!DuplicateItem(product))
            {
                product.Quantity = 1;
                _list.Add(product);
            }

            DisplayTape();
        }

        private void TestingRoundingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            decimal value = 6.20M;
            MessageBox.Show(Utilities.Round(value).ToString());
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            _list.Clear();
            lvRegisterTape.Items.Clear();
            lbSalesTax.Text = "0.00";
        }

        //public decimal Round(decimal value)
        //{
        //    var ceiling = Math.Ceiling(value * 20);
        //    if(ceiling == 0) {
        //        return 0;
        //    }
        //    return ceiling / 20;
        //}
    }
}

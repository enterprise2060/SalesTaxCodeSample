using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SalesTaxCodeSample
{
    public partial class Form1 : Form
    {
        #region Public Properties

        public int currentID = 0;
        public List<Product> _list = null;
        public bool RoundingOn = false;

        #endregion Public Properties

        #region Form Events

        public Form1()
        {
            InitializeComponent();
            InitializeForm();
        }
        /// <summary>
        /// Used to define the ListViews for use in the app
        /// </summary>
        public void InitializeForm()
        {
            lvGM.Columns.Clear();
            lvGM.Columns.Add("ID", 30, HorizontalAlignment.Center);
            lvGM.Columns.Add("Name", 200, HorizontalAlignment.Left);
            lvGM.Columns.Add("Price", 125, HorizontalAlignment.Left);
            lvGM.View = View.Details;
            lvGM.FullRowSelect = true;

            lvFood.Columns.Clear();
            lvFood.Columns.Add("ID", 30, HorizontalAlignment.Center);
            lvFood.Columns.Add("Name", 200, HorizontalAlignment.Left);
            lvFood.Columns.Add("Price", 125, HorizontalAlignment.Left);
            lvFood.View = View.Details;
            lvFood.FullRowSelect = true;

            lvMedicine.Columns.Clear();
            lvMedicine.Columns.Add("ID", 30, HorizontalAlignment.Center);
            lvMedicine.Columns.Add("Name", 200, HorizontalAlignment.Left);
            lvMedicine.Columns.Add("Price", 125, HorizontalAlignment.Left);
            lvMedicine.View = View.Details;
            lvMedicine.FullRowSelect = true;

            lvBooks.Columns.Clear();
            lvBooks.Columns.Add("ID", 30, HorizontalAlignment.Center);
            lvBooks.Columns.Add("Name", 200, HorizontalAlignment.Left);
            lvBooks.Columns.Add("Price", 125, HorizontalAlignment.Left);
            lvBooks.View = View.Details;
            lvBooks.FullRowSelect = true;

            lvRegisterTape.Columns.Clear();
            lvRegisterTape.Columns.Add("Item", 200, HorizontalAlignment.Left);
            lvRegisterTape.Columns.Add("Price", 80, HorizontalAlignment.Right);
            lvRegisterTape.Columns.Add("Unit Price", 80, HorizontalAlignment.Right);
            lvRegisterTape.View = View.Details;
            lvRegisterTape.FullRowSelect = true;

            rbTaxable.Checked = true;
            cbUseRounding.Checked = false;
            
            _list = new List<Product>();
        }

        #endregion Form Events

        #region Controls

        private void BtnAddFoodToCart_Click(object sender, EventArgs e)
        {
            ListViewItem selected = lvFood.SelectedItems[0] as ListViewItem;
            AddProduct(selected.Tag as Product);
        }

        private void BtnAddGMToCart_Click(object sender, EventArgs e)
        {
            ListViewItem selected = lvGM.SelectedItems[0] as ListViewItem;
            AddProduct(selected.Tag as Product);
        }

        private void BtnAddMedicineToCart_Click(object sender, EventArgs e)
        {
            ListViewItem selected = lvMedicine.SelectedItems[0] as ListViewItem;
            AddProduct(selected.Tag as Product);
        }

        private void BtnAddBookToCart_Click(object sender, EventArgs e)
        {
            ListViewItem selected = lvBooks.SelectedItems[0] as ListViewItem;
            AddProduct(selected.Tag as Product);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            _list.Clear();
            lvRegisterTape.Items.Clear();
            lbSalesTax.Text = "0.00";
            lbTotalValue.Text = "0.00";
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateProduct()) return;
            currentID++;
            Product product = new Product { Id = currentID, Name = tbItemName.Text, TotalPrice = Convert.ToDecimal(tbCost.Text), UnitPrice = Convert.ToDecimal(tbCost.Text) };
            if (rbTaxable.Checked)
            {
                product.Type = "TAXABLE";
            }
            if (rbBooks.Checked)
            {
                product.Type = "BOOK";
            }
            if (rbFood.Checked)
            {
                product.Type = "FOOD";
            }
            if (rbMedical.Checked)
            {
                product.Type = "MEDICINE";

            }
            AddProductToSection(product);
            rbTaxable.Checked = true;
            tbItemName.Text = string.Empty;
            tbCost.Text = string.Empty;
            statusMSG.Text = "Enter the name of your new product";
            tbItemName.Select();

        }

        private void LoadEmulatedDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                InventoryEmulator ie = new InventoryEmulator();
                List<Product> products = ie.GetProducts();

                foreach (Product product in products)
                {
                    AddProductToSection(product);
                    currentID++; //Allow user to add on their own data to prefil list
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }


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

        #endregion Controls

        #region Form Methods

        private void AddProduct(Product product)
        {
            if (!DuplicateItem(product))
            {
                product.Quantity = 1;
                _list.Add(product);
            }
            DisplayTape();
        }

        private void AddProductToSection(Product product)
        {
            if (cbImported.Checked)
            {
                product.Imported = true;
            }
            var item = new ListViewItem(new[] { product.Id.ToString(), product.Name,
                                product.TotalPrice.ToString()});
            switch (product.Type.ToUpper())
            {
                case "TAXABLE":
                    product.Taxable = true;
                    item.Tag = product;
                    lvGM.Items.Add(item);
                    break;
                case "FOOD":
                    product.Taxable = false;
                    item.Tag = product;
                    lvFood.Items.Add(item);
                    break;
                case "MEDICINE":
                    product.Taxable = false;
                    item.Tag = product;
                    lvMedicine.Items.Add(item);
                    break;
                case "BOOK":
                    product.Taxable = false;
                    item.Tag = product;
                    lvBooks.Items.Add(item);
                    break;
            }
        }

        private void DisplayTape()
        {
            Utilities util = new Utilities();
            util.DisplayTape(ref lvRegisterTape, ref lbSalesTaxValue, ref lbTotalValue, _list, RoundingOn);
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

        private bool ValidateProduct()
        {
            try
            {
                if (string.IsNullOrEmpty(tbItemName.Text))
                {
                    statusMSG.Text = "Please provide the product name before continuing...";
                    tbItemName.Select();
                    return false;
                }
                if (string.IsNullOrEmpty(tbCost.Text))
                {
                    statusMSG.Text = "Please provide the product cost before continuing...";
                    tbCost.Select();
                    return false;
                }
                else
                {
                    decimal number;
                    if (Decimal.TryParse(tbCost.Text, out number))
                    {
                        statusMSG.Text = $"The item's cost will be {number}";
                    }
                    else
                    {
                        statusMSG.Text = "Please enter a legitimate cost value...";
                        return false;
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }

        }

        #endregion FormMethods

        private void cbUseRounding_CheckedChanged(object sender, EventArgs e)
        {
            if(cbUseRounding.Checked)
            {
                RoundingOn = true;
            }
            else
            {
                RoundingOn = false;
            }
        }
    }
}

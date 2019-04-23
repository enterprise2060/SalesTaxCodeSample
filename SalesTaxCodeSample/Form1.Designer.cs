namespace SalesTaxCodeSample
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testingRoundingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cashRegisterStatusStrip = new System.Windows.Forms.StatusStrip();
            this.statusMSG = new System.Windows.Forms.ToolStripStatusLabel();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpGeneralMerchandise = new System.Windows.Forms.TabPage();
            this.btnGMToCart = new System.Windows.Forms.Button();
            this.lvGM = new System.Windows.Forms.ListView();
            this.lbSelectGM = new System.Windows.Forms.Label();
            this.tpFood = new System.Windows.Forms.TabPage();
            this.btnAddFoodToCart = new System.Windows.Forms.Button();
            this.lvFood = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.tpMedical = new System.Windows.Forms.TabPage();
            this.btnAddMedicineToCart = new System.Windows.Forms.Button();
            this.lvMedicine = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.tpBooks = new System.Windows.Forms.TabPage();
            this.btnAddImportedGoodsToCart = new System.Windows.Forms.Button();
            this.lvBooks = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.tpAdmin = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbImported = new System.Windows.Forms.CheckBox();
            this.rbBooks = new System.Windows.Forms.RadioButton();
            this.rbMedical = new System.Windows.Forms.RadioButton();
            this.rbFood = new System.Windows.Forms.RadioButton();
            this.rbTaxable = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbItemName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.gbRegisterOutput = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lbTotalValue = new System.Windows.Forms.Label();
            this.lbSalesTaxValue = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbSalesTax = new System.Windows.Forms.Label();
            this.lvRegisterTape = new System.Windows.Forms.ListView();
            this.cmsGM = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.purchaseItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbUseRounding = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.cashRegisterStatusStrip.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tpGeneralMerchandise.SuspendLayout();
            this.tpFood.SuspendLayout();
            this.tpMedical.SuspendLayout();
            this.tpBooks.SuspendLayout();
            this.tpAdmin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbRegisterOutput.SuspendLayout();
            this.cmsGM.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1343, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(141, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(141, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.testingRoundingToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // testingRoundingToolStripMenuItem
            // 
            this.testingRoundingToolStripMenuItem.Name = "testingRoundingToolStripMenuItem";
            this.testingRoundingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.testingRoundingToolStripMenuItem.Text = "Pre-Fill Sample Data";
            this.testingRoundingToolStripMenuItem.Click += new System.EventHandler(this.LoadEmulatedDataToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(119, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // cashRegisterStatusStrip
            // 
            this.cashRegisterStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusMSG});
            this.cashRegisterStatusStrip.Location = new System.Drawing.Point(0, 428);
            this.cashRegisterStatusStrip.Name = "cashRegisterStatusStrip";
            this.cashRegisterStatusStrip.Size = new System.Drawing.Size(1343, 22);
            this.cashRegisterStatusStrip.TabIndex = 1;
            this.cashRegisterStatusStrip.Text = "Ready...";
            // 
            // statusMSG
            // 
            this.statusMSG.Name = "statusMSG";
            this.statusMSG.Size = new System.Drawing.Size(48, 17);
            this.statusMSG.Text = "Ready...";
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpGeneralMerchandise);
            this.tcMain.Controls.Add(this.tpFood);
            this.tcMain.Controls.Add(this.tpMedical);
            this.tcMain.Controls.Add(this.tpBooks);
            this.tcMain.Controls.Add(this.tpAdmin);
            this.tcMain.Location = new System.Drawing.Point(21, 41);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(690, 302);
            this.tcMain.TabIndex = 2;
            // 
            // tpGeneralMerchandise
            // 
            this.tpGeneralMerchandise.Controls.Add(this.btnGMToCart);
            this.tpGeneralMerchandise.Controls.Add(this.lvGM);
            this.tpGeneralMerchandise.Controls.Add(this.lbSelectGM);
            this.tpGeneralMerchandise.Location = new System.Drawing.Point(4, 22);
            this.tpGeneralMerchandise.Name = "tpGeneralMerchandise";
            this.tpGeneralMerchandise.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneralMerchandise.Size = new System.Drawing.Size(682, 276);
            this.tpGeneralMerchandise.TabIndex = 0;
            this.tpGeneralMerchandise.Text = "General Merchandise";
            this.tpGeneralMerchandise.UseVisualStyleBackColor = true;
            // 
            // btnGMToCart
            // 
            this.btnGMToCart.Location = new System.Drawing.Point(589, 29);
            this.btnGMToCart.Name = "btnGMToCart";
            this.btnGMToCart.Size = new System.Drawing.Size(75, 23);
            this.btnGMToCart.TabIndex = 2;
            this.btnGMToCart.Text = "Add To Cart";
            this.btnGMToCart.UseVisualStyleBackColor = true;
            this.btnGMToCart.Click += new System.EventHandler(this.BtnAddGMToCart_Click);
            // 
            // lvGM
            // 
            this.lvGM.Location = new System.Drawing.Point(20, 30);
            this.lvGM.MultiSelect = false;
            this.lvGM.Name = "lvGM";
            this.lvGM.Size = new System.Drawing.Size(516, 210);
            this.lvGM.TabIndex = 1;
            this.lvGM.UseCompatibleStateImageBehavior = false;
            // 
            // lbSelectGM
            // 
            this.lbSelectGM.AutoSize = true;
            this.lbSelectGM.Location = new System.Drawing.Point(21, 13);
            this.lbSelectGM.Name = "lbSelectGM";
            this.lbSelectGM.Size = new System.Drawing.Size(85, 13);
            this.lbSelectGM.TabIndex = 0;
            this.lbSelectGM.Text = "Select Products:";
            // 
            // tpFood
            // 
            this.tpFood.Controls.Add(this.btnAddFoodToCart);
            this.tpFood.Controls.Add(this.lvFood);
            this.tpFood.Controls.Add(this.label3);
            this.tpFood.Location = new System.Drawing.Point(4, 22);
            this.tpFood.Name = "tpFood";
            this.tpFood.Padding = new System.Windows.Forms.Padding(3);
            this.tpFood.Size = new System.Drawing.Size(682, 276);
            this.tpFood.TabIndex = 1;
            this.tpFood.Text = "Food";
            this.tpFood.UseVisualStyleBackColor = true;
            // 
            // btnAddFoodToCart
            // 
            this.btnAddFoodToCart.Location = new System.Drawing.Point(542, 30);
            this.btnAddFoodToCart.Name = "btnAddFoodToCart";
            this.btnAddFoodToCart.Size = new System.Drawing.Size(75, 23);
            this.btnAddFoodToCart.TabIndex = 5;
            this.btnAddFoodToCart.Text = "Add To Cart";
            this.btnAddFoodToCart.UseVisualStyleBackColor = true;
            this.btnAddFoodToCart.Click += new System.EventHandler(this.BtnAddFoodToCart_Click);
            // 
            // lvFood
            // 
            this.lvFood.Location = new System.Drawing.Point(20, 30);
            this.lvFood.Name = "lvFood";
            this.lvFood.Size = new System.Drawing.Size(516, 201);
            this.lvFood.TabIndex = 4;
            this.lvFood.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select Products:";
            // 
            // tpMedical
            // 
            this.tpMedical.Controls.Add(this.btnAddMedicineToCart);
            this.tpMedical.Controls.Add(this.lvMedicine);
            this.tpMedical.Controls.Add(this.label4);
            this.tpMedical.Location = new System.Drawing.Point(4, 22);
            this.tpMedical.Name = "tpMedical";
            this.tpMedical.Padding = new System.Windows.Forms.Padding(3);
            this.tpMedical.Size = new System.Drawing.Size(682, 276);
            this.tpMedical.TabIndex = 2;
            this.tpMedical.Text = "Medical";
            this.tpMedical.UseVisualStyleBackColor = true;
            // 
            // btnAddMedicineToCart
            // 
            this.btnAddMedicineToCart.Location = new System.Drawing.Point(601, 28);
            this.btnAddMedicineToCart.Name = "btnAddMedicineToCart";
            this.btnAddMedicineToCart.Size = new System.Drawing.Size(75, 23);
            this.btnAddMedicineToCart.TabIndex = 5;
            this.btnAddMedicineToCart.Text = "Add To Cart";
            this.btnAddMedicineToCart.UseVisualStyleBackColor = true;
            this.btnAddMedicineToCart.Click += new System.EventHandler(this.BtnAddMedicineToCart_Click);
            // 
            // lvMedicine
            // 
            this.lvMedicine.Location = new System.Drawing.Point(20, 30);
            this.lvMedicine.Name = "lvMedicine";
            this.lvMedicine.Size = new System.Drawing.Size(516, 210);
            this.lvMedicine.TabIndex = 4;
            this.lvMedicine.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Select Products:";
            // 
            // tpBooks
            // 
            this.tpBooks.Controls.Add(this.btnAddImportedGoodsToCart);
            this.tpBooks.Controls.Add(this.lvBooks);
            this.tpBooks.Controls.Add(this.label5);
            this.tpBooks.Location = new System.Drawing.Point(4, 22);
            this.tpBooks.Name = "tpBooks";
            this.tpBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tpBooks.Size = new System.Drawing.Size(682, 276);
            this.tpBooks.TabIndex = 3;
            this.tpBooks.Text = "Books";
            this.tpBooks.UseVisualStyleBackColor = true;
            // 
            // btnAddImportedGoodsToCart
            // 
            this.btnAddImportedGoodsToCart.Location = new System.Drawing.Point(582, 28);
            this.btnAddImportedGoodsToCart.Name = "btnAddImportedGoodsToCart";
            this.btnAddImportedGoodsToCart.Size = new System.Drawing.Size(75, 23);
            this.btnAddImportedGoodsToCart.TabIndex = 5;
            this.btnAddImportedGoodsToCart.Text = "Add To Cart";
            this.btnAddImportedGoodsToCart.UseVisualStyleBackColor = true;
            this.btnAddImportedGoodsToCart.Click += new System.EventHandler(this.BtnAddBookToCart_Click);
            // 
            // lvBooks
            // 
            this.lvBooks.Location = new System.Drawing.Point(20, 30);
            this.lvBooks.Name = "lvBooks";
            this.lvBooks.Size = new System.Drawing.Size(516, 210);
            this.lvBooks.TabIndex = 4;
            this.lvBooks.UseCompatibleStateImageBehavior = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Select Products:";
            // 
            // tpAdmin
            // 
            this.tpAdmin.Controls.Add(this.cbUseRounding);
            this.tpAdmin.Controls.Add(this.groupBox1);
            this.tpAdmin.Location = new System.Drawing.Point(4, 22);
            this.tpAdmin.Name = "tpAdmin";
            this.tpAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tpAdmin.Size = new System.Drawing.Size(682, 276);
            this.tpAdmin.TabIndex = 4;
            this.tpAdmin.Text = "Admin";
            this.tpAdmin.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbImported);
            this.groupBox1.Controls.Add(this.rbBooks);
            this.groupBox1.Controls.Add(this.rbMedical);
            this.groupBox1.Controls.Add(this.rbFood);
            this.groupBox1.Controls.Add(this.rbTaxable);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbItemName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbCost);
            this.groupBox1.Location = new System.Drawing.Point(23, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 131);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add|Edit Product";
            // 
            // cbImported
            // 
            this.cbImported.AutoSize = true;
            this.cbImported.Location = new System.Drawing.Point(70, 98);
            this.cbImported.Name = "cbImported";
            this.cbImported.Size = new System.Drawing.Size(67, 17);
            this.cbImported.TabIndex = 13;
            this.cbImported.Text = "Imported";
            this.cbImported.UseVisualStyleBackColor = true;
            // 
            // rbBooks
            // 
            this.rbBooks.AutoSize = true;
            this.rbBooks.Location = new System.Drawing.Point(286, 74);
            this.rbBooks.Name = "rbBooks";
            this.rbBooks.Size = new System.Drawing.Size(50, 17);
            this.rbBooks.TabIndex = 12;
            this.rbBooks.Text = "Book";
            this.rbBooks.UseVisualStyleBackColor = true;
            // 
            // rbMedical
            // 
            this.rbMedical.AutoSize = true;
            this.rbMedical.Location = new System.Drawing.Point(218, 74);
            this.rbMedical.Name = "rbMedical";
            this.rbMedical.Size = new System.Drawing.Size(62, 17);
            this.rbMedical.TabIndex = 11;
            this.rbMedical.Text = "Medical";
            this.rbMedical.UseVisualStyleBackColor = true;
            // 
            // rbFood
            // 
            this.rbFood.AutoSize = true;
            this.rbFood.Location = new System.Drawing.Point(151, 75);
            this.rbFood.Name = "rbFood";
            this.rbFood.Size = new System.Drawing.Size(49, 17);
            this.rbFood.TabIndex = 10;
            this.rbFood.Text = "Food";
            this.rbFood.UseVisualStyleBackColor = true;
            // 
            // rbTaxable
            // 
            this.rbTaxable.AutoSize = true;
            this.rbTaxable.Checked = true;
            this.rbTaxable.Location = new System.Drawing.Point(70, 75);
            this.rbTaxable.Name = "rbTaxable";
            this.rbTaxable.Size = new System.Drawing.Size(63, 17);
            this.rbTaxable.TabIndex = 9;
            this.rbTaxable.TabStop = true;
            this.rbTaxable.Text = "Taxable";
            this.rbTaxable.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(390, 22);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // tbItemName
            // 
            this.tbItemName.Location = new System.Drawing.Point(70, 22);
            this.tbItemName.MaxLength = 50;
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.Size = new System.Drawing.Size(305, 20);
            this.tbItemName.TabIndex = 1;
            this.tbItemName.TextChanged += new System.EventHandler(this.TbItemName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cost:";
            // 
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(70, 48);
            this.tbCost.MaxLength = 10;
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(305, 20);
            this.tbCost.TabIndex = 3;
            // 
            // gbRegisterOutput
            // 
            this.gbRegisterOutput.Controls.Add(this.btnClear);
            this.gbRegisterOutput.Controls.Add(this.lbTotalValue);
            this.gbRegisterOutput.Controls.Add(this.lbSalesTaxValue);
            this.gbRegisterOutput.Controls.Add(this.label7);
            this.gbRegisterOutput.Controls.Add(this.lbSalesTax);
            this.gbRegisterOutput.Controls.Add(this.lvRegisterTape);
            this.gbRegisterOutput.Location = new System.Drawing.Point(802, 27);
            this.gbRegisterOutput.Name = "gbRegisterOutput";
            this.gbRegisterOutput.Size = new System.Drawing.Size(511, 384);
            this.gbRegisterOutput.TabIndex = 3;
            this.gbRegisterOutput.TabStop = false;
            this.gbRegisterOutput.Text = "Register Tape";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(232, 342);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 24);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // lbTotalValue
            // 
            this.lbTotalValue.AutoSize = true;
            this.lbTotalValue.Location = new System.Drawing.Point(106, 354);
            this.lbTotalValue.Name = "lbTotalValue";
            this.lbTotalValue.Size = new System.Drawing.Size(13, 13);
            this.lbTotalValue.TabIndex = 4;
            this.lbTotalValue.Text = "0";
            this.lbTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSalesTaxValue
            // 
            this.lbSalesTaxValue.AutoSize = true;
            this.lbSalesTaxValue.Location = new System.Drawing.Point(106, 332);
            this.lbSalesTaxValue.Name = "lbSalesTaxValue";
            this.lbSalesTaxValue.Size = new System.Drawing.Size(13, 13);
            this.lbSalesTaxValue.TabIndex = 3;
            this.lbSalesTaxValue.Text = "0";
            this.lbSalesTaxValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Total:";
            // 
            // lbSalesTax
            // 
            this.lbSalesTax.AutoSize = true;
            this.lbSalesTax.Location = new System.Drawing.Point(36, 332);
            this.lbSalesTax.Name = "lbSalesTax";
            this.lbSalesTax.Size = new System.Drawing.Size(57, 13);
            this.lbSalesTax.TabIndex = 1;
            this.lbSalesTax.Text = "Sales Tax:";
            // 
            // lvRegisterTape
            // 
            this.lvRegisterTape.Location = new System.Drawing.Point(21, 35);
            this.lvRegisterTape.Name = "lvRegisterTape";
            this.lvRegisterTape.Size = new System.Drawing.Size(445, 283);
            this.lvRegisterTape.TabIndex = 0;
            this.lvRegisterTape.UseCompatibleStateImageBehavior = false;
            // 
            // cmsGM
            // 
            this.cmsGM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseItemToolStripMenuItem});
            this.cmsGM.Name = "cmsGM";
            this.cmsGM.Size = new System.Drawing.Size(150, 26);
            // 
            // purchaseItemToolStripMenuItem
            // 
            this.purchaseItemToolStripMenuItem.Name = "purchaseItemToolStripMenuItem";
            this.purchaseItemToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.purchaseItemToolStripMenuItem.Text = "Purchase Item";
            // 
            // cbUseRounding
            // 
            this.cbUseRounding.AutoSize = true;
            this.cbUseRounding.Location = new System.Drawing.Point(34, 20);
            this.cbUseRounding.Name = "cbUseRounding";
            this.cbUseRounding.Size = new System.Drawing.Size(94, 17);
            this.cbUseRounding.TabIndex = 9;
            this.cbUseRounding.Text = "Use Rounding";
            this.cbUseRounding.UseVisualStyleBackColor = true;
            this.cbUseRounding.CheckedChanged += new System.EventHandler(this.cbUseRounding_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 450);
            this.Controls.Add(this.gbRegisterOutput);
            this.Controls.Add(this.cashRegisterStatusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tcMain);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "DealerOn Lobby Gift Shop";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.cashRegisterStatusStrip.ResumeLayout(false);
            this.cashRegisterStatusStrip.PerformLayout();
            this.tcMain.ResumeLayout(false);
            this.tpGeneralMerchandise.ResumeLayout(false);
            this.tpGeneralMerchandise.PerformLayout();
            this.tpFood.ResumeLayout(false);
            this.tpFood.PerformLayout();
            this.tpMedical.ResumeLayout(false);
            this.tpMedical.PerformLayout();
            this.tpBooks.ResumeLayout(false);
            this.tpBooks.PerformLayout();
            this.tpAdmin.ResumeLayout(false);
            this.tpAdmin.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbRegisterOutput.ResumeLayout(false);
            this.gbRegisterOutput.PerformLayout();
            this.cmsGM.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip cashRegisterStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusMSG;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpGeneralMerchandise;
        private System.Windows.Forms.TabPage tpFood;
        private System.Windows.Forms.TabPage tpMedical;
        private System.Windows.Forms.TabPage tpBooks;
        private System.Windows.Forms.TabPage tpAdmin;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbItemName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbRegisterOutput;
        private System.Windows.Forms.ListView lvGM;
        private System.Windows.Forms.Label lbSelectGM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnGMToCart;
        private System.Windows.Forms.Button btnAddFoodToCart;
        private System.Windows.Forms.ListView lvFood;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddMedicineToCart;
        private System.Windows.Forms.ListView lvMedicine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddImportedGoodsToCart;
        private System.Windows.Forms.ListView lvBooks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lvRegisterTape;
        private System.Windows.Forms.RadioButton rbBooks;
        private System.Windows.Forms.RadioButton rbMedical;
        private System.Windows.Forms.RadioButton rbFood;
        private System.Windows.Forms.RadioButton rbTaxable;
        private System.Windows.Forms.ContextMenuStrip cmsGM;
        private System.Windows.Forms.ToolStripMenuItem purchaseItemToolStripMenuItem;
        private System.Windows.Forms.CheckBox cbImported;
        private System.Windows.Forms.ToolStripMenuItem testingRoundingToolStripMenuItem;
        private System.Windows.Forms.Label lbTotalValue;
        private System.Windows.Forms.Label lbSalesTaxValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbSalesTax;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox cbUseRounding;
    }
}


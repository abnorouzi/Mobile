namespace Mobile
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.حسابداریToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.صدورقبضToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.خریدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.سودوزیانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.خدماتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مشتریToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.فاکتورToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpbProduct = new System.Windows.Forms.GroupBox();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.cmbCat = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.grpbSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbSearchCat = new System.Windows.Forms.ComboBox();
            this.rdiCat = new System.Windows.Forms.RadioButton();
            this.rdiName = new System.Windows.Forms.RadioButton();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.dgProduct = new System.Windows.Forms.DataGridView();
            this.rcProductMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.mnuMain.SuspendLayout();
            this.grpbProduct.SuspendLayout();
            this.grpbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.حسابداریToolStripMenuItem,
            this.مشتریToolStripMenuItem,
            this.فاکتورToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(5, 5);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(974, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "mnuMain";
            // 
            // حسابداریToolStripMenuItem
            // 
            this.حسابداریToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.صدورقبضToolStripMenuItem,
            this.خریدToolStripMenuItem,
            this.سودوزیانToolStripMenuItem,
            this.خدماتToolStripMenuItem});
            this.حسابداریToolStripMenuItem.Name = "حسابداریToolStripMenuItem";
            this.حسابداریToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.حسابداریToolStripMenuItem.Text = "حسابداری";
            // 
            // صدورقبضToolStripMenuItem
            // 
            this.صدورقبضToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.صدورقبضToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.صدورقبضToolStripMenuItem.Name = "صدورقبضToolStripMenuItem";
            this.صدورقبضToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.صدورقبضToolStripMenuItem.Text = "صدور قبض";
            this.صدورقبضToolStripMenuItem.Click += new System.EventHandler(this.صدورقبضToolStripMenuItem_Click);
            // 
            // خریدToolStripMenuItem
            // 
            this.خریدToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.خریدToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.خریدToolStripMenuItem.Name = "خریدToolStripMenuItem";
            this.خریدToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.خریدToolStripMenuItem.Text = "خرید";
            this.خریدToolStripMenuItem.Click += new System.EventHandler(this.خریدToolStripMenuItem_Click);
            // 
            // سودوزیانToolStripMenuItem
            // 
            this.سودوزیانToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.سودوزیانToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.سودوزیانToolStripMenuItem.Name = "سودوزیانToolStripMenuItem";
            this.سودوزیانToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.سودوزیانToolStripMenuItem.Text = "سود و زیان";
            // 
            // خدماتToolStripMenuItem
            // 
            this.خدماتToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.خدماتToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.خدماتToolStripMenuItem.Name = "خدماتToolStripMenuItem";
            this.خدماتToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.خدماتToolStripMenuItem.Text = "دستمزد";
            this.خدماتToolStripMenuItem.Click += new System.EventHandler(this.خدماتToolStripMenuItem_Click);
            // 
            // مشتریToolStripMenuItem
            // 
            this.مشتریToolStripMenuItem.Name = "مشتریToolStripMenuItem";
            this.مشتریToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.مشتریToolStripMenuItem.Text = "مشتری";
            this.مشتریToolStripMenuItem.Click += new System.EventHandler(this.مشتریToolStripMenuItem_Click);
            // 
            // فاکتورToolStripMenuItem
            // 
            this.فاکتورToolStripMenuItem.Name = "فاکتورToolStripMenuItem";
            this.فاکتورToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.فاکتورToolStripMenuItem.Text = "فاکتور";
            this.فاکتورToolStripMenuItem.Click += new System.EventHandler(this.فاکتورToolStripMenuItem_Click);
            // 
            // grpbProduct
            // 
            this.grpbProduct.Controls.Add(this.label5);
            this.grpbProduct.Controls.Add(this.btnEditProduct);
            this.grpbProduct.Controls.Add(this.label4);
            this.grpbProduct.Controls.Add(this.label3);
            this.grpbProduct.Controls.Add(this.label2);
            this.grpbProduct.Controls.Add(this.label1);
            this.grpbProduct.Controls.Add(this.txtPrice);
            this.grpbProduct.Controls.Add(this.txtDesc);
            this.grpbProduct.Controls.Add(this.cmbCat);
            this.grpbProduct.Controls.Add(this.txtAmount);
            this.grpbProduct.Controls.Add(this.txtName);
            this.grpbProduct.Controls.Add(this.btnAddProduct);
            this.grpbProduct.ForeColor = System.Drawing.Color.Silver;
            this.grpbProduct.Location = new System.Drawing.Point(644, 32);
            this.grpbProduct.Name = "grpbProduct";
            this.grpbProduct.Size = new System.Drawing.Size(332, 406);
            this.grpbProduct.TabIndex = 1;
            this.grpbProduct.TabStop = false;
            this.grpbProduct.Text = "افزودن کالا";
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEditProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEditProduct.Location = new System.Drawing.Point(13, 161);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(75, 31);
            this.btnEditProduct.TabIndex = 10;
            this.btnEditProduct.Text = "ویرایش";
            this.btnEditProduct.UseVisualStyleBackColor = false;
            this.btnEditProduct.Visible = false;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "قیمت";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "تعداد";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "نام کالا";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "توضیحات";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(114, 173);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(139, 23);
            this.txtPrice.TabIndex = 5;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(103, 230);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(193, 161);
            this.txtDesc.TabIndex = 4;
            // 
            // cmbCat
            // 
            this.cmbCat.FormattingEnabled = true;
            this.cmbCat.Items.AddRange(new object[] {
            "IC",
            "LCD",
            "Board",
            "باطری",
            "جانبی",
            "سایر قطعات"});
            this.cmbCat.Location = new System.Drawing.Point(114, 126);
            this.cmbCat.Name = "cmbCat";
            this.cmbCat.Size = new System.Drawing.Size(138, 24);
            this.cmbCat.TabIndex = 3;
            this.cmbCat.Text = "انتخاب دسته";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(114, 84);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(139, 23);
            this.txtAmount.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(114, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(139, 23);
            this.txtName.TabIndex = 1;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddProduct.Location = new System.Drawing.Point(13, 99);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(75, 31);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "افزودن";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // grpbSearch
            // 
            this.grpbSearch.Controls.Add(this.btnSearch);
            this.grpbSearch.Controls.Add(this.cmbSearchCat);
            this.grpbSearch.Controls.Add(this.rdiCat);
            this.grpbSearch.Controls.Add(this.rdiName);
            this.grpbSearch.Controls.Add(this.txtSearchName);
            this.grpbSearch.ForeColor = System.Drawing.Color.Silver;
            this.grpbSearch.Location = new System.Drawing.Point(644, 457);
            this.grpbSearch.Name = "grpbSearch";
            this.grpbSearch.Size = new System.Drawing.Size(332, 181);
            this.grpbSearch.TabIndex = 2;
            this.grpbSearch.TabStop = false;
            this.grpbSearch.Text = "جستجوی کالا";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSearch.Location = new System.Drawing.Point(105, 131);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 31);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbSearchCat
            // 
            this.cmbSearchCat.FormattingEnabled = true;
            this.cmbSearchCat.Items.AddRange(new object[] {
            "IC",
            "LCD",
            "Board",
            "باطری",
            "جانبی",
            "سایر قطعات"});
            this.cmbSearchCat.Location = new System.Drawing.Point(16, 87);
            this.cmbSearchCat.Name = "cmbSearchCat";
            this.cmbSearchCat.Size = new System.Drawing.Size(175, 24);
            this.cmbSearchCat.TabIndex = 3;
            this.cmbSearchCat.Text = "انتخاب دسته";
            this.cmbSearchCat.Visible = false;
            // 
            // rdiCat
            // 
            this.rdiCat.AutoSize = true;
            this.rdiCat.Location = new System.Drawing.Point(201, 88);
            this.rdiCat.Name = "rdiCat";
            this.rdiCat.Size = new System.Drawing.Size(124, 20);
            this.rdiCat.TabIndex = 2;
            this.rdiCat.Text = "بر اساس دسته ";
            this.rdiCat.UseVisualStyleBackColor = true;
            // 
            // rdiName
            // 
            this.rdiName.AutoSize = true;
            this.rdiName.Checked = true;
            this.rdiName.Location = new System.Drawing.Point(199, 37);
            this.rdiName.Name = "rdiName";
            this.rdiName.Size = new System.Drawing.Size(126, 20);
            this.rdiName.TabIndex = 1;
            this.rdiName.TabStop = true;
            this.rdiName.Text = "بر اساس نام کالا";
            this.rdiName.UseVisualStyleBackColor = true;
            this.rdiName.CheckedChanged += new System.EventHandler(this.rdiName_CheckedChanged);
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(16, 36);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(175, 23);
            this.txtSearchName.TabIndex = 0;
            // 
            // dgProduct
            // 
            this.dgProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProduct.Location = new System.Drawing.Point(12, 40);
            this.dgProduct.Name = "dgProduct";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgProduct.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgProduct.Size = new System.Drawing.Size(626, 607);
            this.dgProduct.TabIndex = 3;
            this.dgProduct.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgProduct_CellMouseClick);
            // 
            // rcProductMenu
            // 
            this.rcProductMenu.Name = "rcProductMenu";
            this.rcProductMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rcProductMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "دسته";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(984, 662);
            this.Controls.Add(this.dgProduct);
            this.Controls.Add(this.grpbSearch);
            this.Controls.Add(this.grpbProduct);
            this.Controls.Add(this.mnuMain);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMain;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت تعمیرات موبایل الیاس";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.grpbProduct.ResumeLayout(false);
            this.grpbProduct.PerformLayout();
            this.grpbSearch.ResumeLayout(false);
            this.grpbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem حسابداریToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpbProduct;
        private System.Windows.Forms.ComboBox cmbCat;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.GroupBox grpbSearch;
        private System.Windows.Forms.ComboBox cmbSearchCat;
        private System.Windows.Forms.RadioButton rdiCat;
        private System.Windows.Forms.RadioButton rdiName;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.DataGridView dgProduct;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ToolStripMenuItem مشتریToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem صدورقبضToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem خریدToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem سودوزیانToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ContextMenuStrip rcProductMenu;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.ToolStripMenuItem خدماتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem فاکتورToolStripMenuItem;
        private System.Windows.Forms.Label label5;
    }
}


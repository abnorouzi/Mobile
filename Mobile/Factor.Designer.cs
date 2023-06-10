namespace Mobile
{
    partial class Factor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factor));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProblem = new System.Windows.Forms.TextBox();
            this.cmbStat = new System.Windows.Forms.ComboBox();
            this.lblStat = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdiNotPaid = new System.Windows.Forms.RadioButton();
            this.dtpTo = new FarsiLibrary.Win.Controls.FADatePicker();
            this.dtpFrom = new FarsiLibrary.Win.Controls.FADatePicker();
            this.txtSearchFactorId = new System.Windows.Forms.TextBox();
            this.cmbSearchCustomer = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdiDate = new System.Windows.Forms.RadioButton();
            this.rdiFactorId = new System.Windows.Forms.RadioButton();
            this.rdiCustomer = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgFactor = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.rcFactorMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFactor)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtProblem);
            this.groupBox1.Controls.Add(this.cmbStat);
            this.groupBox1.Controls.Add(this.lblStat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbCustomer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtModel);
            this.groupBox1.ForeColor = System.Drawing.Color.Silver;
            this.groupBox1.Location = new System.Drawing.Point(754, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(322, 242);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "قبض";
            // 
            // btnEdit
            // 
            this.btnEdit.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnEdit.Location = new System.Drawing.Point(11, 58);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 31);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.Location = new System.Drawing.Point(11, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 31);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "افزودن";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "علت مراجعه";
            // 
            // txtProblem
            // 
            this.txtProblem.Location = new System.Drawing.Point(6, 146);
            this.txtProblem.Multiline = true;
            this.txtProblem.Name = "txtProblem";
            this.txtProblem.Size = new System.Drawing.Size(240, 81);
            this.txtProblem.TabIndex = 6;
            // 
            // cmbStat
            // 
            this.cmbStat.FormattingEnabled = true;
            this.cmbStat.Items.AddRange(new object[] {
            "قبض",
            "عودت بدون تعمیر",
            "در حال تعمیر",
            "آماده تحویل",
            "تحویل مشتری"});
            this.cmbStat.Location = new System.Drawing.Point(136, 55);
            this.cmbStat.Name = "cmbStat";
            this.cmbStat.Size = new System.Drawing.Size(125, 21);
            this.cmbStat.TabIndex = 5;
            // 
            // lblStat
            // 
            this.lblStat.AutoSize = true;
            this.lblStat.Location = new System.Drawing.Point(269, 58);
            this.lblStat.Name = "lblStat";
            this.lblStat.Size = new System.Drawing.Size(44, 13);
            this.lblStat.TabIndex = 4;
            this.lblStat.Text = "وضعیت";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "مدل گوشی";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(104, 19);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(154, 21);
            this.cmbCustomer.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "مشتری";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(6, 110);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(233, 21);
            this.txtModel.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdiNotPaid);
            this.groupBox2.Controls.Add(this.dtpTo);
            this.groupBox2.Controls.Add(this.dtpFrom);
            this.groupBox2.Controls.Add(this.txtSearchFactorId);
            this.groupBox2.Controls.Add(this.cmbSearchCustomer);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.rdiDate);
            this.groupBox2.Controls.Add(this.rdiFactorId);
            this.groupBox2.Controls.Add(this.rdiCustomer);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.ForeColor = System.Drawing.Color.Silver;
            this.groupBox2.Location = new System.Drawing.Point(754, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(322, 199);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "جستجو";
            // 
            // rdiNotPaid
            // 
            this.rdiNotPaid.AutoSize = true;
            this.rdiNotPaid.Location = new System.Drawing.Point(201, 135);
            this.rdiNotPaid.Name = "rdiNotPaid";
            this.rdiNotPaid.Size = new System.Drawing.Size(112, 17);
            this.rdiNotPaid.TabIndex = 21;
            this.rdiNotPaid.Text = "پرداخت نشده ها";
            this.rdiNotPaid.UseVisualStyleBackColor = true;
            this.rdiNotPaid.CheckedChanged += new System.EventHandler(this.rdiNotPaid_CheckedChanged);
            // 
            // dtpTo
            // 
            this.dtpTo.Enabled = false;
            this.dtpTo.Location = new System.Drawing.Point(14, 114);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(120, 20);
            this.dtpTo.TabIndex = 20;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Enabled = false;
            this.dtpFrom.Location = new System.Drawing.Point(14, 88);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(120, 20);
            this.dtpFrom.TabIndex = 19;
            // 
            // txtSearchFactorId
            // 
            this.txtSearchFactorId.BackColor = System.Drawing.Color.Silver;
            this.txtSearchFactorId.Enabled = false;
            this.txtSearchFactorId.Location = new System.Drawing.Point(14, 54);
            this.txtSearchFactorId.Name = "txtSearchFactorId";
            this.txtSearchFactorId.Size = new System.Drawing.Size(154, 21);
            this.txtSearchFactorId.TabIndex = 18;
            // 
            // cmbSearchCustomer
            // 
            this.cmbSearchCustomer.BackColor = System.Drawing.Color.White;
            this.cmbSearchCustomer.FormattingEnabled = true;
            this.cmbSearchCustomer.Location = new System.Drawing.Point(14, 20);
            this.cmbSearchCustomer.Name = "cmbSearchCustomer";
            this.cmbSearchCustomer.Size = new System.Drawing.Size(154, 21);
            this.cmbSearchCustomer.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "تا تاریخ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "از تاریخ";
            // 
            // rdiDate
            // 
            this.rdiDate.AutoSize = true;
            this.rdiDate.Location = new System.Drawing.Point(210, 92);
            this.rdiDate.Name = "rdiDate";
            this.rdiDate.Size = new System.Drawing.Size(102, 17);
            this.rdiDate.TabIndex = 12;
            this.rdiDate.Text = "بر اساس تاریخ";
            this.rdiDate.UseVisualStyleBackColor = true;
            this.rdiDate.CheckedChanged += new System.EventHandler(this.rdiDate_CheckedChanged);
            // 
            // rdiFactorId
            // 
            this.rdiFactorId.AutoSize = true;
            this.rdiFactorId.Location = new System.Drawing.Point(174, 55);
            this.rdiFactorId.Name = "rdiFactorId";
            this.rdiFactorId.Size = new System.Drawing.Size(139, 17);
            this.rdiFactorId.TabIndex = 11;
            this.rdiFactorId.Text = "بر اساس شماره قبض";
            this.rdiFactorId.UseVisualStyleBackColor = true;
            this.rdiFactorId.CheckedChanged += new System.EventHandler(this.rdiFactorId_CheckedChanged);
            // 
            // rdiCustomer
            // 
            this.rdiCustomer.AutoSize = true;
            this.rdiCustomer.Checked = true;
            this.rdiCustomer.Location = new System.Drawing.Point(196, 20);
            this.rdiCustomer.Name = "rdiCustomer";
            this.rdiCustomer.Size = new System.Drawing.Size(117, 17);
            this.rdiCustomer.TabIndex = 10;
            this.rdiCustomer.TabStop = true;
            this.rdiCustomer.Text = "بر اساس مشتری";
            this.rdiCustomer.UseVisualStyleBackColor = true;
            this.rdiCustomer.CheckedChanged += new System.EventHandler(this.rdiCustomer_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnSearch.Location = new System.Drawing.Point(14, 159);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 34);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgFactor
            // 
            this.dgFactor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgFactor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgFactor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFactor.Location = new System.Drawing.Point(12, 12);
            this.dgFactor.Name = "dgFactor";
            this.dgFactor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgFactor.Size = new System.Drawing.Size(736, 497);
            this.dgFactor.TabIndex = 3;
            this.dgFactor.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgFactor_CellMouseClick);
            // 
            // btnBack
            // 
            this.btnBack.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnBack.Location = new System.Drawing.Point(784, 475);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(197, 34);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "بازگشت به منوی اصلی";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // rcFactorMenu
            // 
            this.rcFactorMenu.Name = "rcFactorMenu";
            this.rcFactorMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // Factor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1086, 521);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgFactor);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Factor";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "صدور قبض";
            this.Load += new System.EventHandler(this.Factor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFactor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProblem;
        private System.Windows.Forms.ComboBox cmbStat;
        private System.Windows.Forms.Label lblStat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchFactorId;
        private System.Windows.Forms.ComboBox cmbSearchCustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdiDate;
        private System.Windows.Forms.RadioButton rdiFactorId;
        private System.Windows.Forms.RadioButton rdiCustomer;
        private System.Windows.Forms.DataGridView dgFactor;
        private System.Windows.Forms.Button btnBack;
        private FarsiLibrary.Win.Controls.FADatePicker dtpTo;
        private FarsiLibrary.Win.Controls.FADatePicker dtpFrom;
        private System.Windows.Forms.RadioButton rdiNotPaid;
        private System.Windows.Forms.ContextMenuStrip rcFactorMenu;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mobile
{
    public partial class frmMain : Form
    {
        int current_id = 0;
        mbDB db = new mbDB();
        public frmMain()
        {
            InitializeComponent();
        }

        private void مشتریToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomers c = new frmCustomers();
            c.Show();
            this.Hide(); 
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtPrice.Text) || String.IsNullOrEmpty(cmbCat.Text))
            {
                MessageBox.Show("یکی از فیلدهای قیمت یا نام کالا یا دسته خالی میباشد", "هشدار فیلد خالی", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else{
                int price = Convert.ToInt32(txtPrice.Text);
                int amount = Convert.ToInt32(txtAmount.Text);
                db.add_product(txtName.Text, cmbCat.Text, price, amount, txtDesc.Text);
                db.refresh("Product", dgProduct);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ToolStripMenuItem deleteToolStripMenuItem = new ToolStripMenuItem("حذف");
            ToolStripMenuItem updateToolStripMenuItem = new ToolStripMenuItem("ویرایش");
            rcProductMenu.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem, updateToolStripMenuItem });
            deleteToolStripMenuItem.Click += new EventHandler(deleteToolStripMenuItem_Click);
            updateToolStripMenuItem.Click += new EventHandler(updateToolStripMemuItem_Click);
            db.refresh("Product", dgProduct);
            dgProduct.Columns[0].HeaderText = "شماره";
            dgProduct.Columns[1].HeaderText = "نام";
            dgProduct.Columns[2].HeaderText = "دسته";
            dgProduct.Columns[3].HeaderText = "قیمت";
            dgProduct.Columns[4].HeaderText = "تعداد";
            dgProduct.Columns[5].HeaderText = "توضیحات";
        }

        private void updateToolStripMemuItem_Click(object sender, EventArgs e)
        {
            current_id = Convert.ToInt32(dgProduct.Rows[dgProduct.CurrentCell.RowIndex].Cells[0].Value);
            DataTable dt = db.search_product_by_id(current_id);
            foreach (DataRow row in dt.Rows)
            {
                txtName.Text = row["name"].ToString();
                txtDesc.Text = row["Description"].ToString();
                cmbCat.Text = row["category"].ToString();
                txtAmount.Text = row["amount"].ToString();
                txtPrice.Text = row["price"].ToString();
            }
            btnAddProduct.Visible = false;
            btnEditProduct.Visible = true;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgProduct.Rows[dgProduct.CurrentCell.RowIndex].Cells[0].Value);
            db.del_from(id, "Product");
            dgProduct.Rows.RemoveAt(dgProduct.CurrentCell.RowIndex);
        }

        private void dgProduct_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                dgProduct.CurrentCell = dgProduct.Rows[e.RowIndex].Cells[e.ColumnIndex];
                rcProductMenu.Show(MousePosition);
            }
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            int price = Convert.ToInt32(txtPrice.Text);
            int amount = Convert.ToInt32(txtAmount.Text);
            db.edit_product(current_id, txtName.Text, cmbCat.Text, price, amount, txtDesc.Text);
            db.refresh("Product", dgProduct);
            btnAddProduct.Visible = true;
            btnEditProduct.Visible = false;
            clear_box();
        }
        private void clear_box()
        {
            txtDesc.Text = "";
            txtAmount.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
        }

        private void rdiName_CheckedChanged(object sender, EventArgs e)
        {
            if (rdiName.Checked)
            {
                cmbSearchCat.Visible = false;
                txtSearchName.Visible = true;
            }
            else
            {
                cmbSearchCat.Visible = true;
                txtSearchName.Visible = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rdiName.Checked)
            {
                if (String.IsNullOrEmpty(txtSearchName.Text))
                {
                    MessageBox.Show("لطفا یک مقدار برای جستجو وارد کنید");
                }
                else
                {
                    DataTable dt = db.search_product_by_name(txtSearchName.Text);
                    dgProduct.DataSource = dt;
                }
            }
            else
            {
                DataTable dt = db.search_product_by_category(cmbSearchCat.Text);
                dgProduct.DataSource = dt;
            }
        }

        private void خدماتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Services s = new Services();
            s.Show();
            this.Hide();
        }

        private void خریدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Shop s = new Shop();
            s.Show();
            this.Hide();
        }

        private void فاکتورToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void صدورقبضToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Factor f = new Factor();
            f.Show();
            this.Hide();
        }
      
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace Mobile
{
    public partial class Shop : Form
    {
        mbDB db = new mbDB();
        int current_id = 0;
        public Shop()
        {
            InitializeComponent();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            frmMain m = new frmMain();
            m.Show();
            this.Hide();
        }

        private void Shop_Load(object sender, EventArgs e)
        {
            DataTable dt_produt = db.fetch_all("Product");
            DataTable dt = db.fetch_shop();
            foreach (DataRow row in dt_produt.Rows)
            {
                cmbSearchName.Items.Add(row[1].ToString());
                cmbName.Items.Add(row[1]);
            }
            ToolStripMenuItem deleteToolStripMenuItem = new ToolStripMenuItem("حذف");
            ToolStripMenuItem updateToolStripMenuItem = new ToolStripMenuItem("ویرایش");
            rcShopMenu.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem, updateToolStripMenuItem });
            deleteToolStripMenuItem.Click += new EventHandler(deleteToolStripMenuItem_Click);
            updateToolStripMenuItem.Click += new EventHandler(updateToolStripMemuItem_Click);
            dgShop.DataSource = dt;
            dgShop.Columns[0].HeaderText = "شماره";
            dgShop.Columns[1].HeaderText = "نام";
            dgShop.Columns[2].HeaderText = "قیمت واحد";
            dgShop.Columns[3].HeaderText = "تعداد";
            dgShop.Columns[4].HeaderText = "تاریخ";
        }

        private void updateToolStripMemuItem_Click(object sender, EventArgs e)
        {
            current_id = Convert.ToInt32(dgShop.Rows[dgShop.CurrentCell.RowIndex].Cells[0].Value);
            DataTable dt = db.search_product_by_id(current_id);
            foreach (DataRow row in dt.Rows)
            {
                cmbName.SelectedText = row[1].ToString();
                txtAmount.Text = row["amount"].ToString();
                txtPrice.Text = row["price"].ToString();
            }
            btnAdd.Visible = false;
            btnEdit.Visible = true;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgShop.Rows[dgShop.CurrentCell.RowIndex].Cells[0].Value);
            db.del_from(id, "Shop");
            dgShop.Rows.RemoveAt(dgShop.CurrentCell.RowIndex);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cmbSearchName.Text))
            {
                
                MessageBox.Show("لطفا نام کالای مورد جستجو را انتخاب کنید");
            }
            else
            {
                if (String.IsNullOrEmpty(dtpFrom.Text) || String.IsNullOrEmpty(dtpTo.Text) ||
                    dtpFrom.SelectedDateTime.ToShortDateString() == "1/1/0001" || dtpTo.SelectedDateTime.ToShortDateString() == "1/1/0001")
                {
                    DataTable dt = db.search_shop_without_date(cmbSearchName.Text);
                    dgShop.DataSource = dt;
                }
                else
                {
                    DataTable dt = db.search_shop_with_date(cmbSearchName.Text, dtpFrom.SelectedDateTime.ToShortDateString(),
                        dtpTo.SelectedDateTime.ToShortDateString());
                    dgShop.DataSource = dt;
                }
            }
        }

        private void dgShop_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                dgShop.CurrentCell = dgShop.Rows[e.RowIndex].Cells[e.ColumnIndex];
                rcShopMenu.Show(MousePosition);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int product = 0;
            DataTable dt = db.search_product_by_name(cmbName.Text);
            foreach (DataRow row in dt.Rows)
            {
                product = Convert.ToInt32(row[0]);
            }
            db.edit_shop(current_id, product, Convert.ToInt32(txtPrice.Text), Convert.ToInt32(txtAmount.Text));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataTable dt = db.search_product_by_name(cmbSearchName.Text);
            int id = 0;
            foreach (DataRow row in dt.Rows)
            {
                id = Convert.ToInt32(row[0]);
            }
            db.add_shop(id, Convert.ToInt32(txtPrice.Text), Convert.ToInt32(txtAmount.Text));
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain m = new frmMain();
            m.Show();
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Mobile
    {

    public partial class frmCustomers : Form
    {
        int current_id = 0;
        mbDB db = new mbDB();
        public frmCustomers()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                db.add_customer(txtName.Text, txtPhone.Text, txtEmail.Text);
                db.refresh("Customer", dgCustomer);     
            }
            else
            {
                MessageBox.Show("فیلد نام و نام خانوادگی نمیتواند خالی باشد");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Close();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            ToolStripMenuItem deleteToolStripMenuItem = new ToolStripMenuItem("حذف");
            ToolStripMenuItem updateToolStripMenuItem = new ToolStripMenuItem("ویرایش");
            rcMenuDg.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem, updateToolStripMenuItem });
            deleteToolStripMenuItem.Click += new EventHandler(deleteToolStripMenuItem_Click);
            updateToolStripMenuItem.Click += new EventHandler(updateToolStripMemuItem_Click);
            db.refresh("Customer", dgCustomer);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgCustomer.Rows[dgCustomer.CurrentCell.RowIndex].Cells[0].Value);
            db.del_from(id, "Customer");
            dgCustomer.Rows.RemoveAt(dgCustomer.CurrentCell.RowIndex);
        }
        private void updateToolStripMemuItem_Click(object sender, EventArgs e)
        {
            string name = dgCustomer.Rows[dgCustomer.CurrentCell.RowIndex].Cells[1].Value.ToString();
            txtEditEmail.Enabled = true;
            txtEditName.Enabled = true;
            txtEditPhone.Enabled = true;
            DataTable dt = db.search_customer(name);
            foreach(DataRow row in dt.Rows){
                current_id = Convert.ToInt32(row[0]);
                txtEditName.Text = row["name"].ToString();
                txtEditPhone.Text = row["phone"].ToString();
                txtEditEmail.Text = row["email"].ToString();
            }
        }



        private void dgCustomer_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                dgCustomer.CurrentCell = dgCustomer.Rows[e.RowIndex].Cells[e.ColumnIndex];
                rcMenuDg.Show(MousePosition);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            db.edit_customer(current_id, txtEditName.Text, txtEditPhone.Text, txtEditEmail.Text);
            db.refresh("Customer", dgCustomer);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgCustomer.DataSource = db.search_customer(txtSearchName.Text);
        }

    }
}

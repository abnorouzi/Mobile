using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mobile
{
    public partial class Services : Form
    {
        int current_id = 0;
        mbDB db = new mbDB();
        public Services()
        {
            InitializeComponent();
        }

        private void Services_Load(object sender, EventArgs e)
        {
            ToolStripMenuItem deleteToolStripMenuItem = new ToolStripMenuItem("حذف");
            ToolStripMenuItem updateToolStripMenuItem = new ToolStripMenuItem("ویرایش");
            rcServiceMenu.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem, updateToolStripMenuItem });
            deleteToolStripMenuItem.Click += new EventHandler(deleteToolStripMenuItem_Click);
            updateToolStripMenuItem.Click += new EventHandler(updateToolStripMemuItem_Click);
            db.refresh("Service", dgServices);
        }

        private void updateToolStripMemuItem_Click(object sender, EventArgs e)
        {
            current_id = Convert.ToInt32(dgServices.Rows[dgServices.CurrentCell.RowIndex].Cells[0].Value);
            string name = dgServices.Rows[dgServices.CurrentCell.RowIndex].Cells[1].Value.ToString();
            DataTable dt = db.search_service(name);
            foreach (DataRow row in dt.Rows)
            {
                txtName.Text = row["name"].ToString();
                txtDesc.Text = row["Description"].ToString();
                txtWage.Text = row["wage"].ToString();
            }
            btnAdd.Visible = false;
            btnEdit.Visible = true;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException(); int id = Convert.ToInt32(dgServices.Rows[dgServices.CurrentCell.RowIndex].Cells[0].Value);
            db.del_from(id, "Service");
            dgServices.Rows.RemoveAt(dgServices.CurrentCell.RowIndex);
        }

        private void dgServices_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                dgServices.CurrentCell = dgServices.Rows[e.RowIndex].Cells[e.ColumnIndex];
                rcServiceMenu.Show(MousePosition);
            }
        }
        private void clear_box()
        {
            txtSearchName.Text = "";
            txtDesc.Text = "";
            txtName.Text = "";
            txtWage.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            db.add_service(txtName.Text, Convert.ToInt32(txtWage.Text), txtDesc.Text);
            db.refresh("Service", dgServices);
            clear_box();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            db.edit_service(current_id, txtName.Text, Convert.ToInt32(txtWage.Text), txtDesc.Text);
            db.refresh("Service", dgServices);
            clear_box();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = db.search_service(txtSearchName.Text);
            dgServices.DataSource = dt;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain m = new frmMain();
            m.Show();
            this.Close();
        }
    }
}

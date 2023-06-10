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
    public partial class Factor : Form
    {
        mbDB db = new mbDB();
        int current_id = 0;
        public Factor()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain m = new frmMain();
            m.Show();
            this.Close();
        }

        private void Factor_Load(object sender, EventArgs e)
        {
            DataTable customers = db.fetch_all("Customer");
            foreach (DataRow row in customers.Rows)
            {
                cmbCustomer.Items.Add(row[1].ToString());
                cmbSearchCustomer.Items.Add(row[1].ToString());
            }
            dtpFrom.BackColor = Color.Silver;
            dtpTo.BackColor = Color.Silver;
            ToolStripMenuItem deleteToolStripMenuItem = new ToolStripMenuItem("حذف");
            ToolStripMenuItem updateToolStripMenuItem = new ToolStripMenuItem("ویرایش");
            rcFactorMenu.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem, updateToolStripMenuItem });
            deleteToolStripMenuItem.Click += new EventHandler(deleteToolStripMenuItem_Click);
            updateToolStripMenuItem.Click += new EventHandler(updateToolStripMemuItem_Click);
            DataTable dt = db.fetch_factors();
            dgFactor.DataSource = dt;
            dgFactor.Columns[0].HeaderText = "شماره";
            dgFactor.Columns[1].HeaderText = "نام مشتری";
            dgFactor.Columns[5].HeaderText = "وضعیت";
            dgFactor.Columns[3].HeaderText = "علت مراجعه";
            dgFactor.Columns[2].HeaderText = "مدل گوشی";
            dgFactor.Columns[4].HeaderText = "تاریخ";

        }

        private void updateToolStripMemuItem_Click(object sender, EventArgs e)
        {
            current_id = Convert.ToInt32(dgFactor.Rows[dgFactor.CurrentCell.RowIndex].Cells[0].Value);
            DataTable dt = db.search_factor_by_id(current_id);
            foreach (DataRow row in dt.Rows)
            {
                cmbCustomer.SelectedText = db.search_customer_by_id(Convert.ToInt32(row[1]));
                cmbStat.SelectedText = row["status"].ToString();
                txtModel.Text = row["phone_model"].ToString();
                txtProblem.Text = row["problem"].ToString();
            }
            btnAdd.Visible = false;
            btnEdit.Visible = true;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgFactor.Rows[dgFactor.CurrentCell.RowIndex].Cells[0].Value);
            db.del_from(id, "Factor");
            dgFactor.Rows.RemoveAt(dgFactor.CurrentCell.RowIndex);
        }

        private void rdiFactorId_CheckedChanged(object sender, EventArgs e)
        {
            if (rdiFactorId.Checked)
            {
                txtSearchFactorId.Enabled = true;
                cmbSearchCustomer.Enabled = false;
                dtpFrom.BackColor = Color.Silver;
                dtpTo.BackColor = Color.Silver;
                txtSearchFactorId.BackColor = Color.White;
                cmbSearchCustomer.BackColor = Color.Silver;
            }
        }

        private void rdiDate_CheckedChanged(object sender, EventArgs e)
        {
            if (rdiDate.Checked)
            {
                dtpFrom.Enabled = true;
                dtpTo.Enabled = true;
                cmbSearchCustomer.Enabled = false;
                txtSearchFactorId.Enabled = false;
                dtpFrom.BackColor = Color.White;
                dtpTo.BackColor = Color.White;
                txtSearchFactorId.BackColor = Color.Silver;
            }
        }

        private void rdiNotPaid_CheckedChanged(object sender, EventArgs e)
        {
            if (rdiNotPaid.Checked)
            {
                dtpFrom.Enabled = false;
                dtpTo.Enabled = false;
                cmbSearchCustomer.Enabled = false;
                txtSearchFactorId.Enabled = false;
                dtpFrom.BackColor = Color.Silver;
                dtpTo.BackColor = Color.Silver;
                txtSearchFactorId.BackColor = Color.Silver;
            }
        }

        private void rdiCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdiCustomer.Checked)
            {
                cmbSearchCustomer.BackColor = Color.Silver;
                cmbSearchCustomer.Enabled = false;
            }
            else
            {
                cmbSearchCustomer.BackColor = Color.White;
                cmbSearchCustomer.Enabled = true;
                dtpFrom.Enabled = false;
                dtpTo.Enabled = false;
                txtSearchFactorId.Enabled = false;
                dtpFrom.BackColor = Color.Silver;
                dtpTo.BackColor = Color.Silver;
                txtSearchFactorId.BackColor = Color.Silver;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            db.add_factor(cmbCustomer.Text, txtModel.Text, txtProblem.Text, cmbStat.Text);
            db.refresh("Factor", dgFactor);
            clear_box();
        }
        private void clear_box()
        {
            txtModel.Text = "";
            txtProblem.Text = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            db.edit_factor(current_id, cmbCustomer.Text, txtModel.Text, txtProblem.Text, cmbStat.Text);
            db.refresh("Factor", dgFactor);
            clear_box();
            btnEdit.Visible = false;
            btnAdd.Visible = true;
        }

        private void dgFactor_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                dgFactor.CurrentCell = dgFactor.Rows[e.RowIndex].Cells[e.ColumnIndex];
                rcFactorMenu.Show(MousePosition);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rdiFactorId.Checked)
            {
                DataTable dt = db.search_factor_by_id(Convert.ToInt32(txtSearchFactorId.Text));
                dgFactor.DataSource = dt;
            }
            else if (rdiCustomer.Checked)
            {
                DataTable dt = db.search_factor_by_customer(cmbSearchCustomer.Text);
                dgFactor.DataSource = dt;
            }
            else if (rdiDate.Checked)
            {
                DataTable dt = db.search_factor_by_date(dtpFrom.SelectedDateTime.ToShortDateString(), dtpTo.SelectedDateTime.ToShortDateString());
                dgFactor.DataSource = dt;
            }
            else
            {

            }
        }
    }
}

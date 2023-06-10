using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Data.SQLite;
using System.Globalization;

namespace Mobile
{
    class mbDB
    {
        string cnstr = "Data Source=mobile.sqlite3;version=3";
        SQLiteConnection cn;
        string sql = "";

        public mbDB()
        {
            cn = new SQLiteConnection(cnstr);
        }

        public void refresh(String tbl_name, DataGridView dg)
        {
            sql = "select * from " + tbl_name;
            SQLiteCommand cmd = new SQLiteCommand(sql, cn);
            if (cn != null || cn.State != ConnectionState.Closed)
            {
                cn.Close();
                cn.Open();
            }
            
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dg.DataSource = dt;
            cn.Close();
        }

        public void add_customer(String name, String phone, String email)
        {
            sql = "INSERT INTO Customer (name, phone, email) VALUES (@name, @phone, @email)";
            SQLiteCommand cmd = new SQLiteCommand(sql, cn);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@email", email);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("مشتری افزوده شد ...");
        }

        public void edit_customer(int id, String name, String phone, String email)
        {
            sql = "update Customer set name=@name, phone=@phone, email=@email where id=@id";
            SQLiteCommand cmd = new SQLiteCommand(sql, cn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@email", email);
            if (cn != null || cn.State != ConnectionState.Closed)
            {
                cn.Close();
                cn.Open();
            }
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void del_customer(int id)
        {
            sql = "delete from Customer where id=@id";
            SQLiteCommand cmd = new SQLiteCommand(sql, cn);
            cmd.Parameters.AddWithValue("@id", id);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        
        public DataTable search_customer(string name)
        {
            sql = "select * from Customer where name=@name";
            SQLiteCommand cmd = new SQLiteCommand(sql, cn);
            cmd.Parameters.AddWithValue("@name", name);
            cn.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cn.Close();
            return dt;
        }
        public string search_customer_by_id(int id)
        {
            sql = "select * from Customer where id=@id";
            SQLiteCommand cmd = new SQLiteCommand(sql, cn);
            cmd.Parameters.AddWithValue("@id", id);
            cn.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cn.Close();
            string name = "";
            foreach (DataRow row in dt.Rows)
            {
                name = row[1].ToString();
            }
            return name;
        }
        public int get_customer_id(string name)
        {
            sql = "select id from Customer where name=@name";
            SQLiteCommand cmd = new SQLiteCommand(sql, cn);
            cmd.Parameters.AddWithValue("@name", name);
            cn.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cn.Close();
            int customer_id = 0;
            foreach (DataRow row in dt.Rows)
            {
                customer_id = Convert.ToInt32(row[0]);
            }
            return customer_id;
        }

        public DataTable fetch_all(string tbl)
        {
            sql = "select * from " + tbl;
            SQLiteCommand cmd = new SQLiteCommand(sql, cn);
            cn.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cn.Close();
            return dt;
        }

        public void add_product(string name, string category, int price, int amount, string description)
        {
            sql = "insert into Product (name, category, price, amount, description) values (@name, @category, @price, @amount, @description)";
            SQLiteCommand cmd = new SQLiteCommand(sql, cn);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@category", category);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@amount", amount);
            cmd.Parameters.AddWithValue("@description", description);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void edit_product(int id, string name, string category, int price, int amount, string description)
        {
            sql = "update Product set name=@name, category=@category, price=@price, amount=@amount, description=@description where id=@id";
            SQLiteCommand cmd = new SQLiteCommand(sql, cn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@category", category);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@amount", amount);
            cmd.Parameters.AddWithValue("@description", description);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public DataTable search_product_by_id(int id)
        {
            sql = "select * from Product where id=@id";
            SQLiteCommand cmd = new SQLiteCommand(sql, cn);
            cmd.Parameters.AddWithValue("@id", id);
            cn.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cn.Close();
            return dt;
        }
        public DataTable search_product_by_category(string category)
        {
            sql = "select * from product where category= @category";            
            SQLiteCommand cmd = new SQLiteCommand(sql, cn);
            cmd.Parameters.AddWithValue("@category", category);
            cn.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cn.Close();
            return dt;
        }
        public DataTable search_product_by_name(string name)
        {
            sql = "select * from Product where name=@name";
            SQLiteCommand cmd = new SQLiteCommand(sql, cn);
            cmd.Parameters.AddWithValue("@name", name);
            cn.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cn.Close();
            return dt;
        }

        public void add_service(String name, int wage, String desc)
        {
            sql = "INSERT INTO Service (name, wage, description) VALUES (@name, @wage, @description)";
            SQLiteCommand cmd = new SQLiteCommand(sql, cn);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@wage", wage);
            cmd.Parameters.AddWithValue("@description", desc);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void edit_service(int id, String name, int wage, string desc)
        {
            sql = "update Service set name=@name, wage=@wage, description=@description where id=@id";
            SQLiteCommand cmd = new SQLiteCommand(sql, cn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@wage", wage);
            cmd.Parameters.AddWithValue("@description", desc);
            if (cn != null || cn.State != ConnectionState.Closed)
            {
                cn.Close();
                cn.Open();
            }
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public DataTable search_service(string name)
        {
            sql = "select * from Service where name=@name";
            SQLiteCommand cmd = new SQLiteCommand(sql, cn);
            cmd.Parameters.AddWithValue("@name", name);
            cn.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cn.Close();
            return dt;
        }
        public void add_shop(int product, int price, int amount)
        {
            sql = "INSERT INTO Shop (product, price, amount) VALUES (@product, @price, @amount)";
            SQLiteCommand cmd = new SQLiteCommand(sql, cn);
            cmd.Parameters.AddWithValue("@product", product);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@amount", amount);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void edit_shop(int id, int product, int price, int amount)
        {
            sql = "update Shop set product=@product price=@price amount=@amount where id=@id";
            SQLiteCommand cmd = new SQLiteCommand(sql, cn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@product", product);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@amount", amount);
            if (cn != null || cn.State != ConnectionState.Closed)
            {
                cn.Close();
                cn.Open();
            }
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void del_from(int id, string tbl)
        {
            sql = "delete from " + tbl + " where id=@id";
            SQLiteCommand cmd = new SQLiteCommand(sql, cn);
            cmd.Parameters.AddWithValue("@id", id);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public DataTable fetch_shop()
        {
            sql = "select Shop.id, Product.name, Shop.date, Shop.price, Shop.amount from Shop cross join Product where Shop.product=Product.id";
            SQLiteCommand cmd = new SQLiteCommand(sql, cn);
            cn.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cn.Close();
            dt.Columns.Add(new DataColumn("persian_date", typeof(String)));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string date = Convert.ToDateTime(dt.Rows[i][2]).ToShortDateString(); ;
                dt.Rows[i][5] = date_to_persian(date);
            }
            dt.Columns.Remove("date");
            return dt;
        }
        public DataTable search_shop_with_date(string name, string from, string to)
        {
            DataTable dt_product = search_product_by_name(name);
            int p_id = 0;
            foreach (DataRow row in dt_product.Rows)
            {
                p_id = Convert.ToInt32(row[0]);
            }
            string dt_from = date_to_gregorian(from);
            string dt_to = date_to_gregorian(to);
            sql = "select Shop.id, Product.name, Shop.date, Shop.price, Shop.amount from Shop cross join Product where Shop.product=Product.id and product=@id and date between @from and @to";
            SQLiteCommand cmd = new SQLiteCommand(sql, cn);
            cmd.Parameters.AddWithValue("@id", p_id);
            cmd.Parameters.AddWithValue("@from", dt_from);
            cmd.Parameters.AddWithValue("@to", dt_to);
            cn.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cn.Close();
            dt.Columns.Add(new DataColumn("persian_date", typeof(String)));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string date = Convert.ToDateTime(dt.Rows[i][2]).ToShortDateString(); ;
                dt.Rows[i][5] = date_to_persian(date);
            }
            dt.Columns.Remove("date");
            return dt;
        }
        public DataTable search_shop_without_date(string name)
        {
            DataTable dt_product = search_product_by_name(name);
            int p_id = 0;
            foreach (DataRow row in dt_product.Rows)
            {
                p_id = Convert.ToInt32(row[0]);
            }
            sql = "select * from Shop where product=@name";
            SQLiteCommand cmd = new SQLiteCommand(sql, cn);
            cmd.Parameters.AddWithValue("@name", p_id);
            cn.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cn.Close();
            dt.Columns.Add(new DataColumn("persian_date", typeof(String)));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string date = Convert.ToDateTime(dt.Rows[i][2]).ToShortDateString(); ;
                dt.Rows[i][5] = date_to_persian(date);
            }
            dt.Columns.Remove("date");
            return dt;
        }
        private string date_to_gregorian(string date)
        {
            var sp =date.Split('/');
            int month = int.Parse(sp[0]);
            int day = int.Parse(sp[1]);
            int year = int.Parse(sp[2]);
            DateTime dt = new DateTime(year, month, day);
            return dt.ToString("yyyy-MM-dd");
        }

        public string date_to_persian(string date)
        {
            PersianCalendar pc = new PersianCalendar();
            DateTime dt = DateTime.Parse(date);
            return String.Format("{0}/{1}/{2}", pc.GetYear(dt), pc.GetMonth(dt), pc.GetDayOfMonth(dt));
        }
        public void add_factor(string customer, string phone_model, string problem, string status)
        {
            int c_id = get_customer_id(customer);
            sql = "INSERT INTO Factor (customer, phone_model, problem, status) VALUES (@customer, @phone_model, @problem, @status)";
            SQLiteCommand cmd = new SQLiteCommand(sql, cn);
            cmd.Parameters.AddWithValue("@customer", c_id);
            cmd.Parameters.AddWithValue("@phone_model", phone_model);
            cmd.Parameters.AddWithValue("@problem", problem);
            cmd.Parameters.AddWithValue("@status", status);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void edit_factor(int id, string customer, string phone_model, string problem, string status)
        {
            int c_id = get_customer_id(customer);
            sql = "update Factor set customer=@customer, phone_model=@phone_model, problem=@problem, status=@status where id=@id";
            SQLiteCommand cmd = new SQLiteCommand(sql, cn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@customer", c_id);
            cmd.Parameters.AddWithValue("@phone_model", phone_model);
            cmd.Parameters.AddWithValue("@problem", problem);
            cmd.Parameters.AddWithValue("@status", status);
            if (cn != null || cn.State != ConnectionState.Closed)
            {
                cn.Close();
                cn.Open();
            }
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public DataTable search_factor_by_customer(string customer)
        {
            int c_id = get_customer_id(customer);
            sql = "select Factor.id, Customer.name, Factor.phone_model, Factor.problem, Factor.date, Factor.status from Factor cross join Customer where Factor.customer=Customer.id and customer=@id";
            SQLiteCommand cmd = new SQLiteCommand(sql, cn);
            cmd.Parameters.AddWithValue("@id", c_id);
            cn.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cn.Close();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string date = Convert.ToDateTime(dt.Rows[i][4]).ToShortDateString(); ;
                dt.Rows[i][5] = date_to_persian(date);
            }
            dt.Columns.Remove("date");
            return dt;
        }

        public DataTable fetch_factors()
        {
            sql = "select Factor.id, Customer.name, Factor.phone_model, Factor.problem, Factor.date, Factor.status from Factor cross join Customer where Factor.customer=Customer.id";
            SQLiteCommand cmd = new SQLiteCommand(sql, cn);
            cn.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cn.Close();
            dt.Columns.Add(new DataColumn("persian_date", typeof(String)));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string date = Convert.ToDateTime(dt.Rows[i][4]).ToShortDateString(); ;
                dt.Rows[i][5] = date_to_persian(date);
            }
            dt.Columns.Remove("date");
            return dt;
        } 

        public DataTable search_factor_by_id(int id)
        {
            sql = "select * from Factor where id=@id";
            SQLiteCommand cmd = new SQLiteCommand(sql, cn);
            cmd.Parameters.AddWithValue("@id", id);
            cn.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cn.Close();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string date = Convert.ToDateTime(dt.Rows[i][4]).ToShortDateString(); ;
                dt.Rows[i][5] = date_to_persian(date);
            }
            dt.Columns.Remove("date");
            return dt;
        }
        public DataTable search_factor_by_date(string from, string to)
        {
            string dt_from = date_to_gregorian(from);
            string dt_to = date_to_gregorian(to);
            sql = "select Factor.id, Customer.name, Factor.phone_model, Factor.problem, Factor.date, Factor.status from Factor cross join Customer where Factor.customer=Customer.id and date between @from and @to";
            SQLiteCommand cmd = new SQLiteCommand(sql, cn);
            cn.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@from", dt_from);
            cmd.Parameters.AddWithValue("@to", dt_to);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cn.Close();
            dt.Columns.Add(new DataColumn("persian_date", typeof(String)));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string date = Convert.ToDateTime(dt.Rows[i][4]).ToShortDateString(); ;
                dt.Rows[i][5] = date_to_persian(date);
            }
            dt.Columns.Remove("date");
            return dt;
        }
        public DataTable search_factor_by_pay()
        {
            return null;
        }   
    }
}

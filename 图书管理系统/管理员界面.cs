using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 图书管理系统
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            LoadBooks();
            LoadCmbKind();           
        }

        private void LoadBooks()
        {
            string sqlConStr = "server=.;database=MyLibrary;Integrated Security=True;";
            SqlConnection sqlCon = new SqlConnection(sqlConStr);
            string sqlStr = "select ISBN号,书名,作者,图书类别,出版日期,出版社 from Books";
            SqlDataAdapter da = new SqlDataAdapter(sqlStr, sqlCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvBooks.DataSource = dt;
        }
        private void LoadCmbKind()
        {
            string sqlConStr = "server=.;database=MyLibrary;Integrated Security=True;";
            SqlConnection sqlCon = new SqlConnection(sqlConStr);
            string sqlStr = "select distinct 图书类别 from Books";
            SqlDataAdapter da = new SqlDataAdapter(sqlStr, sqlCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbKind.Items.Add("全部");
            foreach (DataRow dr in dt.Rows)
            {
                string kind = dr["图书类别"].ToString();
                cmbKind.Items.Add(kind);
            }            
            cmbKind.SelectedIndex = 0;
        }

        private void frmAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSearchByKind_Click(object sender, EventArgs e)
        {
            string sqlConStr = "server=.;database=MyLibrary;Integrated Security=True;";
            SqlConnection sqlCon = new SqlConnection(sqlConStr);
            string kind = cmbKind.SelectedItem.ToString();
            string sqlStr;
            if (kind == "全部")
                sqlStr = "select ISBN号,书名,作者,图书类别,出版日期,出版社 from Books";
            else
                sqlStr = "select ISBN号,书名,作者,图书类别,出版日期,出版社 from Books where 图书类别=" + "'" + kind + "'";
            SqlDataAdapter da = new SqlDataAdapter(sqlStr, sqlCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvBooks.DataSource = dt;
        }

        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ISBN = dgvBooks.SelectedCells[0].Value.ToString();
            string sqlConStr = "server=.;database=MyLibrary;Integrated Security=True;";
            SqlConnection sqlCon = new SqlConnection(sqlConStr);
            string sqlStr = "select 内容摘要 from Books where ISBN号="+ISBN;
            SqlDataAdapter da = new SqlDataAdapter(sqlStr, sqlCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtContent.Text = dr["内容摘要"].ToString();
            }
            txtBookName.Text = dgvBooks.SelectedCells[1].Value.ToString();
            txtAuthor.Text = dgvBooks.SelectedCells[2].Value.ToString();
            txtBookKind.Text = dgvBooks.SelectedCells[3].Value.ToString();
            txtTime.Text = dgvBooks.SelectedCells[4].Value.ToString();
            txtPress.Text = dgvBooks.SelectedCells[5].Value.ToString();
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("书名不能为空");
            }
            else
            {
                string name = txtName.Text;
                string sqlConStr = "server=.;database=MyLibrary;Integrated Security=True;";
                SqlConnection sqlCon = new SqlConnection(sqlConStr);
                string kind = cmbKind.SelectedItem.ToString();
                string sqlStr = "select ISBN号,书名,作者,图书类别,出版日期,出版社 from Books where 书名="+"'"+name+"'";
                SqlDataAdapter da = new SqlDataAdapter(sqlStr, sqlCon);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                    MessageBox.Show("不存在此书");
                else
                    dgvBooks.DataSource = dt;
            }
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            string ISBN = dgvBooks.SelectedCells[0].Value.ToString();
            string name = txtBookName.Text;
            string author = txtAuthor.Text;
            string kind = txtBookKind.Text;
            string time = txtTime.Text;
            string content = txtContent.Text;
            string press = txtPress.Text;
            string connStr = "server=.;database=MyLibrary;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connStr);
            string sql = "update Books set 书名= '" + name + "'," + "作者= '" + author + "',图书类别= '" + kind + "',出版日期= '" + time + "',内容摘要= '" + content + "',出版社= '" + press + "'where ISBN号=" + ISBN;
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("修改成功");
            conn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            frmAddBook frm = new frmAddBook();
            frm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string ISBN = dgvBooks.SelectedCells[0].Value.ToString();
            string connStr = "server=.;database=MyLibrary;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connStr);
            string sql = "delete from Books where ISBN号=" + ISBN;
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("删除成功");
            conn.Close();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            frmLibraryRecord frm = new frmLibraryRecord();
            frm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            系统时间.Text ="时间："+ DateTime.Now.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

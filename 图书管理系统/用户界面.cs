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
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        private void frmUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void frmUser_Load(object sender, EventArgs e)
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

        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            string ISBN = dgvBooks.Rows[rowIndex].Cells[0].Value.ToString();
            string sqlConStr = "server=.;database=MyLibrary;Integrated Security=True;";
            SqlConnection sqlCon = new SqlConnection(sqlConStr);
            string sqlStr = "select 内容摘要 from Books where ISBN号=" + ISBN;
            SqlDataAdapter da = new SqlDataAdapter(sqlStr, sqlCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtContent.Text = dr["内容摘要"].ToString();
            }
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            string sqlConStr = "server=.;database=MyLibrary;Integrated Security=True;";
            SqlConnection sqlCon = new SqlConnection(sqlConStr);
            string sqlStr = "select userName from LoginRecord";
            SqlDataAdapter da = new SqlDataAdapter(sqlStr, sqlCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
 
            string name="";
            foreach (DataRow dr in dt.Rows)
            {
               name = dr["userName"].ToString();                
            }
            string ISBN = dgvBooks.SelectedCells[0].Value.ToString();
            string bookName = dgvBooks.SelectedCells[1].Value.ToString();
            string time = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
            string connStr2 = "server=.;database=MyLibrary;Integrated Security=True;";
            SqlConnection conn2 = new SqlConnection(connStr2);
            string sql2 = "insert into LibraryRecord(userName,ISBN号,书名,借书日期) values('" + name + "'," + ISBN + ",'" + bookName + "','" + time + "')";
            SqlCommand cmd = new SqlCommand(sql2, conn2);
            conn2.Open();
            cmd.ExecuteNonQuery();            
            conn2.Close();
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
                string sqlStr = "select ISBN号,书名,作者,图书类别,出版日期,出版社 from Books where 书名=" + "'" + name + "'";
                SqlDataAdapter da = new SqlDataAdapter(sqlStr, sqlCon);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                    MessageBox.Show("不存在此书");
                else
                    dgvBooks.DataSource = dt;
            }
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

        private void btnQuery_Click(object sender, EventArgs e)
        {
            frmLibraryRecord frm = new frmLibraryRecord();
            frm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            系统时间.Text = "时间：" + DateTime.Now.ToString();
        }
    }
}

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
    public partial class frmLibraryRecord : Form
    {
        public frmLibraryRecord()
        {
            InitializeComponent();
        }

        private void frmLibraryRecord_Load(object sender, EventArgs e)
        {
            LoadRecord();
        }

        private void LoadRecord()
        {
            string sqlConStr = "server=.;database=MyLibrary;Integrated Security=True;";
            SqlConnection sqlCon = new SqlConnection(sqlConStr);
            string sqlStr = "select userName,ISBN号,书名,借书日期 from LibraryRecord";
            SqlDataAdapter da = new SqlDataAdapter(sqlStr, sqlCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvLibraryRecord.DataSource = dt;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            string user = dgvLibraryRecord.SelectedCells[0].Value.ToString();
            string ISBN = dgvLibraryRecord.SelectedCells[1].Value.ToString();            
            string connStr = "server=.;database=MyLibrary;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connStr);
            string sql = "delete from LibraryRecord where userName='" + user + "'and ISBN号=" + ISBN;
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteNonQuery();            
            conn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LoadRecord();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            系统时间.Text = "时间：" + DateTime.Now.ToString();
        }
    }
}

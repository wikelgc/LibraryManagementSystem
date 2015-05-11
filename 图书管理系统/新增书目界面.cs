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
    public partial class frmAddBook : Form
    {
        public frmAddBook()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {            
            string name = txtBookName.Text;
            string author = txtAuthor.Text;
            string kind = txtBookKind.Text;
            string time = txtTime.Text;
            string content = txtContent.Text;
            string press = txtPress.Text;
            string connStr = "server=.;database=MyLibrary;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connStr);
            string sql = "insert into Books(书名,作者,图书类别,出版日期,内容摘要,出版社) values( '" + name + "','" + author + "','" + kind + "','" + time + "','" + content + "','" + press + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("添加成功");
            conn.Close();
            txtBookName.Text = "";
            txtAuthor.Text = "";
            txtBookKind.Text = "";
            txtTime.Text = "";
            txtContent.Text = "";
            txtPress.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            系统时间.Text = "时间：" + DateTime.Now.ToString();
        }
    }
}

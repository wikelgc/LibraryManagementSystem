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
    public partial class frmModifyPwd : Form
    {
        public frmModifyPwd()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
                if (txtName.Text == "")
                {
                    lblPrompt.Text = "用户名不能为空！";
                    lblPrompt.Visible = true;
                }
                else if (txtPwd.Text == "")
                {
                    lblPrompt.Text = "密码不能为空！";
                    lblPrompt.Visible = true;
                }
                else if (txtNewPwd.Text == "")
                {
                    lblPrompt.Text = "新密码不能为空！";
                    lblPrompt.Visible = true;
                }
                else if (txtNewPwdAgain.Text == "")
                {
                    lblPrompt.Text = "确认新密码不能为空！";
                    lblPrompt.Visible = true;
                }
                else if (txtNewPwd.Text != txtNewPwdAgain.Text)
                {
                    lblPrompt.Text = "两次输入的密码不相同";
                    lblPrompt.Visible = true;
                    txtNewPwd.Text = "";
                    txtNewPwdAgain.Text = "";
                }
                else
                {
                    string connStr = "server=.;database=MyLibrary;Integrated Security=True;";
                    SqlConnection conn = new SqlConnection(connStr);
                    conn.Open();
                    string str = "select * from LibraryUser where userName = '" + txtName.Text + "'"+"and userPassword ='"+txtPwd.Text+"'";
                    SqlCommand cmd = new SqlCommand(str, conn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        dr.Close();
                        string strUpdate = "update LibraryUser set userPassword=" + "'" + txtNewPwd.Text + "'" + "where userName=" + "'" + txtName.Text + "'";
                        SqlCommand cmd2 = new SqlCommand(strUpdate, conn);
                        int s = cmd2.ExecuteNonQuery();
                        MessageBox.Show("修改成功!");
                        conn.Close();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("用户名不存在或者密码不正确!");
                    }                   
                }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            系统时间.Text = "时间：" + DateTime.Now.ToString();
        }
    }
}

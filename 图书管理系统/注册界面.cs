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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (txtNewName.Text == "")
            {
                lblPrompt.Text = "用户名不能为空！";
                lblPrompt.Visible = true;
            }
            else if (txtNewPwd.Text == "")
            {
                lblPrompt.Text = "密码不能为空！";
                lblPrompt.Visible = true;
            }
            else if (txtPwdAgain.Text == "")
            {
                lblPrompt.Text = "确认密码不能为空！";
                lblPrompt.Visible = true;
            }
            else if (txtNewPwd.Text != txtPwdAgain.Text)
            {
                lblPrompt.Text = "两次输入的密码不相同";
                lblPrompt.Visible = true;
                txtNewPwd.Text = "";
                txtPwdAgain.Text = "";
            }
            else
            {
                string connStr = "server=.;database=MyLibrary;Integrated Security=True;";
                SqlConnection conn = new SqlConnection(connStr);
                conn.Open();
                string str = "select * from LibraryUser where userName = '" + txtNewName.Text + "'";
                SqlCommand cmd = new SqlCommand(str, conn);
                //查看用户名是否存在
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count != 0)
                {
                    MessageBox.Show("用户名已存在");
                }
                else
                {
                    try
                    {
                        string sex="";
                        if (rbMale.Checked == true)
                            sex = rbMale.Text;
                        else
                            sex = rbFemale.Text;

                        string InsertSql = "insert into LibraryUser (userName,userPassword,sex,times) values ('" + txtNewName.Text + "','"+ txtNewPwd.Text+"','" + sex + "',0)";
                        SqlCommand cmd2 = new SqlCommand(InsertSql, conn);
                        int rows = cmd2.ExecuteNonQuery();
                        MessageBox.Show("注册成功!");                        
                    }
                    finally
                    {
                        conn.Close();
                        this.Close();
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNewName_TextChanged(object sender, EventArgs e)
        {
            if (lblPrompt.Visible == true)
                lblPrompt.Visible = false;
        }

        private void txtNewPwd_TextChanged(object sender, EventArgs e)
        {
            if (txtNewPwd.Text!="")
                lblPrompt.Visible = false;
        }

        private void txtPwdAgain_TextChanged(object sender, EventArgs e)
        {
            if (txtPwdAgain.Text!="")
                lblPrompt.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            系统时间.Text = "时间：" + DateTime.Now.ToString();
        }
    }
}

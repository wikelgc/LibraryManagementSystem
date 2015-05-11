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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connStr = "server=.;database=MyLibrary;Integrated Security=True;";
            //
            //
            if (rbAdmin.Checked == true)
            {
                //进入管理员的表进行判断
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string sql = "select adminPassword,times from LibraryAdmin where adminName = @name";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", txtName.Text);
                        conn.Open();
                        //查询密码和错误次数，返回datarader
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            //判断用户名是否存在
                            if (dr.Read())
                            {
                                string pwd = dr["adminPassword"].ToString();
                                //错误次数
                                int times = Convert.ToInt32(dr["times"]);
                                //关闭datareader，独享conn
                                dr.Close();

                                //判断错误次数是否等于3次
                                if (times == 3)
                                {
                                    MessageBox.Show("重试次数超过3次");
                                }
                                else
                                {
                                    string update = "";
                                    if (pwd == txtPwd.Text)
                                    {
                                        //登录成功
                                        frmAdmin frmA = new frmAdmin();
                                        this.Hide();
                                        frmA.Show();
                                        //登陆成功，错误次数清0
                                        update = "update LibraryAdmin set times = 0 where adminName='" + txtName.Text + "'";
                                    }
                                    else
                                    {
                                        MessageBox.Show("密码错误！还剩" + (3 - times - 1) + "次输入机会");
                                        //密码输入错误，给当前登陆的用户错误次数+1
                                        update = "update LibraryAdmin set times = times + 1 where adminName='" + txtName.Text + "'";

                                    }

                                    cmd.CommandText = update;
                                    cmd.ExecuteNonQuery();

                                }
                            }
                            else
                            {
                                MessageBox.Show("用户名不存在");
                            }
                        }
                    }
                }
            }
            //   
            //
            else if (rbUser.Checked == true)
            {
                //进入用户表进行判断
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string sql = "select userPassword,times from LibraryUser where userName = @name";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", txtName.Text);
                        conn.Open();
                        //查询密码和错误次数，返回datarader
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            //判断用户名是否存在
                            if (dr.Read())
                            {
                                string pwd = dr["userPassword"].ToString();
                                //错误次数
                                int times = Convert.ToInt32(dr["times"]);
                                //关闭datareader，独享conn
                                dr.Close();

                                //判断错误次数是否等于3次
                                if (times == 3)
                                {
                                    MessageBox.Show("重试次数超过3次");
                                }
                                else
                                {
                                    string update = "";
                                    if (pwd == txtPwd.Text)
                                    {  
                                        //登录成功
                                        AddLoginRecord();
                                        frmUser frm = new frmUser();
                                        this.Hide();
                                        frm.Show();
                                        //登陆成功，错误次数清0
                                        update = "update LibraryUser set times = 0 where userName='" + txtName.Text + "'";
                                    }
                                    else
                                    {
                                        MessageBox.Show("密码错误！还剩" + (3 - times - 1) + "次输入机会");
                                        //密码输入错误，给当前登陆的用户错误次数+1
                                        update = "update LibraryUser set times = times + 1 where userName='" + txtName.Text + "'";

                                    }

                                    cmd.CommandText = update;
                                    cmd.ExecuteNonQuery();

                                }
                            }
                            else
                            {
                                MessageBox.Show("用户名不存在");
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择权限");
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            string connStr = "server=.;database=MyLibrary;Integrated Security=True;";
            if (rbUser.Checked == true)
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string update = "update LibraryUser set times = 0 where userName='" + txtName.Text + "'";
                    using (SqlCommand cmd = new SqlCommand(update, conn))
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string update = "update LibraryAdmin set times = 0 where adminName='" + txtName.Text + "'";
                    using (SqlCommand cmd = new SqlCommand(update, conn))
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister frm = new frmRegister();
            frm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            frmModifyPwd frm = new frmModifyPwd();
            frm.Show();
        }

        private void AddLoginRecord()
        {
            string name=txtName.Text;
            string connStr = "server=.;database=MyLibrary;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connStr);
            string sql = "insert into LoginRecord(userName) values('" + name + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteNonQuery();            
            conn.Close();
        }
        private void DeleteLoginRecord()
        {
            string connStr = "server=.;database=MyLibrary;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connStr);
            string sql = "delete from LoginRecord"; 
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteNonQuery();            
            conn.Close();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DeleteLoginRecord();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            系统时间.Text = "时间：" + DateTime.Now.ToString();
        }
    }
}

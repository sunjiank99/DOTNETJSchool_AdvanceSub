using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Test = AdvanceSub.cn.com.sngoo.app8;

namespace AdvanceSub
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Test.database SQL = new Test.database();
            if (SQL.verifyPassWord(ID.Text.ToString(), PS.Text.ToString()))
            {
                if (SQL.verifyUserRole(ID.Text.ToString()))
                {


                    Main mainView = new Main();


                    this.Hide();
                    mainView.ShowDialog();
                    this.ID.Text = string.Empty;
                    this.PS.Text = string.Empty;

                    this.Show();
                }
                else
                {
                    MessageBox.Show("没有登陆权限");
                }

            }
            else
            {
                MessageBox.Show("账户或密码错误");

            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}

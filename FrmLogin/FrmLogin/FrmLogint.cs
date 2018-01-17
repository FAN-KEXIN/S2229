using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmLogin
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "")
            {
                MessageBox.Show("用户或密码不能为空", "提示");
            }
            else
            {
                string userName = textBox1.Text;
                string pwd = textBox2.Text;
               // bool isOK = false;
              
                foreach (LoginInfo item in array)
                {
                    if(item!=null)
                    {
                        if (item.Emai == userName && item.Password == pwd)
                        {
                           
                            label4.Visible = false;
                           // isOK = true;
                            frmMain a = new frmMain();
                            a.lblName.Text = "欢迎，" + item.Name;
                            a.Show();
                            this.Hide();
                            break;
                            
                        }
                    }
                }

               

               
            }
        }
        public LoginInfo[] array;
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            array = new LoginInfo[10];
            LoginInfo info1 = new LoginInfo();
            info1.Name = "孙丽丽";
            info1.Id = "123";
            info1.Emai = "123@qq.com";
            info1.Password = "123";
            array[0] = info1;
            label4.Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegist b = new FrmRegist();
            b.fl = this;
            b.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
      
    }
}

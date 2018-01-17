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
    public partial class FrmRegist : Form
    {
        public FrmRegist()
        {
            InitializeComponent();
        }
        public FrmLogin fl;

        private void button1_Click(object sender, EventArgs e)
        {
            if (kong())
            {
                LoginInfo li = new LoginInfo();
                li.Name = textBox1.Text;
                li.Id = textBox2.Text;
                li.Emai = textBox3.Text;
                li.Password = textBox5.Text;
                for (int i = 0; i < fl.array.Length; i++)
                {
                    // lo[i] = new login();
                    if (fl.array[i] == null)
                    {
                        fl.array[i] = li;

                        break;
                    }
                }
                    if (textBox3.Text != textBox4.Text)
                    {
                        MessageBox.Show("两次邮箱必须一样");

                    }
                    else if (textBox5.Text != textBox6.Text)
                    {
                        MessageBox.Show("两次邮箱必须一样");

                    }
                    else
                    {

                        MessageBox.Show("注册成功");
                        //FrmLogin s = new FrmLogin();
                        fl.Visible = true;
                   

                   }

                
            }
        }
        //非空
        public bool kong()
        {
            if(this.textBox1.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入完整信息","提示");
                return false;
            }
            else if (this.textBox2.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入完整信息", "提示");
                return false;
            }
            else if (this.textBox3.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入完整信息", "提示");
                return false;
            }
            else if (this.textBox4.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入完整信息", "提示");
                return false;
            }
            else if (this.textBox5.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入完整信息", "提示");
                return false;
            }
            else if (this.textBox6.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入完整信息", "提示");
                return false;
            }
            else
            {
                return true;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FrmRegist_Load(object sender, EventArgs e)
        {

        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)

        {
            if (comboBox1.SelectedIndex == 0)
            {
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("账号或密码为空");
                    return;
                }
                string sqlStr = "select * from LoginCheck where LoginId='" + textBox1.Text + "' and Pswd='" + textBox2.Text + "'";
                DataSet ds = DataBase.Querysql(sqlStr);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    ChooseForm f = new ChooseForm();

                    f.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("账号或密码错误！");
            }
            else
                MessageBox.Show("转到学生登陆！");



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

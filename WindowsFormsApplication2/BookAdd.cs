using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class BookAdd : Form
    {
        public BookAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlStr =string.Format( "insert into BookIfo (BookId,BookName,Author) values ('{0}','{1}','{2}')",textBox1.Text,textBox2.Text,textBox3.Text);
            int i;
            i = DataBase.Excutesql(sqlStr);
            if (i > 0)
                MessageBox.Show("添加成功");
            else
                MessageBox.Show("添加失败");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

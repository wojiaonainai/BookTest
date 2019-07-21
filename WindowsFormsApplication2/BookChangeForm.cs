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
    public partial class BookChangeForm : Form
    {
        int Iflag;
        public BookChangeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlStr = "select BookId as 编号,BookName as 书名,Author as 作者 from BookIfo";
            DataSet ds = DataBase.Querysql(sqlStr);
            dataGridView1.DataSource = ds.Tables[0];
            this.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请先搜索要删除的图书");
            label1.Visible = true;
            textBox1.Visible = true;
            button5.Visible = true;
            Iflag = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BookAdd f = new BookAdd();
            f.Show();
        }

        private void BookChangeForm_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sqlDelete = string.Format("delete from BookIfo where BookId='{0}'", textBox1.Text);
            int i = DataBase.Excutesql(sqlDelete);
            if (i > 0)
            {
                MessageBox.Show("删除成功");
            }
            else
            {
                MessageBox.Show("删除失败");

            }
            label1.Visible = false;
            textBox1.Visible = false;
            button5.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BookRevise f = new BookRevise();
            f.Show();
        }
    }
}

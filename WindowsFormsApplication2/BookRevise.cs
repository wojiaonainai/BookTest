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
    public partial class BookRevise : Form
    {
        public BookRevise()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlStr = string.Format("select * from BookIfo where BookId='{0}' or BookName='{0}' or Author='{0}'", textBox1.Text);
            DataSet ds = new DataSet();
            ds = DataBase.Querysql(sqlStr);
            dataGridView1.DataSource = ds.Tables[0];
            this.Refresh();
                
        }

        private void BookRevise_Load(object sender, EventArgs e)
        { 
        }

        private void dataGridView1_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlStr = string.Format("delete from BookIfo where BookId='{0}'", textBox1.Text);
            int i = DataBase.Excutesql(sqlStr);
            if (i > 0)
                MessageBox.Show("删除成功！");
            else
                MessageBox.Show("删除失败!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

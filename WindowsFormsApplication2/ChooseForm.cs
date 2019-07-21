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
    public partial class ChooseForm : Form
    {
        public ChooseForm()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string sqlStr = "select BookId as 编号,BookName as 书名,Author as 作者 from BookIfo";
            //DataSet ds = DataBase.Querysql(sqlStr);
            //dataGridView1.DataSource = ds.Tables[0];
            //this.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BookChangeForm f = new BookChangeForm();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RevisedPswd f = new RevisedPswd();
            f.Show();
        }
    }
}

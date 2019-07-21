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
    public partial class RevisedPswd : Form
    {
        public RevisedPswd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
            String str1 = string.Format("select * from LoginCheck where Pswd='{0}'", textBox1.Text);
            String str2 = string.Format("update LoginCheck set Pswd='{0}' where Pswd='{1}'", textBox2.Text,textBox1.Text);
            DataSet ds = DataBase.Querysql(str1);

            if (ds.Tables[0].Rows.Count > 0)
            {
                int j = DataBase.Excutesql(str2);
                MessageBox.Show("更改成功！");
            }
            else
                MessageBox.Show("旧密码错误！");
            MessageBox.Show("重复窗口");
        }
    }
}

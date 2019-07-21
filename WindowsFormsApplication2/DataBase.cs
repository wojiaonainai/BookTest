using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace WindowsFormsApplication2
{
    public class DataBase
    {
        public static DataSet Querysql(string sqlStr)
        {
            SqlConnection sqlConnection1 = new SqlConnection("Data Source=DESKTOP-C5MDVV3;Initial Catalog=ManageIfo;uid=sa;pwd=5201314asd");//创建数据库连接(字符串中是我个人的数据库信息)

            sqlConnection1.Open();      //打开数据库连接
            SqlDataAdapter Apder = new SqlDataAdapter(sqlStr, sqlConnection1);
            DataSet ds=new DataSet();
            Apder.Fill(ds);
            sqlConnection1.Close();
            return ds;
        }
        public static int Excutesql(string sqlStr)
        {
            SqlConnection sqlConnection1 = new SqlConnection("Data Source=DESKTOP-C5MDVV3;Initial Catalog=ManageIfo;uid=sa;pwd=5201314asd");//创建数据库连接(字符串中是我个人的数据库信息)

            sqlConnection1.Open();      //打开数据库连接
            SqlDataAdapter Apder = new SqlDataAdapter(sqlStr, sqlConnection1);
            SqlCommand cmd = new SqlCommand(sqlStr, sqlConnection1);
            int i = cmd.ExecuteNonQuery();
            sqlConnection1.Close();
            return i;
        }
    }
}

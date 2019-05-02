using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using IBatisNet.Common;
using IBatisNet.DataMapper;
using System.Windows.Forms;

namespace Timmy
{
    public class DAO
    {
        public static void connection()
        {
            try
            {
                IList<Mapper> list = Mapper.Instance().QueryForList<Mapper>("SelectMapper", null);
                //dataGridView1.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            /*
            string strConn = @"Data Source=..\..\..\TimmyDB.db";
            using (SQLiteConnection conn = new SQLiteConnection(strConn))
            {
                conn.Open();
                //string sql = "INSERT INTO site VALUES ('네이버', 'naver.com')";
                //SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                //cmd.ExecuteNonQuery();
                conn.Close();
            }
            */
        }
    }
}

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MusicListManagerment
{
    public class KetNoiCSDL
    {
        static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-IQ3L6DB;Initial Catalog=MyMusic;Integrated Security=True");
        public static DataTable LayBang(string sql)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable kq = new DataTable(); 
            try
            {
                da.Fill(kq);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi load dữ liệu!\n",ex.ToString());
            }

            con.Close();
            return kq;
        }

        public static void ThayDoiDL(string sql)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi load dữ liệu!\n", ex.ToString());
            }
            con.Close();
        }       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicListManagerment
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmDangNhap frmDN = new frmDangNhap();
            if(frmDN.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new frmThongTin());
            }
            
            //Application.Run(new frmThongTin());
            //Application.Run(new frmTheLoai());
        }
    }
}

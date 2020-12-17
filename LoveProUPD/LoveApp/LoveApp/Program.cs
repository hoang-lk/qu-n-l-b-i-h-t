using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoveApp
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
            Application.Run(new frmLoveApp());
            //Application.Run(new frmDangKy());
            //Application.Run(new frmHeThong());
            //Application.Run(new frmThongTin());
            //Application.Run(new frmCapDoi());
            //Application.Run(new frmDanhSach());
            //Application.Run(new frmLuu());
            //Application.Run(new frmLichSu());
        }
    }
}

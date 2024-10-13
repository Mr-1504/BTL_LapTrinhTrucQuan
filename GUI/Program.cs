using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new SettingForm("LT20240001"));
            Application.Run(new frmListOrders());
            //Application.Run(new frmMenuOrder()); ;
            //Application.Run(new Warehouse_ListAll());
            //Application.Run(new frmOrderDetail());
        }
    }
}

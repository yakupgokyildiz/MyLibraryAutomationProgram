using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormKOS.Model;

namespace WinFormKOS
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormHome());

            /*   if (IDataBase.DataToDataTable("select * from kullanicilar where aktif=1").Rows.Count>1)
               {
                   Application.Run(new FormLogin());
               }
               else
               {
                   Application.Run(new FormKurulum());
               }*/
            
        }
    }
}

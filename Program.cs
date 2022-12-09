/*  Author  : Bagus Budi Satoto
 *  ID      : 21.11.4076
 *  Class   : 21 IF 04
 *  School  : University Amikom Yogyakarta
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AppEntriPemasukanPengeluaran
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmNasabah());
        }
    }
}

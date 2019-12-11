using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGMI
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                if (Web_Tools.Conectado_A_Internet()) { Application.Run(new frm_Principal()); }
                else
                {
                    Web_Tools.Show_Net_Start_Error();
                    Application.Exit();
                }
            }
            catch(Exception e) { MessageBox.Show(e.ToString()); }
        }
    }
}

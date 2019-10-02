using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGMI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Normal ? FormWindowState.Minimized : FormWindowState.Normal;
        }
    }
}

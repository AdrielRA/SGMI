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
    public partial class frm_SignUp : Form
    {
        public frm_SignUp()
        {
            InitializeComponent();
        }

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            Forms_Controller.Fechar_Recente();
            Forms_Controller.Abrir_Anterior();
        }

        private void Frm_SignUp_Load(object sender, EventArgs e)
        {
            btn_Fechar.BackColor = Color.Transparent;
            btn_Fechar.Refresh();
        }
    }
}

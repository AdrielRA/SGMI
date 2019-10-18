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
    public partial class frm_CadastroMenor : Form
    {
        public frm_CadastroMenor()
        {
            InitializeComponent();
        }

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            Forms_Controller.Fechar_Recente();
            Forms_Controller.Abrir_Anterior();
        }
    }
}

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
    public partial class frm_Menu : Form
    {
        public frm_Menu()
        {
            InitializeComponent();
        }

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            Forms_Controller.Fechar_Recente();
            Forms_Controller.Abrir_Anterior();
        }

        private void Btn_Cadastrar_Click(object sender, EventArgs e)
        {
            Forms_Controller.Esconder(this);
            Forms_Controller.Abrir(new frm_CadastroMenor());
        }

        private void Btn_Consultar_Click(object sender, EventArgs e)
        {
            Forms_Controller.Esconder(this);
            Forms_Controller.Abrir(new frmConsulta_Menor());
        }
    }
}

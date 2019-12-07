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
        private int[] users_liberados_cadastrar = new int[5]
        {
            (int)Data_Controller.Credencial.Advogado,
            (int)Data_Controller.Credencial.Policial,
            (int)Data_Controller.Credencial.Delegado,
            (int)Data_Controller.Credencial.Promotor,
            (int)Data_Controller.Credencial.Juiz,
        };
        private int[] users_liberados_consultar = new int[6]
        {
            (int)Data_Controller.Credencial.Professor,
            (int)Data_Controller.Credencial.Advogado,
            (int)Data_Controller.Credencial.Policial,
            (int)Data_Controller.Credencial.Delegado,
            (int)Data_Controller.Credencial.Promotor,
            (int)Data_Controller.Credencial.Juiz,
        };

        public frm_Menu()
        {
            InitializeComponent();
            lbl_Bemvindo.Text = lbl_Bemvindo.Text.Replace("USER", Data_Controller.user_logged.Nome.ToUpper());
        }

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            Data_Controller.Reset_Saved_Login();
            Forms_Controller.Fechar_Recente();
            Forms_Controller.Abrir_Anterior();
        }

        private void Btn_Cadastrar_Click(object sender, EventArgs e)
        {
            if (users_liberados_cadastrar.Contains(Data_Controller.user_logged.Credencial))
            {
                Forms_Controller.Esconder(this);
                Forms_Controller.Abrir(new frm_CadastroMenor(null));
            }
            else
            {
                MessageBox.Show("Infelizmente você não tem\npermissão para acessar\neste recurso no momento!", "Atenção:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Btn_Consultar_Click(object sender, EventArgs e)
        {
            if (users_liberados_consultar.Contains(Data_Controller.user_logged.Credencial))
            {
                Forms_Controller.Esconder(this);
                Forms_Controller.Abrir(new frmConsulta_Menor());
            }
            else
            {
                MessageBox.Show("Infelizmente você não tem\npermissão para acessar\neste recurso no momento!", "Atenção:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

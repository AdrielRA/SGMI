using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace SGMI
{
    public partial class frm_Menu : Form
    {
        public static frm_Menu instancia;

        public frm_Menu()
        {
            InitializeComponent();
            instancia = this;
            lbl_Bemvindo.Text = lbl_Bemvindo.Text.Replace("USER", Data_Controller.user_logged.Nome.ToUpper());

            if (Web_Tools.Conectado_A_Internet()) { Data_Controller.Clear_Anexos(); }

            Data_Controller.Start_Thread(new Thread(() => Data_Controller.Start_Infrator_Insert_Watch()));
            Data_Controller.Start_Thread(new Thread(() => Data_Controller.Start_Infrator_Update_Watch()));
            Data_Controller.Start_Thread(new Thread(() => Data_Controller.Start_Infrator_Delete_Watch()));
        }


        public void Desconectar()
        {
            Invoke((MethodInvoker)delegate
            {
                MessageBox.Show("Seu usuário foi desconectado!", "Alerta:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Data_Controller.Stop_All_Threads();
                Data_Controller.Reset_Saved_Login();
                Forms_Controller.Fechar_Todos();
                Forms_Controller.Abrir_Anterior();
            });
        }

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            Data_Controller.Stop_All_Threads();
            Data_Controller.Reset_Saved_Login();
            Forms_Controller.Fechar_Recente();
            Forms_Controller.Abrir_Anterior();
        }

        private void Btn_Cadastrar_Click(object sender, EventArgs e)
        {
            if (Security_Controller.podem_cadastrar.Contains(Data_Controller.user_logged.Credencial))
            {
                Forms_Controller.Esconder(this);
                Forms_Controller.Abrir(new frm_CadastroMenor(null));
            }
            else {Security_Controller.Show_Alert(); }
        }

        private void Btn_Consultar_Click(object sender, EventArgs e)
        {
            if (Security_Controller.podem_consultar.Contains(Data_Controller.user_logged.Credencial))
            {
                Forms_Controller.Esconder(this);
                Forms_Controller.Abrir(new frmConsulta_Menor());
            }
            else { Security_Controller.Show_Alert(); }
        }
    }
}

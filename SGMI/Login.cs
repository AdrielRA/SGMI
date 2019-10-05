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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
            Forms_Controller.Start_Controller(pnl_Tela);
        }

        #region botões_controle_janela
        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Normal ? FormWindowState.Minimized : FormWindowState.Normal;
        }
        private void Btn_MaxRes_Click(object sender, EventArgs e)
        {
            Forms_Controller.maximizado = !Forms_Controller.maximizado;
            if (Forms_Controller.maximizado)
            {
                Forms_Controller.screen_size = new Size(Screen.PrimaryScreen.Bounds.Width + 1, Screen.PrimaryScreen.WorkingArea.Size.Height + 1);
                elip_Tela.ElipseRadius = 0;
                Size = Forms_Controller.screen_size;
                Location = new Point();
            }
            else
            {
                Forms_Controller.screen_size = new Size(800, 450);
                elip_Tela.ElipseRadius = 20;
                Size = Forms_Controller.screen_size;
                Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - Width / 2, Screen.PrimaryScreen.Bounds.Height / 2 - Height / 2);
            }
            drag_Login.Activate = !Forms_Controller.maximizado;
            Forms_Controller.Redimensionar_Janelas();
        }
        #endregion

        private void Btn_Logar_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Name = txt_User.Text;
            user.Passpassword = txt_Pass.Text;
            if (Data_Controller.Validate_Login(user))
            {
                // Logar
            }
            else { MessageBox.Show("Não foi possível realizar o login!"); }
        }

        private void Btn_Solicitar_Click(object sender, EventArgs e)
        {
             Forms_Controller.Abrir(new frm_SignUp());
        }
    }
}

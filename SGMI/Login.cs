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
            VisibleChanged += Visible_Changed;
        }

        private void Visible_Changed(object sender, EventArgs e)
        {
            if (Visible)
            {
                if (Forms_Controller.Está_Aberto("frm_Menu")) { Forms_Controller.Esconder(this); }
                txt_User.Text = txt_User.HintText;
                txt_Pass.Text = txt_Pass.HintText;
                cb_KeepConnection.Checked = false;
            }
        }

        private void Btn_Logar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_User.Text) && !string.IsNullOrEmpty(txt_Pass.Text) && txt_User.Text != txt_User.HintText && txt_Pass.Text != txt_Pass.HintText)
            {
                User user = new User();
                user.Nome = txt_User.Text;
                user.Passpassword = txt_Pass.Text;

                btn_Logar.Text = "AGUARDE...";
                if (Data_Controller.Validate_Login(user))
                {
                    if (cb_KeepConnection.Checked) { Data_Controller.Save_Logged_User(user); }
                    Forms_Controller.Esconder(this);
                    Forms_Controller.Abrir(new frm_Menu());
                }
                //else { MessageBox.Show("Não foi possível realizar o login!"); }
                btn_Logar.Text = "LOGAR";
            }
            else { MessageBox.Show("Preenchar os campos corretamente!"); }
        }

        private void Btn_Solicitar_Click(object sender, EventArgs e)
        {
            Forms_Controller.Esconder(this);
            Forms_Controller.Abrir(new frm_SignUp());
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            if (Data_Controller.keep_login)
            {
                if (Data_Controller.Validate_Login(Data_Controller.user_logged))
                {
                    Forms_Controller.Esconder(this);
                    Forms_Controller.Abrir(new frm_Menu());
                }
                else
                {
                    MessageBox.Show("Sessão expirada!\nRealize um novo login.");
                    Data_Controller.Reset_Saved_Login();
                }
            }
        }
    }
}

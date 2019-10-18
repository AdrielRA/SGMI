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
        }
        
        private void Btn_Logar_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Name = txt_User.Text;
            user.Passpassword = txt_Pass.Text;
            //if (Data_Controller.Validate_Login(user))
            //{
                Forms_Controller.Esconder(this);
                Forms_Controller.Abrir(new frm_Menu());
            //}
            //else { MessageBox.Show("Não foi possível realizar o login!"); }
        }

        private void Btn_Solicitar_Click(object sender, EventArgs e)
        {
            Forms_Controller.Esconder(this);
            Forms_Controller.Abrir(new frm_SignUp());
        }
    }
}

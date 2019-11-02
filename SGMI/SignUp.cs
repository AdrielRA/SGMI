using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            Invoke((MethodInvoker)delegate
            {
                Forms_Controller.Fechar_Recente();
                Forms_Controller.Abrir_Anterior();
            });
        }

        private void Frm_SignUp_Load(object sender, EventArgs e)
        {
            btn_Fechar.BackColor = Color.Transparent;
            btn_Fechar.Refresh();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                User new_user = new User();
                new_user.Name = txt_UserName.Text;
                new_user.Credentials = cmb_Credencial.SelectedItem.ToString();
                new_user.Telefone = txt_Telefone.Text;
                new_user.Email = txt_Email.Text;
                new_user.Passpassword = txt_ConformaSenha.Text;

                Data_Controller.Add_User(new_user);

                MessageBox.Show("Usuário Salvo!");

                new Thread(() => Btn_Fechar_Click(btn_Fechar, new EventArgs())).Start();
            }
            catch { MessageBox.Show("Usuário Não Foi Salvo!"); }

            //foreach (Control c in pnl_Tela.Controls)
            //{
            //    if (c is Bunifu.Framework.UI.BunifuMaterialTextbox)
            //    {
            //        Bunifu.Framework.UI.BunifuMaterialTextbox txtBox = c as Bunifu.Framework.UI.BunifuMaterialTextbox;
            //        txtBox.Text = txtBox.HintText;
            //    }
            //    else if (c is ComboBox) { (c as ComboBox).SelectedIndex = -1; }
            //}
            //txt_UserName.Focus();
        }

        private void txt_Email_Changed(object sender, EventArgs e) { Validar(); }
        private void txt_Senha_Changed(object sender, EventArgs e) { Validar(); }
        private void txt_Nome_Changed(object sender, EventArgs e) { Validar(); }
        private void cmb_Credential_Changed(object sender, EventArgs e) { Validar();  }

        private void Validar()
        {
            btn_Salvar.Visible = !string.IsNullOrEmpty(txt_UserName.Text) && cmb_Credencial.SelectedIndex >= 0
                && txt_Email.Text == txt_ConfirmaEmail.Text && !string.IsNullOrEmpty(txt_Senha.Text)
                && !string.IsNullOrEmpty(txt_ConformaSenha.Text) && txt_Senha.Text == txt_ConformaSenha.Text;
        }
    }
}

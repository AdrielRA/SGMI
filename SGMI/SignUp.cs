using MongoDB.Bson;
using MongoDB.Driver;
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

            cmb_Credencial.Items.Add("SELECIONE");
            for (int i = 1; i < Data_Controller.Credenciais.Count; i++)
            {
                cmb_Credencial.Items.Add(Data_Controller.Credenciais[i]);
            }

            cmb_Credencial.SelectedIndex = 0;
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
                new_user.Nome = txt_UserName.Text;
                new_user.Credencial = (cmb_Credencial.SelectedIndex) * -1;
                new_user.Telefone = Data_Formater.Just_Numbers(txt_Telefone.Text);
                new_user.Email = txt_Email.Text;
                new_user.Passpassword = txt_ConformaSenha.Text;
                if (!Data_Controller.Exists_User(new_user))
                {
                    Data_Controller.Add_User(new_user);
                    new Thread(() => Btn_Fechar_Click(btn_Fechar, new EventArgs())).Start();
                }
                else { MessageBox.Show("Esse usuário já existe"); }
            }
            catch { MessageBox.Show("Usuário Não Foi Salvo!"); }
        }
        
        private void txt_Email_Changed(object sender, EventArgs e) { Validar(); }
        private void txt_Senha_Changed(object sender, EventArgs e) { Validar(); }
        private void txt_Nome_Changed(object sender, EventArgs e) { Validar(); }
        private void cmb_Credential_Changed(object sender, EventArgs e) { Validar();  }

        private void Validar()
        {
            btn_Salvar.Visible = !string.IsNullOrEmpty(txt_UserName.Text) && cmb_Credencial.SelectedIndex > 0
                && Data_Validate.Email(txt_Email.Text)
                && txt_Email.Text == txt_ConfirmaEmail.Text && !string.IsNullOrEmpty(txt_Senha.Text)
                && !string.IsNullOrEmpty(txt_ConformaSenha.Text) && txt_Senha.Text == txt_ConformaSenha.Text;
        }

        private void txt_Telefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            Data_Formater.Limiter_Number(txt_Telefone, e);
        }

        private void txt_Telefone_OnValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Telefone.Text))
            {
                txt_Telefone.OnValueChanged -= txt_Telefone_OnValueChanged;
                txt_Telefone.Text = Data_Formater.Mask_Tel(txt_Telefone.Text);
                SendKeys.Send("{END}");
                txt_Telefone.OnValueChanged += txt_Telefone_OnValueChanged;
            }
        }
    }
}

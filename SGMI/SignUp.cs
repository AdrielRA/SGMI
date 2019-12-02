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
                new_user.Credentials = cmb_Credencial.SelectedItem.ToString() + " em Análise";
                new_user.Telefone = Data_Formater.Just_Numbers(txt_Telefone.Text);
                new_user.Email = txt_Email.Text;
                new_user.Passpassword = txt_ConformaSenha.Text;
                if (!Verific_users(new_user))
                {
                    Data_Controller.Add_User(new_user);

                MessageBox.Show("Usuário Salvo!");

                new Thread(() => Btn_Fechar_Click(btn_Fechar, new EventArgs())).Start();
            }
            catch { MessageBox.Show("Usuário Não Foi Salvo!"); }
        }
        public bool Verific_users(User user)
        {
            var filter = Builders<BsonDocument>
                .Filter.And(Builders<BsonDocument>
                .Filter.Eq("Nome", user.Name), Builders<BsonDocument>
                .Filter.Eq("Telefone", user.Telefone), Builders<BsonDocument>
                .Filter.And(Builders<BsonDocument>
                .Filter.Eq("Email", user.Email)), Builders<BsonDocument>
                .Filter.Eq("Passpassoword", user.Passpassword));


            bool ja_existe = !Data_Controller.collection_users.Find(filter.ToBsonDocument()).Any();
            return ja_existe;
        }
        private void txt_Email_Changed(object sender, EventArgs e) { Validar(); }
        private void txt_Senha_Changed(object sender, EventArgs e) { Validar(); }
        private void txt_Nome_Changed(object sender, EventArgs e) { Validar(); }
        private void cmb_Credential_Changed(object sender, EventArgs e) { Validar();  }

        private void Validar()
        {
            btn_Salvar.Visible = !string.IsNullOrEmpty(txt_UserName.Text) && cmb_Credencial.SelectedIndex >= 0
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

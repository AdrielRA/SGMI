﻿using System;
using System.Windows.Forms;

namespace SGMI
{
    public partial class frm_Verificação : Form
    {
        private string codigo_verificação, email;
        public bool verificado = false;

        public frm_Verificação(string email)
        {
            InitializeComponent();
            
            this.email = email;
            if (!string.IsNullOrEmpty(email))
            {
                codigo_verificação = Get_New_Code();
                if (Web_Tools.Conectado_A_Internet()) { Web_Tools.Send_Verification(codigo_verificação, email); }
                else { Web_Tools.Show_Net_Error(); }
            }
            else { Close(); }
        }

        private string Get_New_Code()
        {
            int n1, n2, n3, n4, n5, n6;
            Random random = new Random((int)DateTime.Now.Ticks);

            n1 = random.Next(0, 10);
            n2 = random.Next(0, 10);
            n3 = random.Next(0, 10);
            n4 = random.Next(0, 10);
            n5 = random.Next(0, 10);
            n6 = random.Next(0, 10);

            return string.Format("{0}{1}{2}{3}{4}{5}", n1, n2, n3, n4, n5, n6);
        }

        private void btn_ReenviarCod_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Deseja realmente\n\nenviar novo código?", "Atenção:", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (res == DialogResult.Yes)
            {
                if (Web_Tools.Conectado_A_Internet())
                {
                    codigo_verificação = Get_New_Code();
                    Web_Tools.Send_Verification(codigo_verificação, email);

                    txt_Codigo.Text = txt_Codigo.HintText;
                }
                else { Web_Tools.Show_Net_Error(); }
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            verificado = false;
            Close();
        }

        private void btn_Verificar_Click(object sender, EventArgs e)
        {
            if (txt_Codigo.Text.Equals(codigo_verificação))
            {
                verificado = true;
                MessageBox.Show("Verificado com sucesso!");
                Close();
            }
            else
            {
                verificado = false;
                var res = MessageBox.Show("Código inválido!\n\nEnviar novo código?", "Falha:", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (res == DialogResult.Yes)
                {
                    if (Web_Tools.Conectado_A_Internet())
                    {
                        codigo_verificação = Get_New_Code();
                        Web_Tools.Send_Verification(codigo_verificação, email);
                        txt_Codigo.Text = txt_Codigo.HintText;
                    }
                    else { Web_Tools.Show_Net_Error(); }
                }
            }
        }

        private void txt_Codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Data_Formater.Limiter_Number(txt_Codigo, e);
        }
    }
}

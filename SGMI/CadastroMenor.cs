﻿using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace SGMI
{
    public partial class frm_CadastroMenor : Form
    {
        private Infrator infrator;
        private bool new_infrator = false;
        private List<int> infrações_to_remove;
        private List<Infração> infrações_to_add;

        public frm_CadastroMenor(Infrator infrator)
        {
            InitializeComponent();
            this.infrator = infrator;
            date_Infra.Value = DateTime.Today;
            btn_AddInfra.Click += (sender, EventArgs) => { btn_AddInfra_Click(sender, EventArgs, null, true); };
            new_infrator = infrator == null;
            infrações_to_remove = new List<int>();
            infrações_to_add = new List<Infração>();
            if (new_infrator) { this.infrator = new Infrator(); }
            else
            {
                txt_RG.Enabled = false;
                Load_Infos();
            }
        }

        private void Load_Infos()
        {
            txt_Nome.Text = infrator.Nome;
            txt_RG.Text = infrator.Rg;
            txt_CPF.Text = infrator.Cpf;
            date_Niver.Value = infrator.Data_nascimento;
            txt_Sexo.Text = infrator.Sexo.ToString();
            txt_Mãe.Text = infrator.Mãe;
            txt_Logradouro.Text = infrator.Logradouro;
            txt_NumRes.Text = infrator.Num_residência;
            txt_Bairro.Text = infrator.Bairro;
            txt_Cidade.Text = infrator.Cidade;
            txt_UF.Text = infrator.Uf;

            infrator.Infrações.ForEach(delegate (Infração inf)
            {
                btn_AddInfra_Click(btn_AddInfra, new EventArgs(), inf, false);
            });
            infrações_to_add = infrator.Infrações.ToList();
        }

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            Invoke((MethodInvoker)delegate
            {
                Forms_Controller.Fechar_Recente();
                Forms_Controller.Abrir_Anterior();
            });
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            Infrator infrator_original = null;
            if (!new_infrator)
            {
                infrator_original = Data_Controller.Clone<Infrator>(infrator);
                infrator_original.Infrações = infrator.Infrações.ToList();
            }
            else infrator.Data_registro = DateTime.Now;

            infrator.Nome = txt_Nome.Text;
            infrator.Rg = Data_Formater.Just_Numbers(txt_RG.Text);
            infrator.Cpf = Data_Formater.Just_Numbers(txt_CPF.Text);
            infrator.Data_nascimento = date_Niver.Value;

            infrator.Sexo = txt_Sexo.Text != "" ? txt_Sexo.Text.ToUpper()[0] : '-';
            infrator.Mãe = txt_Mãe.Text;
            infrator.Logradouro = txt_Logradouro.Text;
            infrator.Num_residência = txt_NumRes.Text;
            infrator.Bairro = txt_Bairro.Text;
            infrator.Cidade = txt_Cidade.Text;
            infrator.Uf = txt_UF.Text.ToUpper();

            infrator.Infrações = new List<Infração>();
            foreach (Infração inf in infrações_to_add)
            {
                infrator.Infrações.Add(inf);
            }

            for (int i = 0; i < infrações_to_remove.Count; i++)
            {
                infrator.Infrações.RemoveAt(infrações_to_remove[i]);
            }
            var filter = Builders<Infrator>.Filter.Eq("Rg", infrator.Rg);
            Infrator infrator_from_mongo = Data_Controller.Collection_Infratores.Find(filter).FirstOrDefault();

            if (infrator_from_mongo != null && !Data_Controller.isEquals(infrator_from_mongo, infrator_original))
            {
                MessageBox.Show("Existem inconsistências na informação\n\nPor favor reinicie o sistema\ne tente novamente!", "Atenção:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Data_Controller.Add_Infrator(infrator, infrator_original);
                new Thread(() => Btn_Fechar_Click(btn_Voltar, new EventArgs())).Start();
            }
        }

        private void btn_AddInfra_Click(object sender, EventArgs e, Infração infração,bool verificar)
        {
            
            if (!verificar || !string.IsNullOrEmpty(txt_Descri_Infra.Text))
            {
                if (infração == null)
                {
                    infração = new Infração();
                    infração.Descrição = txt_Descri_Infra.Text;
                    infração.Data_ocorrência = date_Infra.Value;
                    infração.Data_registro = DateTime.Now;

                    infrações_to_add.Add(infração);
                    date_Infra.Value = DateTime.Today;
                }

                lb_Infrações.Items.Add(string.Format("{0:dd/MM/yyyy} | {1, -50}", infração.Data_registro, infração.Descrição.Length <= 50 ? infração.Descrição : infração.Descrição.Substring(0, 47) + "..."));

                txt_Descri_Infra.Text = "";
            }
            else
            {
                MessageBox.Show("A descrição não deve estar vazia!", "Atenção:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lb_Infrações_DrawItem(object sender, DrawItemEventArgs e)
        {
            bool isItemSelected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected);
            int itemIndex = e.Index;
            if (itemIndex >= 0 && itemIndex < lb_Infrações.Items.Count)
            {
                Graphics g = e.Graphics;

                SolidBrush backgroundColorBrush = new SolidBrush((isItemSelected) ? Color.Maroon : Color.WhiteSmoke);
                g.FillRectangle(backgroundColorBrush, e.Bounds);

                string itemText = lb_Infrações.Items[itemIndex].ToString();

                SolidBrush itemTextColorBrush = (isItemSelected) ? new SolidBrush(Color.WhiteSmoke) : new SolidBrush(Color.Maroon);
                g.DrawString(itemText, e.Font, itemTextColorBrush, lb_Infrações.GetItemRectangle(itemIndex).Location);

                backgroundColorBrush.Dispose();
                itemTextColorBrush.Dispose();
            }
            e.DrawFocusRectangle();
        }

        private void btn_RemInfra_Click(object sender, EventArgs e)
        {
            try
            {
                infrações_to_remove.Add(lb_Infrações.SelectedIndex);
                //infrator.Infrações.RemoveAt();
                lb_Infrações.Items.Remove(lb_Infrações.SelectedItem);
            }
            catch { }
        }

        private void lb_Infrações_DoubleClick(object sender, EventArgs e)
        {
            if (lb_Infrações.SelectedItem != null)
            {
                new frm_Detalhes(infrações_to_add[lb_Infrações.SelectedIndex]).ShowDialog();

            }
        }

        // >>>>> Formatação dos valores dos campos <<<<<
        private void txt_OnValueChanged(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuMaterialTextbox txtBox = sender as Bunifu.Framework.UI.BunifuMaterialTextbox;
            if (!string.IsNullOrEmpty(txtBox.Text))
            {
                txtBox.OnValueChanged -= txt_OnValueChanged;
                if (txtBox.Name.Contains("CPF")) { txtBox.Text = Data_Formater.Mask_CPF(txtBox.Text); }
                else { txtBox.Text = Data_Formater.Mask_RG(txtBox.Text); }
                SendKeys.Send("{END}");
                txtBox.OnValueChanged += txt_OnValueChanged;
            }
        }
        private void txt_Upper_OnValueChanged(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuMaterialTextbox txtBox = sender as Bunifu.Framework.UI.BunifuMaterialTextbox;
            if (!string.IsNullOrEmpty(txtBox.Text))
            {
                txtBox.OnValueChanged -= txt_Upper_OnValueChanged;
                txtBox.Text = txtBox.Text.ToUpper();
                SendKeys.Send("{END}");
                txtBox.OnValueChanged += txt_Upper_OnValueChanged;
            }
        }

        private void txt_CPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            Data_Formater.Limiter_Number(txt_CPF, e);
        }
        private void txt_RG_KeyPress(object sender, KeyPressEventArgs e)
        {
            Data_Formater.Limiter_Number(txt_RG, e);
        }
        private void txt_NumRes_KeyPress(object sender, KeyPressEventArgs e)
        {
            Data_Formater.Limiter_Number(txt_NumRes, e);
        }
        private void txt_Sexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Data_Formater.Limiter_Sexo(txt_Sexo, e);
        }
        private void txt_Text_KeyPress(object sender, KeyPressEventArgs e)
        {
            Data_Formater.Limiter_Text(sender, e, true);
        }
        private void txt_UF_KeyPress(object sender, KeyPressEventArgs e)
        {
            Data_Formater.Limiter_Text(sender, e, false);
        }
    }
}

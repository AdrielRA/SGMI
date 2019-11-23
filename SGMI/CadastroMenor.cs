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
    public partial class frm_CadastroMenor : Form
    {
        private Infrator infrator;

        public frm_CadastroMenor(Infrator infrator)
        {
            InitializeComponent();
            this.infrator = infrator;
            date_Infra.Value = DateTime.Today;
            btn_AddInfra.Click += (sender, EventArgs) => { btn_AddInfra_Click(sender, EventArgs, null); };
            if (infrator == null) { this.infrator = new Infrator(); }
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
                btn_AddInfra_Click(btn_AddInfra, new EventArgs(), inf);
            });
            
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
            try
            {
                infrator.Nome = txt_Nome.Text;
                infrator.Rg = txt_RG.Text;
                infrator.Cpf = txt_CPF.Text;
                infrator.Data_nascimento = date_Niver.Value;
                infrator.Sexo = txt_Sexo.Text.ToUpper()[0];
                infrator.Mãe = txt_Mãe.Text;
                infrator.Logradouro = txt_Logradouro.Text;
                infrator.Num_residência = txt_NumRes.Text;
                infrator.Bairro = txt_Bairro.Text;
                infrator.Cidade = txt_Cidade.Text;
                infrator.Uf = txt_UF.Text.ToUpper();
                infrator.Data_registro = DateTime.Now;

                Data_Controller.Add_Infrator(infrator);
                MessageBox.Show("Infrator salvo!");

                new Thread(() => Btn_Fechar_Click(btn_Voltar, new EventArgs())).Start();
            }
            catch
            {
                MessageBox.Show("Não foi possível salvar!\n\nVerifique todos os\ncampos e tente novamente!");
            }
        }

        private void btn_AddInfra_Click(object sender, EventArgs e, Infração infração)
        {
            if (infração == null)
            {
                infração = new Infração();
                infração.Descrição = txt_Descri_Infra.Text;
                infração.Data_ocorrência = date_Infra.Value;
                infração.Data_registro = DateTime.Now;
                infrator.Infrações.Add(infração);
                date_Infra.Value = DateTime.Today;
            }

            lb_Infrações.Items.Add(string.Format("{0:dd/MM/yyyy} | {1, -50}", infração.Data_registro, infração.Descrição.Length <= 50 ? infração.Descrição : infração.Descrição.Substring(0, 47) + "..."));

            txt_Descri_Infra.Text = "";
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
                infrator.Infrações.RemoveAt(lb_Infrações.SelectedIndex);
                lb_Infrações.Items.Remove(lb_Infrações.SelectedItem);
            }
            catch { }
        }
    }
}

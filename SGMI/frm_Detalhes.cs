using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGMI
{
    public partial class frm_Detalhes : Form
    {
        private Infração infração;

        private string[] path_anexos;
        public frm_Detalhes(Infração infração)
        {
            this.infração = infração;
            InitializeComponent();
            if (infração != null)
            {
                date_Registro.Text = infração.Data_registro.ToShortDateString();
                date_Ocorrido.Text = infração.Data_ocorrência.ToShortDateString();
                txt_Desc.Text = infração.Descrição;

                Load_Anexos();
            }
            else
            {
                MessageBox.Show("Algo impossibilitou a\nvisualização desta infração!", "Falha:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void Load_Anexos()
        {
            path_anexos = Data_Controller.Read_Anexos(infração.Id);

            lb_Anexos.Items.Clear();
            foreach (string path in path_anexos)
            {
                string nome_anexo = path.Split('\\').LastOrDefault();
                lb_Anexos.Items.Add(nome_anexo);
            }
        }

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lb_Anexos_DoubleClick(object sender, EventArgs e)
        {
            Process.Start(path_anexos[lb_Anexos.SelectedIndex]);
        }

        private void lb_Anexos_DrawItem(object sender, DrawItemEventArgs e)
        {
            bool isItemSelected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected);
            int itemIndex = e.Index;
            if (itemIndex >= 0 && itemIndex < lb_Anexos.Items.Count)
            {
                Graphics g = e.Graphics;

                SolidBrush backgroundColorBrush = new SolidBrush((isItemSelected) ? Color.Maroon : Color.WhiteSmoke);
                g.FillRectangle(backgroundColorBrush, e.Bounds);

                string itemText = lb_Anexos.Items[itemIndex].ToString();

                SolidBrush itemTextColorBrush = (isItemSelected) ? new SolidBrush(Color.WhiteSmoke) : new SolidBrush(Color.Maroon);
                g.DrawString(itemText, e.Font, itemTextColorBrush, lb_Anexos.GetItemRectangle(itemIndex).Location);

                backgroundColorBrush.Dispose();
                itemTextColorBrush.Dispose();
            }
            e.DrawFocusRectangle();
        }

        private void btn_AddAnexo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                dialog.Filter = "Pdf Files|*.pdf";
                dialog.RestoreDirectory = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    btn_Fechar.Click -= Btn_Fechar_Click;
                    Data_Controller.Add_Anexo(infração.Id, dialog.FileName, "Anexo - " + DateTime.Now.Ticks + ".pdf");
                    Load_Anexos();
                    btn_Fechar.Click += Btn_Fechar_Click;
                }
            }
        }

        private void btn_RemAnexo_Click(object sender, EventArgs e)
        {
            if(lb_Anexos.Items.Count > 0)
            {
                if (lb_Anexos.SelectedIndex >= 0)
                {
                    try
                    {
                        var reult = MessageBox.Show("Tem certeza?!", "Excluir anexo:", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (reult == DialogResult.Yes)
                        {
                            Data_Controller.Remove_Anexo(infração.Id, path_anexos[lb_Anexos.SelectedIndex]);
                            lb_Anexos.Items.RemoveAt(lb_Anexos.SelectedIndex);
                        }
                    }
                    catch { MessageBox.Show("Não foi possível\nremover o anexo!", "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else { MessageBox.Show("Selecione uma infração\npara remover!", "Atenção:", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            else { MessageBox.Show("Não existem anexos\npara remover!", "Atenção:", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
    }
}

using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGMI
{
    public partial class frm_Detalhes : Form
    {
        private Infração infração;

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
            new frm_Anexo(infração.Id, "Baixando anexos...").ShowDialog();
            lb_Anexos.Items.Clear();
            foreach (string path in Data_Controller.paths_anexos_offline)
            {
                lb_Anexos.Items.Add(path);
            }
        }

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            Data_Controller.paths_anexos_offline = null;
            Close();
        }

        private void lb_Anexos_DoubleClick(object sender, EventArgs e)
        {
            if (File.Exists(Data_Controller.path_anexos + Data_Controller.paths_anexos_offline[lb_Anexos.SelectedIndex]))
            {
                Process.Start(Data_Controller.path_anexos + Data_Controller.paths_anexos_offline[lb_Anexos.SelectedIndex]);
            }
            
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
                    FileInfo fileInfo = new FileInfo(dialog.FileName);

                    int tam_max = 16; // tamanho em MB

                    if (fileInfo.Length / 1024 <= tam_max * 1024)
                    {
                        btn_Fechar.Click -= Btn_Fechar_Click;

                        var res = MessageBox.Show("Deseja definir um\nnome para o anexo?", "Opção:", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        string nome_anexo = "Anexo";
                        if (res == DialogResult.Yes)
                        {
                            frm_Define_Nome def_nome = new frm_Define_Nome();
                            def_nome.ShowDialog();
                            nome_anexo = string.IsNullOrEmpty(def_nome.novo_nome) ? nome_anexo : def_nome.novo_nome;
                        }
                        
                        new frm_Anexo(infração.Id, dialog.FileName, nome_anexo + " - " + DateTime.Now.Ticks + ".pdf").ShowDialog();
                        
                        Load_Anexos();
                        btn_Fechar.Click += Btn_Fechar_Click;
                    }
                    else
                    {
                        MessageBox.Show("Arquivo grande!\n\nLimite de " + tam_max + "MB.", "Atenção:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
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
                            Data_Controller.Remove_Anexo(infração.Id, Data_Controller.paths_anexos_offline[lb_Anexos.SelectedIndex]);
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

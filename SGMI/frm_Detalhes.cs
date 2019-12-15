using MongoDB.Bson;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SGMI
{
    public partial class frm_Detalhes : Form
    {
        public static frm_Detalhes instancia;

        private Infração infração;

        public frm_Detalhes(Infração infração)
        {
            this.infração = infração;
            InitializeComponent();
            instancia = this;

            if (infração != null)
            {
                date_Registro.Text = infração.Data_registro.ToShortDateString();
                date_Ocorrido.Text = infração.Data_ocorrência.ToShortDateString();
                txt_Desc.Text = infração.Descrição;
            }
            else
            {
                MessageBox.Show("Algo impossibilitou a\nvisualização desta infração!", "Falha:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void Load_Anexos()
        {
            try { new frm_Anexo(infração.Id, "Baixando anexos...").ShowDialog(); }
            catch { }
            
            if (Data_Controller.tot_dow == 0 && Data_Controller.paths_anexos_offline != null) { lb_Anexos_Update(infração.Id); }
            else Close();
        }

        public void lb_Anexos_Update(ObjectId id_infração)
        {
            if (id_infração == infração.Id)
            {
                lb_Anexos.Items.Clear();
                foreach (string path in Data_Controller.paths_anexos_offline) { lb_Anexos.Items.Add(path); }
            }
        }

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            Data_Controller.paths_anexos_offline = null;
            instancia = null;
            Close();
        }

        private void lb_Anexos_DoubleClick(object sender, EventArgs e)
        {
            if (File.Exists(Data_Controller.path_anexos + Data_Controller.paths_anexos_offline[lb_Anexos.SelectedIndex]))
            {
                Process.Start(Data_Controller.path_anexos + Data_Controller.paths_anexos_offline[lb_Anexos.SelectedIndex]);
            }
            else
            {
                var res = MessageBox.Show("O arquivo não foi encontrado!\n\nDeseja tentar recarregá-lo?", "Falha:", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes) { Load_Anexos(); }
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
            if (Security_Controller.podem_editar_anexos.Contains(Data_Controller.user_logged.Credencial))
            {
                if (Web_Tools.Conectado_A_Internet())
                {
                    using (OpenFileDialog dialog = new OpenFileDialog())
                    {
                        dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        dialog.Filter = "Pdf Files|*.pdf|Files|*.jpg;*.jpeg;*.png;";
                        dialog.RestoreDirectory = true;
                        string nome_anexo="";
                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            FileInfo fileInfo = new FileInfo(dialog.FileName);

                            int tam_max = 16; // tamanho em MB

                            if (fileInfo.Length / 1024 <= tam_max * 1024)
                            {
                                btn_Fechar.Click -= Btn_Fechar_Click;

                                var res = MessageBox.Show("Deseja definir um\nnome para o anexo?", "Opção:", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                string nome_anexo_complete = dialog.FileName.Split('\\').LastOrDefault();
                                string[] div_nome = nome_anexo_complete.Split('.');
                                if (div_nome[1] == "pdf")
                                {
                                    nome_anexo = dialog.FileName.Split('\\').LastOrDefault().Replace("pdf", "");
                                }
                                else
                                {
                                    if (div_nome[1] == "jpg")
                                    {
                                        nome_anexo = dialog.FileName.Split('\\').LastOrDefault().Replace("jpg", "");
                                    }
                                    else if(div_nome[1] == "jpeg")
                                    {
                                        nome_anexo = dialog.FileName.Split('\\').LastOrDefault().Replace("jpeg", "");
                                    }
                                    else if (div_nome[1] == "png")
                                    {
                                        nome_anexo = dialog.FileName.Split('\\').LastOrDefault().Replace("png", "");
                                    }
                                }
                                if (res == DialogResult.Yes)
                                {
                                    frm_Define_Nome def_nome = new frm_Define_Nome();
                                    def_nome.ShowDialog();
                                    nome_anexo = string.IsNullOrEmpty(def_nome.novo_nome) ? nome_anexo : def_nome.novo_nome;
                                }
                                if (Web_Tools.Conectado_A_Internet())
                                {
                                    new frm_Anexo(infração.Id, dialog.FileName, nome_anexo + " - " + DateTime.Now.Ticks + "."+div_nome[1]).ShowDialog();
                                }
                                else { Web_Tools.Show_Net_Error(); }

                                //lb_Anexos_Update();
                                btn_Fechar.Click += Btn_Fechar_Click;
                            }
                            else
                            {
                                MessageBox.Show("Arquivo grande!\n\nLimite de " + tam_max + "MB.", "Atenção:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                        }
                    }
                }
                else { Web_Tools.Show_Net_Error(); }
            }
            else { Security_Controller.Show_Alert(); }
            
        }

        private void btn_RemAnexo_Click(object sender, EventArgs e)
        {
            if (Security_Controller.podem_editar_anexos.Contains(Data_Controller.user_logged.Credencial))
            {
                if (lb_Anexos.Items.Count > 0)
                {
                    if (lb_Anexos.SelectedIndex >= 0)
                    {
                        try
                        {
                            var reult = MessageBox.Show("Tem certeza?!", "Excluir anexo:", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (reult == DialogResult.Yes)
                            {
                                if (Web_Tools.Conectado_A_Internet())
                                {
                                    Data_Controller.Remove_Anexo(infração.Id, Data_Controller.paths_anexos_offline[lb_Anexos.SelectedIndex]);
                                    lb_Anexos.Items.RemoveAt(lb_Anexos.SelectedIndex);
                                }
                                else { Web_Tools.Show_Net_Error(); }
                            }
                        }
                        catch { MessageBox.Show("Não foi possível\nremover o anexo!", "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error); }                        
                    }
                    else { MessageBox.Show("Selecione uma infração\npara remover!", "Atenção:", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                }
                else { MessageBox.Show("Não existem anexos\npara remover!", "Atenção:", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            else { Security_Controller.Show_Alert(); }
        }

        private void frm_Detalhes_Load(object sender, EventArgs e)
        {
            if (infração != null)
            {
                Load_Anexos();
            }
        }
    }
}

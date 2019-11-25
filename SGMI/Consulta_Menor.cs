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
    public partial class frmConsulta_Menor : Form
    {
        private Infrator infrator;

        public frmConsulta_Menor()
        {
            InitializeComponent();
            Controle_UI(false);
            VisibleChanged += Refresh_Pesquisa;
            btn_Fechar.BackColor = Color.Transparent;
            btn_Fechar.Parent = pnl_Titulo;
        }

        private void Controle_UI(bool mostrar)
        {
            pnl_InfInfra.Visible = pnl_InfosTop.Visible = pnl_InfosBottom.Visible  = mostrar;
        }

        public void Refresh_Pesquisa(object sender, EventArgs e)
        {
            if (Visible) { PictureBox1_Click(pic_Pesquisar, new EventArgs()); }
        }

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            Forms_Controller.Fechar_Recente();
            Forms_Controller.Abrir_Anterior();
        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRG.Text))
            {
                infrator = Data_Controller.infratores.FirstOrDefault(i => i.Rg == txtRG.Text);
                Controle_UI(infrator != null);
                if (infrator != null)
                {
                    lbl_DataUltima.Text = infrator.Infrações.OrderByDescending(inf => inf.Data_ocorrência).ToList()[0].Data_ocorrência.ToString("dd/MM/yyyy");
                    lbl_Status.Text = infrator.Infrações.Count > 1 ? "Reincidente" : "Incidente";
                    lbl_Nome.Text = infrator.Nome;
                    lbl_CPF.Text = infrator.Cpf;
                    lbl_RG.Text = infrator.Rg;
                    //Mudando Cor do Panel
                    pnl_InfInfra.Controls.Clear();
                    pnl_InfInfra.BackColor = Color.White;
                    foreach (Infração i in infrator.Infrações)
                    {
                        Cria_Item_Infração(i);
                    }
                }
                else MessageBox.Show("Infrator não encontrado!");
            }
        }
       
        private void Cria_Item_Infração(Infração infração)
        {
          
            //Criando panel
            Panel pnl_BG = new Panel();
            pnl_BG.Size = new Size(pnl_InfInfra.Width, 67);
            pnl_BG.Dock = DockStyle.Top;
            pnl_BG.BackColor = Color.WhiteSmoke;
            pnl_BG.Margin = new Padding(0);

            Panel pnl_Item = new Panel();
            pnl_Item.Size = new Size(pnl_InfInfra.Width, 64);
            pnl_Item.Dock = DockStyle.Top;
            pnl_Item.BackColor = Color.White;
            pnl_Item.ForeColor = Color.DarkRed;
            pnl_Item.Margin = new Padding(0);

            Label lbl_1 = new Label();
            lbl_1.Text = "Infração:";
            lbl_1.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            lbl_1.Size = new Size(80, 32);
            lbl_1.TextAlign = ContentAlignment.MiddleLeft;
            lbl_1.Location = new Point(2, 0);

            //Criando os dois label
            Label lbl_Infra = new Label();
            lbl_Infra.Text = infração.Descrição;
            lbl_Infra.Size = new Size(pnl_InfInfra.Width - lbl_1.Width - 70, 32);
            lbl_Infra.Margin = new Padding(0);
            lbl_Infra.TextAlign = ContentAlignment.MiddleLeft;
            lbl_Infra.Location = new Point(lbl_1.Width + 5, 0);
            lbl_Infra.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;

            Label lbl_2 = new Label();
            lbl_2.Text = "Data:";
            lbl_2.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            lbl_2.Size = new Size(80, 32);
            lbl_2.TextAlign = ContentAlignment.MiddleLeft;
            lbl_2.Location = new Point(2, 32);

            Label lbl_data = new Label();
            lbl_data.Text = infração.Data_ocorrência.ToString("dd/MM/yyyy");
            lbl_data.Size = new Size(pnl_InfInfra.Width - lbl_2.Width - 70, 32);
            lbl_data.Margin = new Padding(0);
            lbl_data.TextAlign = ContentAlignment.MiddleLeft;
            lbl_data.Location = new Point(lbl_2.Width + 5, 32);
            lbl_data.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;

            //Adicionando Imagem +
            PictureBox btn_Mais = new PictureBox();
            btn_Mais.Image = Properties.Resources.btn_MaisDetalhes;
            btn_Mais.Size = new Size(40, 40);
            btn_Mais.SizeMode = PictureBoxSizeMode.Zoom;
            btn_Mais.Cursor = Cursors.Hand;
            btn_Mais.Anchor = (AnchorStyles.Right);
            btn_Mais.Location = new Point(pnl_InfInfra.Width - btn_Mais.Width - 10, 12);
            btn_Mais.Click += (sender, EventArgs) => { Ver_Mais_Infra_Click(sender, EventArgs, infração); };

            //Adicionando no picturebox
            pnl_Item.Controls.Add(lbl_1);
            pnl_Item.Controls.Add(lbl_Infra);
            pnl_Item.Controls.Add(lbl_2);
            pnl_Item.Controls.Add(lbl_data);
            pnl_Item.Controls.Add(btn_Mais);
            pnl_BG.Controls.Add(pnl_Item);
            pnl_InfInfra.Controls.Add(pnl_BG);

        }
        private void Ver_Mais_Infra_Click(object sender, EventArgs e, Infração infração)
        {
            new frm_Detalhes(infração).ShowDialog();
        }

        private void pic_Editar_Click(object sender, EventArgs e)
        {
            if(infrator != null)
            {
                Forms_Controller.Esconder(this);
                Forms_Controller.Abrir(new frm_CadastroMenor(infrator));
            }
        }
    }
}

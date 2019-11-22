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
        public frmConsulta_Menor()
        {
            InitializeComponent();
        }

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            Forms_Controller.Fechar_Recente();
            Forms_Controller.Abrir_Anterior();
        }

        private void TxtRG_KeyUp(object sender, KeyEventArgs e)
        {
            Infrator infrator = Data_Controller.infratores.FirstOrDefault(i => i.Rg == txtRG.Text);

            lbl_DataUltima.Text = infrator.Infrações.OrderByDescending(inf => inf.Data_ocorrência).ToList()[0].Data_ocorrência.ToString("dd/MM/yyyy");
            lbl_Status.Text = infrator.Infrações.Count > 1 ? "Reincidente" : "Incidente";

            // preencher dados do infrator

            foreach (Infração i in infrator.Infrações)
            {
                Cria_Item_Infração(i);
            }
        }
        private void Cria_Item_Infração(Infração infração)
        {
            Panel pnl_BG = new Panel();
            pnl_BG.Size = new Size(343, 64);
            pnl_BG.Dock = DockStyle.Top;
            pnl_BG.BackColor = Color.WhiteSmoke;
            pnl_BG.Margin = new Padding(0);

            Panel pnl_Infra = new Panel();
            pnl_Infra.Size = new Size(343, 62);
            pnl_Infra.Dock = DockStyle.Top;
            pnl_Infra.BackColor = Color.White;

            Label lbl_Infra = new Label();
            lbl_Infra.Text = "Infração: " + infração.Descrição;
            lbl_Infra.Size = new Size(303, 32);
            lbl_Infra.Dock = DockStyle.Top;

            Label lbl_data = new Label();
            lbl_data.Text = "Data: " + infração.Data_ocorrência;
            lbl_data.Size = new Size(303, 32);
            lbl_data.Dock = DockStyle.Bottom;

            PictureBox btn_Mais = new PictureBox();
            btn_Mais.Image = new Bitmap(Properties.Resources.btn_MaisDetalhes);
            btn_Mais.Size = new Size(40, 40);
            btn_Mais.Location = new Point(pnl_Infra.Width - 45, 12);
            btn_Mais.Click += (sender, EventArgs) => { Ver_Mais_Infra_Click(sender, EventArgs, infração); };

            pnl_Infra.Controls.Add(lbl_Infra);
            pnl_Infra.Controls.Add(lbl_data);
            pnl_Infra.Controls.Add(btn_Mais);
            pnl_BG.Controls.Add(pnl_Infra);
            pnl_Infrações.Controls.Add(pnl_BG);
        }
        private void Ver_Mais_Infra_Click(object sender, EventArgs e, Infração infração)
        {
            MessageBox.Show(infração.Descrição);
        }
    }
}

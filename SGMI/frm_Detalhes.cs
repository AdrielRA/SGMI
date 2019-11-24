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
    public partial class frm_Detalhes : Form
    {
        public frm_Detalhes(Infração infração)
        {
            InitializeComponent();
            txt_data.Text = string.Format(infração.Data_registro.Day+"/"+infração.Data_registro.Month+"/"+infração.Data_registro.Year);
            lb_Desc.Items.Add(infração.Descrição);
        }

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

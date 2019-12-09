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
    public partial class frm_Define_Nome : Form
    {
        public string novo_nome = "";

        public frm_Define_Nome()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Nome.Text) && txt_Nome.Text != txt_Nome.HintText)
            {
                novo_nome = txt_Nome.Text;
                Close();
            }
            else { MessageBox.Show("Nome inválido!"); }
        }

        private void txt_Nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) { btn_OK_Click(txt_Nome, new EventArgs()); }
        }
    }
}

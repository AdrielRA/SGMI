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
    public partial class frm_SignUp : Form
    {
        public frm_SignUp()
        {
            InitializeComponent();
        }

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Frm_SignUp_Load(object sender, EventArgs e)
        {
            btn_Fechar.BackColor = Color.Transparent;
            btn_Fechar.Refresh();
            btn_MaxRes.BackColor = Color.Transparent;
            btn_MaxRes.Refresh();
            


        }

        private void Btn_MaxRes_Click(object sender, EventArgs e)
        {
            Forms_Controller.maximizado = !Forms_Controller.maximizado;
            if (Forms_Controller.maximizado)
            {
                Forms_Controller.screen_size = new Size(Screen.PrimaryScreen.Bounds.Width + 1, Screen.PrimaryScreen.WorkingArea.Size.Height + 1);
                Size = Forms_Controller.screen_size;
                Location = new Point();
            }
            else
            {
                Forms_Controller.screen_size = new Size(800, 450);
                Size = Forms_Controller.screen_size;
                Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - Width / 2, Screen.PrimaryScreen.Bounds.Height / 2 - Height / 2);
            }
           
            Forms_Controller.Redimensionar_Janelas();
        }
    }
}

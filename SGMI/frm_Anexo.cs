using MongoDB.Bson;
using System;
using System.Windows.Forms;

namespace SGMI
{
    public partial class frm_Anexo : Form
    {
        public static frm_Anexo instancia;

        public frm_Anexo(ObjectId id_infração, string fileName, string newFileName)
        {
            InitializeComponent();
            instancia = this;

            Data_Controller.Add_Anexo(id_infração, fileName, newFileName);
        }

        public frm_Anexo(ObjectId id_infração, string frase)
        {
            InitializeComponent();
            instancia = this;
            lbl_Titulo.Text = frase;

            Data_Controller.Read_Anexos(id_infração);
        }

        public void Fechar()
        {
            btn_Fechar_Click(btn_Fechar, new EventArgs());
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

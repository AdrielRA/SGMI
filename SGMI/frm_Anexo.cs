﻿using MongoDB.Bson;
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
    public partial class frm_Anexo : Form
    {
        public static frm_Anexo instancia;

        public frm_Anexo(ObjectId id_infração, string fileName, string newFileName)
        {
            InitializeComponent();
            instancia = this;

            Data_Controller.Add_Anexo(id_infração, fileName, newFileName);
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

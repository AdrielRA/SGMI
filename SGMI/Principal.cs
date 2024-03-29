﻿using System;
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
    public partial class frm_Principal : Form
    {
        public static frm_Principal instancia;

        public frm_Principal()
        {
            InitializeComponent();
            
            instancia = this;
            Forms_Controller.Start_Controller(pnl_Tela);
            Data_Controller.Start_Controller();
            FormClosing += on_Close;
        }

        #region botões_controle_janela
        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            bool sair = true;

            if (Data_Controller.tot_dow > 0 || Data_Controller.tot_up > 0)
            {
                var res = MessageBox.Show("Você tem trasferências\nem segundo plano.\n\nDeseja realmente sair?","Atenção:", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                sair = res == DialogResult.Yes;
            }

            if (sair) { Application.Exit(); }
        }
        private void on_Close(object sender, EventArgs e)
        {
            if (!Data_Controller.keep_login) { Data_Controller.Reset_Saved_Login(); }
            notfy_Principal.Visible = false;
            notfy_Principal.Dispose();
            notfy_Principal = null;
        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Normal ? FormWindowState.Minimized : FormWindowState.Normal;
        }
        private void Btn_MaxRes_Click(object sender, EventArgs e)
        {
            Forms_Controller.maximizado = !Forms_Controller.maximizado;
            if (Forms_Controller.maximizado)
            {
                Forms_Controller.screen_size = new Size(Screen.PrimaryScreen.Bounds.Width + 1, Screen.PrimaryScreen.WorkingArea.Size.Height + 1);
                elip_Tela.ElipseRadius = 0;
                Size = Forms_Controller.screen_size;
                Location = new Point();
            }
            else
            {
                Forms_Controller.screen_size = new Size(800, 450);
                elip_Tela.ElipseRadius = 20;
                Size = Forms_Controller.screen_size;
                Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - Width / 2, Screen.PrimaryScreen.Bounds.Height / 2 - Height / 2);
            }
            drag_Login.Activate = !Forms_Controller.maximizado;
            Forms_Controller.Redimensionar_Janelas();
        }
        #endregion

        private void frm_Principal_Load(object sender, EventArgs e)
        {
            Forms_Controller.Abrir(new frm_Login());
        }

        public void Transferences_Visible(bool visibility)
        {
            pnl_Transferências.Visible = visibility;
        }
        public void Update_Status_Upload(int concluido, int total)
        {
            lbl_Upload.Text = "⮝ " + concluido + " de " + total;
        }
        public void Update_Status_Download(int concluido, int total)
        {
            lbl_Download.Text = "⮟ " + concluido + " de " + total;
        }

        public void Show_Notify(string title, string text, ToolTipIcon icon)
        {
            notfy_Principal.ShowBalloonTip(10, title, text, icon);
        }

        public Panel Pnl_Transferences { get => pnl_Transferências; }
        public Label Lbl_Upload { get => lbl_Upload; }
        public Label Lbl_Download { get => lbl_Download; }
    }
}

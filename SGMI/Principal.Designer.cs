namespace SGMI
{
    partial class frm_Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Principal));
            this.pnl_Titulo = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btn_Fechar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.btn_MaxRes = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_Minimizar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pnl_Tela = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.drag_Login = new AdrielDev.DragControl();
            this.elip_Tela = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnl_Transferências = new System.Windows.Forms.Panel();
            this.lbl_Upload = new System.Windows.Forms.Label();
            this.lbl_Download = new System.Windows.Forms.Label();
            this.pnl_Titulo.SuspendLayout();
            this.pnl_Transferências.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Titulo
            // 
            this.pnl_Titulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_Titulo.BackgroundImage")));
            this.pnl_Titulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_Titulo.Controls.Add(this.pnl_Transferências);
            this.pnl_Titulo.Controls.Add(this.btn_Fechar);
            this.pnl_Titulo.Controls.Add(this.lbl_Titulo);
            this.pnl_Titulo.Controls.Add(this.btn_MaxRes);
            this.pnl_Titulo.Controls.Add(this.btn_Minimizar);
            this.pnl_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Titulo.GradientBottomLeft = System.Drawing.Color.Crimson;
            this.pnl_Titulo.GradientBottomRight = System.Drawing.Color.Maroon;
            this.pnl_Titulo.GradientTopLeft = System.Drawing.Color.Crimson;
            this.pnl_Titulo.GradientTopRight = System.Drawing.Color.Maroon;
            this.pnl_Titulo.Location = new System.Drawing.Point(0, 0);
            this.pnl_Titulo.Name = "pnl_Titulo";
            this.pnl_Titulo.Quality = 10;
            this.pnl_Titulo.Size = new System.Drawing.Size(800, 40);
            this.pnl_Titulo.TabIndex = 1;
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.ActiveBorderThickness = 1;
            this.btn_Fechar.ActiveCornerRadius = 1;
            this.btn_Fechar.ActiveFillColor = System.Drawing.Color.Crimson;
            this.btn_Fechar.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Fechar.ActiveLineColor = System.Drawing.Color.Crimson;
            this.btn_Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Fechar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Fechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Fechar.BackgroundImage")));
            this.btn_Fechar.ButtonText = "🗙";
            this.btn_Fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Fechar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fechar.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Fechar.IdleBorderThickness = 1;
            this.btn_Fechar.IdleCornerRadius = 1;
            this.btn_Fechar.IdleFillColor = System.Drawing.Color.White;
            this.btn_Fechar.IdleForecolor = System.Drawing.Color.Crimson;
            this.btn_Fechar.IdleLineColor = System.Drawing.Color.Crimson;
            this.btn_Fechar.Location = new System.Drawing.Point(756, 0);
            this.btn_Fechar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(40, 40);
            this.btn_Fechar.TabIndex = 2;
            this.btn_Fechar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Fechar.Click += new System.EventHandler(this.Btn_Fechar_Click);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Titulo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_Titulo.Location = new System.Drawing.Point(3, 8);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(383, 25);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "SysGI - Gerenciamento de Infratores";
            // 
            // btn_MaxRes
            // 
            this.btn_MaxRes.ActiveBorderThickness = 1;
            this.btn_MaxRes.ActiveCornerRadius = 1;
            this.btn_MaxRes.ActiveFillColor = System.Drawing.Color.Crimson;
            this.btn_MaxRes.ActiveForecolor = System.Drawing.Color.White;
            this.btn_MaxRes.ActiveLineColor = System.Drawing.Color.Crimson;
            this.btn_MaxRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_MaxRes.BackColor = System.Drawing.Color.Transparent;
            this.btn_MaxRes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_MaxRes.BackgroundImage")));
            this.btn_MaxRes.ButtonText = "🗖";
            this.btn_MaxRes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_MaxRes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MaxRes.ForeColor = System.Drawing.Color.Crimson;
            this.btn_MaxRes.IdleBorderThickness = 1;
            this.btn_MaxRes.IdleCornerRadius = 1;
            this.btn_MaxRes.IdleFillColor = System.Drawing.Color.White;
            this.btn_MaxRes.IdleForecolor = System.Drawing.Color.Crimson;
            this.btn_MaxRes.IdleLineColor = System.Drawing.Color.Crimson;
            this.btn_MaxRes.Location = new System.Drawing.Point(716, 0);
            this.btn_MaxRes.Margin = new System.Windows.Forms.Padding(5);
            this.btn_MaxRes.Name = "btn_MaxRes";
            this.btn_MaxRes.Size = new System.Drawing.Size(40, 40);
            this.btn_MaxRes.TabIndex = 1;
            this.btn_MaxRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_MaxRes.Click += new System.EventHandler(this.Btn_MaxRes_Click);
            // 
            // btn_Minimizar
            // 
            this.btn_Minimizar.ActiveBorderThickness = 1;
            this.btn_Minimizar.ActiveCornerRadius = 1;
            this.btn_Minimizar.ActiveFillColor = System.Drawing.Color.Crimson;
            this.btn_Minimizar.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Minimizar.ActiveLineColor = System.Drawing.Color.Crimson;
            this.btn_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimizar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Minimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Minimizar.BackgroundImage")));
            this.btn_Minimizar.ButtonText = "🗕";
            this.btn_Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Minimizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Minimizar.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Minimizar.IdleBorderThickness = 1;
            this.btn_Minimizar.IdleCornerRadius = 1;
            this.btn_Minimizar.IdleFillColor = System.Drawing.Color.White;
            this.btn_Minimizar.IdleForecolor = System.Drawing.Color.Crimson;
            this.btn_Minimizar.IdleLineColor = System.Drawing.Color.Crimson;
            this.btn_Minimizar.Location = new System.Drawing.Point(676, 0);
            this.btn_Minimizar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Minimizar.Name = "btn_Minimizar";
            this.btn_Minimizar.Size = new System.Drawing.Size(40, 40);
            this.btn_Minimizar.TabIndex = 0;
            this.btn_Minimizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Minimizar.Click += new System.EventHandler(this.Btn_Minimizar_Click);
            // 
            // pnl_Tela
            // 
            this.pnl_Tela.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_Tela.BackgroundImage")));
            this.pnl_Tela.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_Tela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Tela.GradientBottomLeft = System.Drawing.Color.Crimson;
            this.pnl_Tela.GradientBottomRight = System.Drawing.Color.Maroon;
            this.pnl_Tela.GradientTopLeft = System.Drawing.Color.Crimson;
            this.pnl_Tela.GradientTopRight = System.Drawing.Color.Maroon;
            this.pnl_Tela.Location = new System.Drawing.Point(0, 40);
            this.pnl_Tela.Name = "pnl_Tela";
            this.pnl_Tela.Quality = 10;
            this.pnl_Tela.Size = new System.Drawing.Size(800, 410);
            this.pnl_Tela.TabIndex = 2;
            // 
            // drag_Login
            // 
            this.drag_Login.Activate = true;
            this.drag_Login.Target = this.pnl_Titulo;
            // 
            // elip_Tela
            // 
            this.elip_Tela.ElipseRadius = 20;
            this.elip_Tela.TargetControl = this;
            // 
            // pnl_Transferências
            // 
            this.pnl_Transferências.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Transferências.Controls.Add(this.lbl_Download);
            this.pnl_Transferências.Controls.Add(this.lbl_Upload);
            this.pnl_Transferências.Location = new System.Drawing.Point(575, 4);
            this.pnl_Transferências.Name = "pnl_Transferências";
            this.pnl_Transferências.Size = new System.Drawing.Size(100, 30);
            this.pnl_Transferências.TabIndex = 3;
            this.pnl_Transferências.Visible = false;
            // 
            // lbl_Upload
            // 
            this.lbl_Upload.AutoEllipsis = true;
            this.lbl_Upload.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Upload.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Upload.Location = new System.Drawing.Point(0, 0);
            this.lbl_Upload.Name = "lbl_Upload";
            this.lbl_Upload.Size = new System.Drawing.Size(100, 15);
            this.lbl_Upload.TabIndex = 0;
            this.lbl_Upload.Text = "⮝ 0 de 0";
            this.lbl_Upload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Download
            // 
            this.lbl_Download.AutoEllipsis = true;
            this.lbl_Download.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_Download.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Download.Location = new System.Drawing.Point(0, 15);
            this.lbl_Download.Name = "lbl_Download";
            this.lbl_Download.Size = new System.Drawing.Size(100, 15);
            this.lbl_Download.TabIndex = 1;
            this.lbl_Download.Text = "⮟ 0 de 0";
            this.lbl_Download.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_Principal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_Tela);
            this.Controls.Add(this.pnl_Titulo);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SysGI";
            this.Load += new System.EventHandler(this.frm_Principal_Load);
            this.pnl_Titulo.ResumeLayout(false);
            this.pnl_Titulo.PerformLayout();
            this.pnl_Transferências.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel pnl_Titulo;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Fechar;
        private System.Windows.Forms.Label lbl_Titulo;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_MaxRes;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Minimizar;
        private Bunifu.Framework.UI.BunifuGradientPanel pnl_Tela;
        private AdrielDev.DragControl drag_Login;
        private Bunifu.Framework.UI.BunifuElipse elip_Tela;
        private System.Windows.Forms.Panel pnl_Transferências;
        private System.Windows.Forms.Label lbl_Download;
        private System.Windows.Forms.Label lbl_Upload;
    }
}
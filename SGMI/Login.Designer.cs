﻿namespace SGMI
{
    partial class frm_Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.drag_Login = new AdrielDev.DragControl();
            this.elip_Login = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnl_Tela = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.cb_KeepConnection = new LollipopCheckBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_Solicitar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_Pass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_Logar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_User = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lollipopLabel2 = new LollipopLabel();
            this.panelT1 = new AdrielDev.PanelT();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_Tela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // drag_Login
            // 
            this.drag_Login.Activate = true;
            this.drag_Login.Target = null;
            // 
            // elip_Login
            // 
            this.elip_Login.ElipseRadius = 0;
            this.elip_Login.TargetControl = this;
            // 
            // pnl_Tela
            // 
            this.pnl_Tela.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_Tela.BackgroundImage")));
            this.pnl_Tela.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_Tela.Controls.Add(this.cb_KeepConnection);
            this.pnl_Tela.Controls.Add(this.bunifuCustomLabel1);
            this.pnl_Tela.Controls.Add(this.btn_Solicitar);
            this.pnl_Tela.Controls.Add(this.txt_Pass);
            this.pnl_Tela.Controls.Add(this.btn_Logar);
            this.pnl_Tela.Controls.Add(this.txt_User);
            this.pnl_Tela.Controls.Add(this.lollipopLabel2);
            this.pnl_Tela.Controls.Add(this.panelT1);
            this.pnl_Tela.Controls.Add(this.pictureBox1);
            this.pnl_Tela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Tela.GradientBottomLeft = System.Drawing.Color.Crimson;
            this.pnl_Tela.GradientBottomRight = System.Drawing.Color.Maroon;
            this.pnl_Tela.GradientTopLeft = System.Drawing.Color.Crimson;
            this.pnl_Tela.GradientTopRight = System.Drawing.Color.Maroon;
            this.pnl_Tela.Location = new System.Drawing.Point(0, 0);
            this.pnl_Tela.Name = "pnl_Tela";
            this.pnl_Tela.Quality = 10;
            this.pnl_Tela.Size = new System.Drawing.Size(785, 370);
            this.pnl_Tela.TabIndex = 1;
            // 
            // cb_KeepConnection
            // 
            this.cb_KeepConnection.AutoSize = true;
            this.cb_KeepConnection.CheckColor = "#800000";
            this.cb_KeepConnection.Location = new System.Drawing.Point(255, 180);
            this.cb_KeepConnection.Name = "cb_KeepConnection";
            this.cb_KeepConnection.Size = new System.Drawing.Size(157, 20);
            this.cb_KeepConnection.TabIndex = 9;
            this.cb_KeepConnection.Text = "Manter-se Conectado";
            this.cb_KeepConnection.UseVisualStyleBackColor = true;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Maroon;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(235, 33);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(321, 36);
            this.bunifuCustomLabel1.TabIndex = 8;
            this.bunifuCustomLabel1.Text = "Login";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Solicitar
            // 
            this.btn_Solicitar.Active = false;
            this.btn_Solicitar.Activecolor = System.Drawing.Color.WhiteSmoke;
            this.btn_Solicitar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Solicitar.BackColor = System.Drawing.Color.White;
            this.btn_Solicitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Solicitar.BorderRadius = 0;
            this.btn_Solicitar.ButtonText = "Solicitar Login";
            this.btn_Solicitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Solicitar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Solicitar.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.btn_Solicitar.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Solicitar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Solicitar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Solicitar.Iconimage")));
            this.btn_Solicitar.Iconimage_right = null;
            this.btn_Solicitar.Iconimage_right_Selected = null;
            this.btn_Solicitar.Iconimage_Selected = null;
            this.btn_Solicitar.IconMarginLeft = 0;
            this.btn_Solicitar.IconMarginRight = 0;
            this.btn_Solicitar.IconRightVisible = false;
            this.btn_Solicitar.IconRightZoom = 0D;
            this.btn_Solicitar.IconVisible = false;
            this.btn_Solicitar.IconZoom = 100D;
            this.btn_Solicitar.IsTab = false;
            this.btn_Solicitar.Location = new System.Drawing.Point(255, 283);
            this.btn_Solicitar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Solicitar.Name = "btn_Solicitar";
            this.btn_Solicitar.Normalcolor = System.Drawing.Color.White;
            this.btn_Solicitar.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.btn_Solicitar.OnHoverTextColor = System.Drawing.Color.Maroon;
            this.btn_Solicitar.selected = false;
            this.btn_Solicitar.Size = new System.Drawing.Size(280, 32);
            this.btn_Solicitar.TabIndex = 5;
            this.btn_Solicitar.Text = "Solicitar Login";
            this.btn_Solicitar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Solicitar.Textcolor = System.Drawing.Color.Maroon;
            this.btn_Solicitar.TextFont = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.btn_Solicitar.Click += new System.EventHandler(this.Btn_Solicitar_Click);
            // 
            // txt_Pass
            // 
            this.txt_Pass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Pass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_Pass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_Pass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Pass.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Pass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Pass.ForeColor = System.Drawing.Color.Maroon;
            this.txt_Pass.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Pass.HintText = "Senha";
            this.txt_Pass.isPassword = true;
            this.txt_Pass.LineFocusedColor = System.Drawing.Color.Maroon;
            this.txt_Pass.LineIdleColor = System.Drawing.Color.Silver;
            this.txt_Pass.LineMouseHoverColor = System.Drawing.Color.IndianRed;
            this.txt_Pass.LineThickness = 3;
            this.txt_Pass.Location = new System.Drawing.Point(255, 132);
            this.txt_Pass.Margin = new System.Windows.Forms.Padding(0);
            this.txt_Pass.MaxLength = 50;
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Pass.Size = new System.Drawing.Size(280, 33);
            this.txt_Pass.TabIndex = 1;
            this.txt_Pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_Logar
            // 
            this.btn_Logar.Active = false;
            this.btn_Logar.Activecolor = System.Drawing.Color.DarkRed;
            this.btn_Logar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Logar.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Logar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Logar.BorderRadius = 0;
            this.btn_Logar.ButtonText = "LOGAR";
            this.btn_Logar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Logar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Logar.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Logar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Logar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Logar.Iconimage")));
            this.btn_Logar.Iconimage_right = null;
            this.btn_Logar.Iconimage_right_Selected = null;
            this.btn_Logar.Iconimage_Selected = null;
            this.btn_Logar.IconMarginLeft = 0;
            this.btn_Logar.IconMarginRight = 0;
            this.btn_Logar.IconRightVisible = false;
            this.btn_Logar.IconRightZoom = 0D;
            this.btn_Logar.IconVisible = false;
            this.btn_Logar.IconZoom = 100D;
            this.btn_Logar.IsTab = false;
            this.btn_Logar.Location = new System.Drawing.Point(255, 217);
            this.btn_Logar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Logar.Name = "btn_Logar";
            this.btn_Logar.Normalcolor = System.Drawing.Color.DarkRed;
            this.btn_Logar.OnHovercolor = System.Drawing.Color.Maroon;
            this.btn_Logar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Logar.selected = false;
            this.btn_Logar.Size = new System.Drawing.Size(280, 50);
            this.btn_Logar.TabIndex = 4;
            this.btn_Logar.Text = "LOGAR";
            this.btn_Logar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Logar.Textcolor = System.Drawing.Color.White;
            this.btn_Logar.TextFont = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn_Logar.Click += new System.EventHandler(this.Btn_Logar_Click);
            // 
            // txt_User
            // 
            this.txt_User.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_User.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_User.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_User.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_User.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_User.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_User.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_User.ForeColor = System.Drawing.Color.Maroon;
            this.txt_User.HintForeColor = System.Drawing.Color.Empty;
            this.txt_User.HintText = "Nome de Usuário";
            this.txt_User.isPassword = false;
            this.txt_User.LineFocusedColor = System.Drawing.Color.Maroon;
            this.txt_User.LineIdleColor = System.Drawing.Color.Silver;
            this.txt_User.LineMouseHoverColor = System.Drawing.Color.IndianRed;
            this.txt_User.LineThickness = 3;
            this.txt_User.Location = new System.Drawing.Point(255, 83);
            this.txt_User.Margin = new System.Windows.Forms.Padding(0);
            this.txt_User.MaxLength = 50;
            this.txt_User.Name = "txt_User";
            this.txt_User.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_User.Size = new System.Drawing.Size(280, 33);
            this.txt_User.TabIndex = 0;
            this.txt_User.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lollipopLabel2
            // 
            this.lollipopLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lollipopLabel2.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lollipopLabel2.ForeColor = System.Drawing.Color.White;
            this.lollipopLabel2.Location = new System.Drawing.Point(253, 344);
            this.lollipopLabel2.Name = "lollipopLabel2";
            this.lollipopLabel2.Size = new System.Drawing.Size(282, 17);
            this.lollipopLabel2.TabIndex = 5;
            this.lollipopLabel2.Text = "Todos os direitos reservados - UNIFENAS - 2019";
            this.lollipopLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelT1
            // 
            this.panelT1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelT1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelT1.Location = new System.Drawing.Point(234, 33);
            this.panelT1.Name = "panelT1";
            this.panelT1.Size = new System.Drawing.Size(322, 298);
            this.panelT1.TabIndex = 7;
            this.panelT1.Transparency = 75;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::SGMI.Properties.Resources.Banner;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(785, 322);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frm_Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(785, 370);
            this.Controls.Add(this.pnl_Tela);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SGMI";
            this.Load += new System.EventHandler(this.frm_Login_Load);
            this.pnl_Tela.ResumeLayout(false);
            this.pnl_Tela.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuGradientPanel pnl_Tela;
        private AdrielDev.DragControl drag_Login;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_User;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Pass;
        private Bunifu.Framework.UI.BunifuElipse elip_Login;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Solicitar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Logar;
        private LollipopLabel lollipopLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private AdrielDev.PanelT panelT1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private LollipopCheckBox cb_KeepConnection;
    }
}


namespace SGMI
{
    partial class frm_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Menu));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btn_Fechar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_Consultar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_Cadastrar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Bemvindo = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.lbl_Bemvindo);
            this.bunifuGradientPanel1.Controls.Add(this.btn_Fechar);
            this.bunifuGradientPanel1.Controls.Add(this.btn_Consultar);
            this.bunifuGradientPanel1.Controls.Add(this.btn_Cadastrar);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Crimson;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Maroon;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Crimson;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Maroon;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(800, 410);
            this.bunifuGradientPanel1.TabIndex = 0;
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
            this.btn_Fechar.ButtonText = "SAIR";
            this.btn_Fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Fechar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fechar.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Fechar.IdleBorderThickness = 1;
            this.btn_Fechar.IdleCornerRadius = 1;
            this.btn_Fechar.IdleFillColor = System.Drawing.Color.White;
            this.btn_Fechar.IdleForecolor = System.Drawing.Color.Crimson;
            this.btn_Fechar.IdleLineColor = System.Drawing.Color.Crimson;
            this.btn_Fechar.Location = new System.Drawing.Point(725, 15);
            this.btn_Fechar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(70, 40);
            this.btn_Fechar.TabIndex = 4;
            this.btn_Fechar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Fechar.Click += new System.EventHandler(this.Btn_Fechar_Click);
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.ActiveBorderThickness = 1;
            this.btn_Consultar.ActiveCornerRadius = 1;
            this.btn_Consultar.ActiveFillColor = System.Drawing.Color.Maroon;
            this.btn_Consultar.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Consultar.ActiveLineColor = System.Drawing.Color.Maroon;
            this.btn_Consultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Consultar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Consultar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Consultar.BackgroundImage")));
            this.btn_Consultar.ButtonText = "CONSULTAR";
            this.btn_Consultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Consultar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Consultar.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Consultar.IdleBorderThickness = 1;
            this.btn_Consultar.IdleCornerRadius = 1;
            this.btn_Consultar.IdleFillColor = System.Drawing.Color.White;
            this.btn_Consultar.IdleForecolor = System.Drawing.Color.Maroon;
            this.btn_Consultar.IdleLineColor = System.Drawing.Color.Maroon;
            this.btn_Consultar.Location = new System.Drawing.Point(441, 286);
            this.btn_Consultar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(130, 50);
            this.btn_Consultar.TabIndex = 3;
            this.btn_Consultar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Consultar.Click += new System.EventHandler(this.Btn_Consultar_Click);
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.ActiveBorderThickness = 1;
            this.btn_Cadastrar.ActiveCornerRadius = 1;
            this.btn_Cadastrar.ActiveFillColor = System.Drawing.Color.Maroon;
            this.btn_Cadastrar.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Cadastrar.ActiveLineColor = System.Drawing.Color.Maroon;
            this.btn_Cadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cadastrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cadastrar.BackgroundImage")));
            this.btn_Cadastrar.ButtonText = "CADASTRAR";
            this.btn_Cadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cadastrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cadastrar.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Cadastrar.IdleBorderThickness = 1;
            this.btn_Cadastrar.IdleCornerRadius = 1;
            this.btn_Cadastrar.IdleFillColor = System.Drawing.Color.White;
            this.btn_Cadastrar.IdleForecolor = System.Drawing.Color.Maroon;
            this.btn_Cadastrar.IdleLineColor = System.Drawing.Color.Maroon;
            this.btn_Cadastrar.Location = new System.Drawing.Point(223, 286);
            this.btn_Cadastrar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(130, 50);
            this.btn_Cadastrar.TabIndex = 2;
            this.btn_Cadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cadastrar.Click += new System.EventHandler(this.Btn_Cadastrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(209, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 339);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(331, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "INICIO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Bemvindo
            // 
            this.lbl_Bemvindo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Bemvindo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Bemvindo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bemvindo.ForeColor = System.Drawing.Color.White;
            this.lbl_Bemvindo.Location = new System.Drawing.Point(209, 42);
            this.lbl_Bemvindo.Name = "lbl_Bemvindo";
            this.lbl_Bemvindo.Size = new System.Drawing.Size(378, 23);
            this.lbl_Bemvindo.TabIndex = 5;
            this.lbl_Bemvindo.Text = "BEM-VINDO, USER!";
            this.lbl_Bemvindo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_Menu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 410);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Menu";
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Consultar;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Cadastrar;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Fechar;
        private System.Windows.Forms.Label lbl_Bemvindo;
    }
}
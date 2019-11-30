namespace SGMI
{
    partial class frmConsulta_Menor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsulta_Menor));
            this.txtRG = new AdrielDev.TextBoxRounded();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_Pesquisar = new System.Windows.Forms.PictureBox();
            this.elip_Pesquisa = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnl_InfosTop = new System.Windows.Forms.Panel();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.lbl_DataUltima = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.elip_Item = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnl_InfosBottom = new System.Windows.Forms.Panel();
            this.pic_Editar = new System.Windows.Forms.PictureBox();
            this.lbl_RG = new System.Windows.Forms.Label();
            this.lbl_CPF = new System.Windows.Forms.Label();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.elip_2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnl_InfInfra = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnl_Titulo = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Fechar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Pesquisar)).BeginInit();
            this.pnl_InfosTop.SuspendLayout();
            this.pnl_InfosBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Editar)).BeginInit();
            this.pnl_Titulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRG
            // 
            this.txtRG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRG.BorderColor = System.Drawing.Color.Empty;
            this.txtRG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRG.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRG.ForeColor = System.Drawing.Color.DarkRed;
            this.txtRG.LineHeight = 0;
            this.txtRG.Location = new System.Drawing.Point(50, 0);
            this.txtRG.MaxLength = 15;
            this.txtRG.Name = "txtRG";
            this.txtRG.Radius = 0;
            this.txtRG.Size = new System.Drawing.Size(299, 34);
            this.txtRG.TabIndex = 16;
            this.txtRG.TextChanged += new System.EventHandler(this.txtRG_TextChanged);
            this.txtRG.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRG_KeyDown);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkRed;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(60, 35);
            this.label3.TabIndex = 15;
            this.label3.Text = "RG";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.pic_Pesquisar);
            this.panel1.Controls.Add(this.txtRG);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 35);
            this.panel1.TabIndex = 17;
            // 
            // pic_Pesquisar
            // 
            this.pic_Pesquisar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pic_Pesquisar.BackColor = System.Drawing.Color.White;
            this.pic_Pesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Pesquisar.Image = global::SGMI.Properties.Resources.lupa__2_;
            this.pic_Pesquisar.Location = new System.Drawing.Point(308, 0);
            this.pic_Pesquisar.Name = "pic_Pesquisar";
            this.pic_Pesquisar.Size = new System.Drawing.Size(38, 34);
            this.pic_Pesquisar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Pesquisar.TabIndex = 17;
            this.pic_Pesquisar.TabStop = false;
            this.pic_Pesquisar.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // elip_Pesquisa
            // 
            this.elip_Pesquisa.ElipseRadius = 30;
            this.elip_Pesquisa.TargetControl = this.panel1;
            // 
            // pnl_InfosTop
            // 
            this.pnl_InfosTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_InfosTop.BackColor = System.Drawing.Color.Crimson;
            this.pnl_InfosTop.Controls.Add(this.lbl_Status);
            this.pnl_InfosTop.Controls.Add(this.lbl_DataUltima);
            this.pnl_InfosTop.Controls.Add(this.label2);
            this.pnl_InfosTop.Controls.Add(this.panel4);
            this.pnl_InfosTop.Controls.Add(this.label4);
            this.pnl_InfosTop.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_InfosTop.Location = new System.Drawing.Point(12, 106);
            this.pnl_InfosTop.Name = "pnl_InfosTop";
            this.pnl_InfosTop.Size = new System.Drawing.Size(349, 100);
            this.pnl_InfosTop.TabIndex = 18;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoEllipsis = true;
            this.lbl_Status.ForeColor = System.Drawing.Color.White;
            this.lbl_Status.Location = new System.Drawing.Point(180, 36);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(166, 21);
            this.lbl_Status.TabIndex = 3;
            this.lbl_Status.Text = "Indefinido";
            this.lbl_Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_DataUltima
            // 
            this.lbl_DataUltima.AutoEllipsis = true;
            this.lbl_DataUltima.ForeColor = System.Drawing.Color.White;
            this.lbl_DataUltima.Location = new System.Drawing.Point(5, 36);
            this.lbl_DataUltima.Name = "lbl_DataUltima";
            this.lbl_DataUltima.Size = new System.Drawing.Size(163, 21);
            this.lbl_DataUltima.TabIndex = 2;
            this.lbl_DataUltima.Text = "31/02/1000";
            this.lbl_DataUltima.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Última infração";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Location = new System.Drawing.Point(174, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 67);
            this.panel4.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(183, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Status";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // elip_Item
            // 
            this.elip_Item.ElipseRadius = 30;
            this.elip_Item.TargetControl = this.pnl_InfosTop;
            // 
            // pnl_InfosBottom
            // 
            this.pnl_InfosBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_InfosBottom.BackColor = System.Drawing.Color.Gainsboro;
            this.pnl_InfosBottom.Controls.Add(this.pic_Editar);
            this.pnl_InfosBottom.Controls.Add(this.lbl_RG);
            this.pnl_InfosBottom.Controls.Add(this.lbl_CPF);
            this.pnl_InfosBottom.Controls.Add(this.lbl_Nome);
            this.pnl_InfosBottom.Controls.Add(this.label7);
            this.pnl_InfosBottom.Controls.Add(this.label6);
            this.pnl_InfosBottom.Controls.Add(this.label5);
            this.pnl_InfosBottom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_InfosBottom.Location = new System.Drawing.Point(12, 170);
            this.pnl_InfosBottom.Name = "pnl_InfosBottom";
            this.pnl_InfosBottom.Size = new System.Drawing.Size(349, 100);
            this.pnl_InfosBottom.TabIndex = 19;
            // 
            // pic_Editar
            // 
            this.pic_Editar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pic_Editar.BackColor = System.Drawing.Color.Gainsboro;
            this.pic_Editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Editar.Image = global::SGMI.Properties.Resources.edit_icon;
            this.pic_Editar.Location = new System.Drawing.Point(276, 20);
            this.pic_Editar.Name = "pic_Editar";
            this.pic_Editar.Size = new System.Drawing.Size(60, 60);
            this.pic_Editar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Editar.TabIndex = 18;
            this.pic_Editar.TabStop = false;
            this.pic_Editar.Click += new System.EventHandler(this.pic_Editar_Click);
            // 
            // lbl_RG
            // 
            this.lbl_RG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_RG.AutoEllipsis = true;
            this.lbl_RG.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_RG.Location = new System.Drawing.Point(81, 67);
            this.lbl_RG.Name = "lbl_RG";
            this.lbl_RG.Size = new System.Drawing.Size(189, 21);
            this.lbl_RG.TabIndex = 8;
            this.lbl_RG.Text = "MG-1234567";
            // 
            // lbl_CPF
            // 
            this.lbl_CPF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_CPF.AutoEllipsis = true;
            this.lbl_CPF.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_CPF.Location = new System.Drawing.Point(81, 40);
            this.lbl_CPF.Name = "lbl_CPF";
            this.lbl_CPF.Size = new System.Drawing.Size(189, 21);
            this.lbl_CPF.TabIndex = 7;
            this.lbl_CPF.Text = "12345678910";
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Nome.AutoEllipsis = true;
            this.lbl_Nome.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_Nome.Location = new System.Drawing.Point(81, 13);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(189, 21);
            this.lbl_Nome.TabIndex = 4;
            this.lbl_Nome.Text = "Fulano de Tal";
            // 
            // label7
            // 
            this.label7.AutoEllipsis = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(5, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "RG:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(5, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "CPF:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(5, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nome:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // elip_2
            // 
            this.elip_2.ElipseRadius = 30;
            this.elip_2.TargetControl = this.pnl_InfosBottom;
            // 
            // pnl_InfInfra
            // 
            this.pnl_InfInfra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_InfInfra.AutoScroll = true;
            this.pnl_InfInfra.BackColor = System.Drawing.Color.Silver;
            this.pnl_InfInfra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_InfInfra.Location = new System.Drawing.Point(12, 286);
            this.pnl_InfInfra.Name = "pnl_InfInfra";
            this.pnl_InfInfra.Size = new System.Drawing.Size(349, 152);
            this.pnl_InfInfra.TabIndex = 21;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this.pnl_InfInfra;
            // 
            // pnl_Titulo
            // 
            this.pnl_Titulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_Titulo.BackgroundImage")));
            this.pnl_Titulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_Titulo.Controls.Add(this.label1);
            this.pnl_Titulo.Controls.Add(this.btn_Fechar);
            this.pnl_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Titulo.GradientBottomLeft = System.Drawing.Color.Crimson;
            this.pnl_Titulo.GradientBottomRight = System.Drawing.Color.Maroon;
            this.pnl_Titulo.GradientTopLeft = System.Drawing.Color.Crimson;
            this.pnl_Titulo.GradientTopRight = System.Drawing.Color.Maroon;
            this.pnl_Titulo.Location = new System.Drawing.Point(0, 0);
            this.pnl_Titulo.Name = "pnl_Titulo";
            this.pnl_Titulo.Quality = 10;
            this.pnl_Titulo.Size = new System.Drawing.Size(373, 72);
            this.pnl_Titulo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 55);
            this.label1.TabIndex = 18;
            this.label1.Text = "BUSCAR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btn_Fechar.ButtonText = "VOLTAR";
            this.btn_Fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Fechar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fechar.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Fechar.IdleBorderThickness = 1;
            this.btn_Fechar.IdleCornerRadius = 1;
            this.btn_Fechar.IdleFillColor = System.Drawing.Color.White;
            this.btn_Fechar.IdleForecolor = System.Drawing.Color.Crimson;
            this.btn_Fechar.IdleLineColor = System.Drawing.Color.Crimson;
            this.btn_Fechar.Location = new System.Drawing.Point(248, 9);
            this.btn_Fechar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Padding = new System.Windows.Forms.Padding(3, 0, 0, 2);
            this.btn_Fechar.Size = new System.Drawing.Size(113, 40);
            this.btn_Fechar.TabIndex = 17;
            this.btn_Fechar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Fechar.Click += new System.EventHandler(this.Btn_Fechar_Click);
            // 
            // frmConsulta_Menor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(373, 450);
            this.Controls.Add(this.pnl_InfInfra);
            this.Controls.Add(this.pnl_InfosBottom);
            this.Controls.Add(this.pnl_InfosTop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmConsulta_Menor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta_Menor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Pesquisar)).EndInit();
            this.pnl_InfosTop.ResumeLayout(false);
            this.pnl_InfosBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Editar)).EndInit();
            this.pnl_Titulo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel pnl_Titulo;
        private AdrielDev.TextBoxRounded txtRG;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Fechar;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse elip_Pesquisa;
        private System.Windows.Forms.Panel pnl_InfosTop;
        private Bunifu.Framework.UI.BunifuElipse elip_Item;
        private System.Windows.Forms.Panel pnl_InfosBottom;
        private Bunifu.Framework.UI.BunifuElipse elip_2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_DataUltima;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_RG;
        private System.Windows.Forms.Label lbl_CPF;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pic_Pesquisar;
        private System.Windows.Forms.Panel pnl_InfInfra;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pic_Editar;
    }
}
namespace SGMI
{
    partial class frm_SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_SignUp));
            this.pnl_Tela = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_UserName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox5 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox4 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox3 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_Salvar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_Pass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panelT1 = new AdrielDev.PanelT();
            this.pnl_Titulo = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btn_Fechar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pnl_Tela.SuspendLayout();
            this.pnl_Titulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Tela
            // 
            this.pnl_Tela.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_Tela.BackgroundImage")));
            this.pnl_Tela.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_Tela.Controls.Add(this.comboBox1);
            this.pnl_Tela.Controls.Add(this.txt_UserName);
            this.pnl_Tela.Controls.Add(this.bunifuMaterialTextbox5);
            this.pnl_Tela.Controls.Add(this.bunifuMaterialTextbox4);
            this.pnl_Tela.Controls.Add(this.bunifuMaterialTextbox3);
            this.pnl_Tela.Controls.Add(this.bunifuMaterialTextbox1);
            this.pnl_Tela.Controls.Add(this.bunifuCustomLabel1);
            this.pnl_Tela.Controls.Add(this.btn_Salvar);
            this.pnl_Tela.Controls.Add(this.txt_Pass);
            this.pnl_Tela.Controls.Add(this.panelT1);
            this.pnl_Tela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Tela.GradientBottomLeft = System.Drawing.Color.Crimson;
            this.pnl_Tela.GradientBottomRight = System.Drawing.Color.Maroon;
            this.pnl_Tela.GradientTopLeft = System.Drawing.Color.Crimson;
            this.pnl_Tela.GradientTopRight = System.Drawing.Color.Maroon;
            this.pnl_Tela.Location = new System.Drawing.Point(0, 40);
            this.pnl_Tela.Name = "pnl_Tela";
            this.pnl_Tela.Quality = 10;
            this.pnl_Tela.Size = new System.Drawing.Size(394, 370);
            this.pnl_Tela.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Categoria",
            "Professor",
            "Advogado",
            "Policial",
            "Juiz"});
            this.comboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.ForeColor = System.Drawing.Color.Maroon;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Categoria",
            "Professor",
            "Policial",
            "Advogado",
            "Juiz",
            "Promotor",
            "Delegado"});
            this.comboBox1.Location = new System.Drawing.Point(31, 86);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(337, 29);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Tag = "Categoria";
            // 
            // txt_UserName
            // 
            this.txt_UserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_UserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_UserName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_UserName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_UserName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_UserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_UserName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_UserName.ForeColor = System.Drawing.Color.Maroon;
            this.txt_UserName.HintForeColor = System.Drawing.Color.Empty;
            this.txt_UserName.HintText = "Nome de Usuário";
            this.txt_UserName.isPassword = false;
            this.txt_UserName.LineFocusedColor = System.Drawing.Color.Maroon;
            this.txt_UserName.LineIdleColor = System.Drawing.Color.Silver;
            this.txt_UserName.LineMouseHoverColor = System.Drawing.Color.IndianRed;
            this.txt_UserName.LineThickness = 3;
            this.txt_UserName.Location = new System.Drawing.Point(31, 50);
            this.txt_UserName.Margin = new System.Windows.Forms.Padding(0);
            this.txt_UserName.MaxLength = 50;
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_UserName.Size = new System.Drawing.Size(337, 33);
            this.txt_UserName.TabIndex = 1;
            this.txt_UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMaterialTextbox5
            // 
            this.bunifuMaterialTextbox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuMaterialTextbox5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextbox5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextbox5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuMaterialTextbox5.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMaterialTextbox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox5.ForeColor = System.Drawing.Color.Maroon;
            this.bunifuMaterialTextbox5.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox5.HintText = "email@confirma.com";
            this.bunifuMaterialTextbox5.isPassword = false;
            this.bunifuMaterialTextbox5.LineFocusedColor = System.Drawing.Color.Maroon;
            this.bunifuMaterialTextbox5.LineIdleColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextbox5.LineMouseHoverColor = System.Drawing.Color.IndianRed;
            this.bunifuMaterialTextbox5.LineThickness = 3;
            this.bunifuMaterialTextbox5.Location = new System.Drawing.Point(31, 191);
            this.bunifuMaterialTextbox5.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuMaterialTextbox5.MaxLength = 50;
            this.bunifuMaterialTextbox5.Name = "bunifuMaterialTextbox5";
            this.bunifuMaterialTextbox5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuMaterialTextbox5.Size = new System.Drawing.Size(337, 33);
            this.bunifuMaterialTextbox5.TabIndex = 5;
            this.bunifuMaterialTextbox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMaterialTextbox4
            // 
            this.bunifuMaterialTextbox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuMaterialTextbox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextbox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextbox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuMaterialTextbox4.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMaterialTextbox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox4.ForeColor = System.Drawing.Color.Maroon;
            this.bunifuMaterialTextbox4.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox4.HintText = "email@exemplo.com";
            this.bunifuMaterialTextbox4.isPassword = false;
            this.bunifuMaterialTextbox4.LineFocusedColor = System.Drawing.Color.Maroon;
            this.bunifuMaterialTextbox4.LineIdleColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextbox4.LineMouseHoverColor = System.Drawing.Color.IndianRed;
            this.bunifuMaterialTextbox4.LineThickness = 3;
            this.bunifuMaterialTextbox4.Location = new System.Drawing.Point(31, 155);
            this.bunifuMaterialTextbox4.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuMaterialTextbox4.MaxLength = 50;
            this.bunifuMaterialTextbox4.Name = "bunifuMaterialTextbox4";
            this.bunifuMaterialTextbox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuMaterialTextbox4.Size = new System.Drawing.Size(337, 33);
            this.bunifuMaterialTextbox4.TabIndex = 4;
            this.bunifuMaterialTextbox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMaterialTextbox3
            // 
            this.bunifuMaterialTextbox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuMaterialTextbox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextbox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextbox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuMaterialTextbox3.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMaterialTextbox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox3.ForeColor = System.Drawing.Color.Maroon;
            this.bunifuMaterialTextbox3.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox3.HintText = "Telefone";
            this.bunifuMaterialTextbox3.isPassword = false;
            this.bunifuMaterialTextbox3.LineFocusedColor = System.Drawing.Color.Maroon;
            this.bunifuMaterialTextbox3.LineIdleColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextbox3.LineMouseHoverColor = System.Drawing.Color.IndianRed;
            this.bunifuMaterialTextbox3.LineThickness = 3;
            this.bunifuMaterialTextbox3.Location = new System.Drawing.Point(31, 119);
            this.bunifuMaterialTextbox3.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuMaterialTextbox3.MaxLength = 50;
            this.bunifuMaterialTextbox3.Name = "bunifuMaterialTextbox3";
            this.bunifuMaterialTextbox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuMaterialTextbox3.Size = new System.Drawing.Size(337, 33);
            this.bunifuMaterialTextbox3.TabIndex = 3;
            this.bunifuMaterialTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuMaterialTextbox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextbox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextbox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuMaterialTextbox1.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.Maroon;
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "Senha";
            this.bunifuMaterialTextbox1.isPassword = true;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Maroon;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.IndianRed;
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(31, 227);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuMaterialTextbox1.MaxLength = 50;
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(337, 33);
            this.bunifuMaterialTextbox1.TabIndex = 6;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Maroon;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 5);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(374, 36);
            this.bunifuCustomLabel1.TabIndex = 8;
            this.bunifuCustomLabel1.Text = "Cadastro";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Active = false;
            this.btn_Salvar.Activecolor = System.Drawing.Color.DarkRed;
            this.btn_Salvar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Salvar.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Salvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Salvar.BorderRadius = 0;
            this.btn_Salvar.ButtonText = "ENVIAR";
            this.btn_Salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salvar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Salvar.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salvar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Salvar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Salvar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Salvar.Iconimage")));
            this.btn_Salvar.Iconimage_right = null;
            this.btn_Salvar.Iconimage_right_Selected = null;
            this.btn_Salvar.Iconimage_Selected = null;
            this.btn_Salvar.IconMarginLeft = 0;
            this.btn_Salvar.IconMarginRight = 0;
            this.btn_Salvar.IconRightVisible = false;
            this.btn_Salvar.IconRightZoom = 0D;
            this.btn_Salvar.IconVisible = false;
            this.btn_Salvar.IconZoom = 100D;
            this.btn_Salvar.IsTab = false;
            this.btn_Salvar.Location = new System.Drawing.Point(31, 302);
            this.btn_Salvar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Normalcolor = System.Drawing.Color.DarkRed;
            this.btn_Salvar.OnHovercolor = System.Drawing.Color.Maroon;
            this.btn_Salvar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Salvar.selected = false;
            this.btn_Salvar.Size = new System.Drawing.Size(337, 50);
            this.btn_Salvar.TabIndex = 8;
            this.btn_Salvar.Text = "ENVIAR";
            this.btn_Salvar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Salvar.Textcolor = System.Drawing.Color.White;
            this.btn_Salvar.TextFont = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
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
            this.txt_Pass.HintText = "Confirmar";
            this.txt_Pass.isPassword = true;
            this.txt_Pass.LineFocusedColor = System.Drawing.Color.Maroon;
            this.txt_Pass.LineIdleColor = System.Drawing.Color.Silver;
            this.txt_Pass.LineMouseHoverColor = System.Drawing.Color.IndianRed;
            this.txt_Pass.LineThickness = 3;
            this.txt_Pass.Location = new System.Drawing.Point(31, 263);
            this.txt_Pass.Margin = new System.Windows.Forms.Padding(0);
            this.txt_Pass.MaxLength = 50;
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Pass.Size = new System.Drawing.Size(337, 33);
            this.txt_Pass.TabIndex = 7;
            this.txt_Pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panelT1
            // 
            this.panelT1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelT1.Location = new System.Drawing.Point(11, 18);
            this.panelT1.Name = "panelT1";
            this.panelT1.Size = new System.Drawing.Size(375, 340);
            this.panelT1.TabIndex = 7;
            this.panelT1.Transparency = 75;
            // 
            // pnl_Titulo
            // 
            this.pnl_Titulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_Titulo.BackgroundImage")));
            this.pnl_Titulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_Titulo.Controls.Add(this.btn_Fechar);
            this.pnl_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Titulo.GradientBottomLeft = System.Drawing.Color.Crimson;
            this.pnl_Titulo.GradientBottomRight = System.Drawing.Color.Maroon;
            this.pnl_Titulo.GradientTopLeft = System.Drawing.Color.Crimson;
            this.pnl_Titulo.GradientTopRight = System.Drawing.Color.Maroon;
            this.pnl_Titulo.Location = new System.Drawing.Point(0, 0);
            this.pnl_Titulo.Name = "pnl_Titulo";
            this.pnl_Titulo.Quality = 10;
            this.pnl_Titulo.Size = new System.Drawing.Size(394, 40);
            this.pnl_Titulo.TabIndex = 2;
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
            this.btn_Fechar.Location = new System.Drawing.Point(291, 0);
            this.btn_Fechar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Padding = new System.Windows.Forms.Padding(3, 0, 0, 2);
            this.btn_Fechar.Size = new System.Drawing.Size(95, 40);
            this.btn_Fechar.TabIndex = 9;
            this.btn_Fechar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Fechar.Click += new System.EventHandler(this.Btn_Fechar_Click);
            // 
            // frm_SignUp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(394, 410);
            this.Controls.Add(this.pnl_Tela);
            this.Controls.Add(this.pnl_Titulo);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.Frm_SignUp_Load);
            this.pnl_Tela.ResumeLayout(false);
            this.pnl_Titulo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel pnl_Tela;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Salvar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Pass;
        private AdrielDev.PanelT panelT1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Fechar;
        private Bunifu.Framework.UI.BunifuGradientPanel pnl_Titulo;
        private System.Windows.Forms.ComboBox comboBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_UserName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
    }
}
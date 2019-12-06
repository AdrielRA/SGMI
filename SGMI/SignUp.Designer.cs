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
            this.cmb_Credencial = new System.Windows.Forms.ComboBox();
            this.txt_UserName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_ConfirmaEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_Email = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_Telefone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_Senha = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_Salvar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_ConformaSenha = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pnl_BG = new AdrielDev.PanelT();
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
            this.pnl_Tela.Controls.Add(this.cmb_Credencial);
            this.pnl_Tela.Controls.Add(this.txt_UserName);
            this.pnl_Tela.Controls.Add(this.txt_ConfirmaEmail);
            this.pnl_Tela.Controls.Add(this.txt_Email);
            this.pnl_Tela.Controls.Add(this.txt_Telefone);
            this.pnl_Tela.Controls.Add(this.txt_Senha);
            this.pnl_Tela.Controls.Add(this.bunifuCustomLabel1);
            this.pnl_Tela.Controls.Add(this.btn_Salvar);
            this.pnl_Tela.Controls.Add(this.txt_ConformaSenha);
            this.pnl_Tela.Controls.Add(this.pnl_BG);
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
            // cmb_Credencial
            // 
            this.cmb_Credencial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Credencial.AutoCompleteCustomSource.AddRange(new string[] {
            "Categoria",
            "Professor",
            "Advogado",
            "Policial",
            "Juiz"});
            this.cmb_Credencial.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmb_Credencial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_Credencial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Credencial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_Credencial.ForeColor = System.Drawing.Color.Maroon;
            this.cmb_Credencial.FormattingEnabled = true;
            this.cmb_Credencial.Location = new System.Drawing.Point(31, 86);
            this.cmb_Credencial.Name = "cmb_Credencial";
            this.cmb_Credencial.Size = new System.Drawing.Size(337, 29);
            this.cmb_Credencial.TabIndex = 2;
            this.cmb_Credencial.Tag = "Categoria";
            this.cmb_Credencial.SelectedIndexChanged += new System.EventHandler(this.cmb_Credential_Changed);
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
            this.txt_UserName.OnValueChanged += new System.EventHandler(this.txt_Nome_Changed);
            // 
            // txt_ConfirmaEmail
            // 
            this.txt_ConfirmaEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ConfirmaEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_ConfirmaEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_ConfirmaEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_ConfirmaEmail.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_ConfirmaEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ConfirmaEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_ConfirmaEmail.ForeColor = System.Drawing.Color.Maroon;
            this.txt_ConfirmaEmail.HintForeColor = System.Drawing.Color.Empty;
            this.txt_ConfirmaEmail.HintText = "email@confirma.com";
            this.txt_ConfirmaEmail.isPassword = false;
            this.txt_ConfirmaEmail.LineFocusedColor = System.Drawing.Color.Maroon;
            this.txt_ConfirmaEmail.LineIdleColor = System.Drawing.Color.Silver;
            this.txt_ConfirmaEmail.LineMouseHoverColor = System.Drawing.Color.IndianRed;
            this.txt_ConfirmaEmail.LineThickness = 3;
            this.txt_ConfirmaEmail.Location = new System.Drawing.Point(31, 191);
            this.txt_ConfirmaEmail.Margin = new System.Windows.Forms.Padding(0);
            this.txt_ConfirmaEmail.MaxLength = 50;
            this.txt_ConfirmaEmail.Name = "txt_ConfirmaEmail";
            this.txt_ConfirmaEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_ConfirmaEmail.Size = new System.Drawing.Size(337, 33);
            this.txt_ConfirmaEmail.TabIndex = 5;
            this.txt_ConfirmaEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_ConfirmaEmail.OnValueChanged += new System.EventHandler(this.txt_Email_Changed);
            // 
            // txt_Email
            // 
            this.txt_Email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Email.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_Email.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_Email.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Email.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Email.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Email.ForeColor = System.Drawing.Color.Maroon;
            this.txt_Email.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Email.HintText = "email@exemplo.com";
            this.txt_Email.isPassword = false;
            this.txt_Email.LineFocusedColor = System.Drawing.Color.Maroon;
            this.txt_Email.LineIdleColor = System.Drawing.Color.Silver;
            this.txt_Email.LineMouseHoverColor = System.Drawing.Color.IndianRed;
            this.txt_Email.LineThickness = 3;
            this.txt_Email.Location = new System.Drawing.Point(31, 155);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(0);
            this.txt_Email.MaxLength = 50;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Email.Size = new System.Drawing.Size(337, 33);
            this.txt_Email.TabIndex = 4;
            this.txt_Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Email.OnValueChanged += new System.EventHandler(this.txt_Email_Changed);
            // 
            // txt_Telefone
            // 
            this.txt_Telefone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Telefone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_Telefone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_Telefone.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Telefone.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Telefone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Telefone.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Telefone.ForeColor = System.Drawing.Color.Maroon;
            this.txt_Telefone.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Telefone.HintText = "Telefone";
            this.txt_Telefone.isPassword = false;
            this.txt_Telefone.LineFocusedColor = System.Drawing.Color.Maroon;
            this.txt_Telefone.LineIdleColor = System.Drawing.Color.Silver;
            this.txt_Telefone.LineMouseHoverColor = System.Drawing.Color.IndianRed;
            this.txt_Telefone.LineThickness = 3;
            this.txt_Telefone.Location = new System.Drawing.Point(31, 119);
            this.txt_Telefone.Margin = new System.Windows.Forms.Padding(0);
            this.txt_Telefone.MaxLength = 16;
            this.txt_Telefone.Name = "txt_Telefone";
            this.txt_Telefone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Telefone.Size = new System.Drawing.Size(337, 33);
            this.txt_Telefone.TabIndex = 3;
            this.txt_Telefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Telefone.OnValueChanged += new System.EventHandler(this.txt_Telefone_OnValueChanged);
            this.txt_Telefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Telefone_KeyPress);
            // 
            // txt_Senha
            // 
            this.txt_Senha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Senha.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_Senha.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_Senha.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Senha.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Senha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Senha.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Senha.ForeColor = System.Drawing.Color.Maroon;
            this.txt_Senha.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Senha.HintText = "Senha";
            this.txt_Senha.isPassword = true;
            this.txt_Senha.LineFocusedColor = System.Drawing.Color.Maroon;
            this.txt_Senha.LineIdleColor = System.Drawing.Color.Silver;
            this.txt_Senha.LineMouseHoverColor = System.Drawing.Color.IndianRed;
            this.txt_Senha.LineThickness = 3;
            this.txt_Senha.Location = new System.Drawing.Point(31, 227);
            this.txt_Senha.Margin = new System.Windows.Forms.Padding(0);
            this.txt_Senha.MaxLength = 50;
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Senha.Size = new System.Drawing.Size(337, 33);
            this.txt_Senha.TabIndex = 6;
            this.txt_Senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Senha.OnValueChanged += new System.EventHandler(this.txt_Senha_Changed);
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
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // txt_ConformaSenha
            // 
            this.txt_ConformaSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ConformaSenha.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_ConformaSenha.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_ConformaSenha.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_ConformaSenha.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_ConformaSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ConformaSenha.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_ConformaSenha.ForeColor = System.Drawing.Color.Maroon;
            this.txt_ConformaSenha.HintForeColor = System.Drawing.Color.Empty;
            this.txt_ConformaSenha.HintText = "Confirmar";
            this.txt_ConformaSenha.isPassword = true;
            this.txt_ConformaSenha.LineFocusedColor = System.Drawing.Color.Maroon;
            this.txt_ConformaSenha.LineIdleColor = System.Drawing.Color.Silver;
            this.txt_ConformaSenha.LineMouseHoverColor = System.Drawing.Color.IndianRed;
            this.txt_ConformaSenha.LineThickness = 3;
            this.txt_ConformaSenha.Location = new System.Drawing.Point(31, 263);
            this.txt_ConformaSenha.Margin = new System.Windows.Forms.Padding(0);
            this.txt_ConformaSenha.MaxLength = 50;
            this.txt_ConformaSenha.Name = "txt_ConformaSenha";
            this.txt_ConformaSenha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_ConformaSenha.Size = new System.Drawing.Size(337, 33);
            this.txt_ConformaSenha.TabIndex = 7;
            this.txt_ConformaSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_ConformaSenha.OnValueChanged += new System.EventHandler(this.txt_Senha_Changed);
            // 
            // pnl_BG
            // 
            this.pnl_BG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_BG.Location = new System.Drawing.Point(11, 18);
            this.pnl_BG.Name = "pnl_BG";
            this.pnl_BG.Size = new System.Drawing.Size(375, 340);
            this.pnl_BG.TabIndex = 7;
            this.pnl_BG.Transparency = 75;
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
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_ConformaSenha;
        private AdrielDev.PanelT pnl_BG;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Fechar;
        private Bunifu.Framework.UI.BunifuGradientPanel pnl_Titulo;
        private System.Windows.Forms.ComboBox cmb_Credencial;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_UserName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_ConfirmaEmail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Email;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Telefone;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Senha;
    }
}
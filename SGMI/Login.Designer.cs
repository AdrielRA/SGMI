namespace SGMI
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
            this.pnl_Titulo = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btn_Fechar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.btn_MaxRes = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_Minimizar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pnl_Tela = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lollipopLabel2 = new LollipopLabel();
            this.btn_Solicitar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Logar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_User = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_Pass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cb_Keep = new LollipopCheckBox();
            this.drag_Login = new AdrielDev.DragControl();
            this.elip_Tela = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elip_Login = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelT1 = new AdrielDev.PanelT();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnl_Titulo.SuspendLayout();
            this.pnl_Tela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Titulo
            // 
            this.pnl_Titulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_Titulo.BackgroundImage")));
            this.pnl_Titulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.pnl_Titulo.TabIndex = 0;
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
            this.lbl_Titulo.Location = new System.Drawing.Point(3, 8);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(365, 25);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "SGMI - Gerencia de Menor Infrator";
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
            this.pnl_Tela.Controls.Add(this.bunifuCustomLabel1);
            this.pnl_Tela.Controls.Add(this.btn_Solicitar);
            this.pnl_Tela.Controls.Add(this.btn_Logar);
            this.pnl_Tela.Controls.Add(this.txt_User);
            this.pnl_Tela.Controls.Add(this.txt_Pass);
            this.pnl_Tela.Controls.Add(this.cb_Keep);
            this.pnl_Tela.Controls.Add(this.panelT1);
            this.pnl_Tela.Controls.Add(this.pictureBox1);
            this.pnl_Tela.Controls.Add(this.lollipopLabel2);
            this.pnl_Tela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Tela.GradientBottomLeft = System.Drawing.Color.Crimson;
            this.pnl_Tela.GradientBottomRight = System.Drawing.Color.Maroon;
            this.pnl_Tela.GradientTopLeft = System.Drawing.Color.Crimson;
            this.pnl_Tela.GradientTopRight = System.Drawing.Color.Maroon;
            this.pnl_Tela.Location = new System.Drawing.Point(0, 40);
            this.pnl_Tela.Name = "pnl_Tela";
            this.pnl_Tela.Quality = 10;
            this.pnl_Tela.Size = new System.Drawing.Size(800, 411);
            this.pnl_Tela.TabIndex = 1;
            // 
            // lollipopLabel2
            // 
            this.lollipopLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lollipopLabel2.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lollipopLabel2.ForeColor = System.Drawing.Color.White;
            this.lollipopLabel2.Location = new System.Drawing.Point(252, 374);
            this.lollipopLabel2.Name = "lollipopLabel2";
            this.lollipopLabel2.Size = new System.Drawing.Size(297, 17);
            this.lollipopLabel2.TabIndex = 5;
            this.lollipopLabel2.Text = "Todos os direitos reservados - UNIFENAS - 2019";
            this.lollipopLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btn_Solicitar.Location = new System.Drawing.Point(253, 295);
            this.btn_Solicitar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Solicitar.Name = "btn_Solicitar";
            this.btn_Solicitar.Normalcolor = System.Drawing.Color.White;
            this.btn_Solicitar.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.btn_Solicitar.OnHoverTextColor = System.Drawing.Color.Maroon;
            this.btn_Solicitar.selected = false;
            this.btn_Solicitar.Size = new System.Drawing.Size(295, 32);
            this.btn_Solicitar.TabIndex = 5;
            this.btn_Solicitar.Text = "Solicitar Login";
            this.btn_Solicitar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Solicitar.Textcolor = System.Drawing.Color.Maroon;
            this.btn_Solicitar.TextFont = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.btn_Solicitar.Click += new System.EventHandler(this.Btn_Solicitar_Click);
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
            this.btn_Logar.Location = new System.Drawing.Point(253, 229);
            this.btn_Logar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Logar.Name = "btn_Logar";
            this.btn_Logar.Normalcolor = System.Drawing.Color.DarkRed;
            this.btn_Logar.OnHovercolor = System.Drawing.Color.Maroon;
            this.btn_Logar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Logar.selected = false;
            this.btn_Logar.Size = new System.Drawing.Size(295, 50);
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
            this.txt_User.Location = new System.Drawing.Point(253, 95);
            this.txt_User.Margin = new System.Windows.Forms.Padding(0);
            this.txt_User.MaxLength = 50;
            this.txt_User.Name = "txt_User";
            this.txt_User.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_User.Size = new System.Drawing.Size(295, 33);
            this.txt_User.TabIndex = 0;
            this.txt_User.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.txt_Pass.Location = new System.Drawing.Point(253, 144);
            this.txt_Pass.Margin = new System.Windows.Forms.Padding(0);
            this.txt_Pass.MaxLength = 50;
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Pass.Size = new System.Drawing.Size(295, 33);
            this.txt_Pass.TabIndex = 1;
            this.txt_Pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cb_Keep
            // 
            this.cb_Keep.AutoSize = true;
            this.cb_Keep.BackColor = System.Drawing.Color.Maroon;
            this.cb_Keep.CheckColor = "#800000";
            this.cb_Keep.Location = new System.Drawing.Point(255, 193);
            this.cb_Keep.Margin = new System.Windows.Forms.Padding(0);
            this.cb_Keep.Name = "cb_Keep";
            this.cb_Keep.Size = new System.Drawing.Size(157, 20);
            this.cb_Keep.TabIndex = 2;
            this.cb_Keep.Text = "Manter-se Conectado";
            this.cb_Keep.UseVisualStyleBackColor = false;
            // 
            // drag_Login
            // 
            this.drag_Login.Activate = true;
            this.drag_Login.Target = this.pnl_Titulo;
            // 
            // elip_Tela
            // 
            this.elip_Tela.ElipseRadius = 10;
            this.elip_Tela.TargetControl = this;
            // 
            // elip_Login
            // 
            this.elip_Login.ElipseRadius = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SGMI.Properties.Resources.Banner;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 328);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panelT1
            // 
            this.panelT1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelT1.Location = new System.Drawing.Point(232, 45);
            this.panelT1.Name = "panelT1";
            this.panelT1.Size = new System.Drawing.Size(337, 305);
            this.panelT1.TabIndex = 7;
            this.panelT1.Transparency = 75;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Maroon;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(233, 45);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(336, 36);
            this.bunifuCustomLabel1.TabIndex = 8;
            this.bunifuCustomLabel1.Text = "Login";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.pnl_Tela);
            this.Controls.Add(this.pnl_Titulo);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SGMI";
            this.pnl_Titulo.ResumeLayout(false);
            this.pnl_Titulo.PerformLayout();
            this.pnl_Tela.ResumeLayout(false);
            this.pnl_Tela.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel pnl_Titulo;
        private System.Windows.Forms.Label lbl_Titulo;
        private Bunifu.Framework.UI.BunifuGradientPanel pnl_Tela;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Fechar;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_MaxRes;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Minimizar;
        private AdrielDev.DragControl drag_Login;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_User;
        private Bunifu.Framework.UI.BunifuElipse elip_Tela;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Pass;
        private LollipopCheckBox cb_Keep;
        private Bunifu.Framework.UI.BunifuElipse elip_Login;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Solicitar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Logar;
        private LollipopLabel lollipopLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private AdrielDev.PanelT panelT1;
    }
}


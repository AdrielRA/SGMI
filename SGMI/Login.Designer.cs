namespace SGMI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pnl_Titulo = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pnl_Login = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.btn_Minimizar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_MaxRes = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_Fechar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.drag_Login = new AdrielDev.DragControl();
            this.pnl_Titulo.SuspendLayout();
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
            // pnl_Login
            // 
            this.pnl_Login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_Login.BackgroundImage")));
            this.pnl_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_Login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Login.GradientBottomLeft = System.Drawing.Color.Crimson;
            this.pnl_Login.GradientBottomRight = System.Drawing.Color.Maroon;
            this.pnl_Login.GradientTopLeft = System.Drawing.Color.Crimson;
            this.pnl_Login.GradientTopRight = System.Drawing.Color.Maroon;
            this.pnl_Login.Location = new System.Drawing.Point(0, 40);
            this.pnl_Login.Name = "pnl_Login";
            this.pnl_Login.Quality = 10;
            this.pnl_Login.Size = new System.Drawing.Size(800, 410);
            this.pnl_Login.TabIndex = 1;
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
            // btn_Minimizar
            // 
            this.btn_Minimizar.ActiveBorderThickness = 1;
            this.btn_Minimizar.ActiveCornerRadius = 1;
            this.btn_Minimizar.ActiveFillColor = System.Drawing.Color.Crimson;
            this.btn_Minimizar.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Minimizar.ActiveLineColor = System.Drawing.Color.Crimson;
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
            // btn_MaxRes
            // 
            this.btn_MaxRes.ActiveBorderThickness = 1;
            this.btn_MaxRes.ActiveCornerRadius = 1;
            this.btn_MaxRes.ActiveFillColor = System.Drawing.Color.Crimson;
            this.btn_MaxRes.ActiveForecolor = System.Drawing.Color.White;
            this.btn_MaxRes.ActiveLineColor = System.Drawing.Color.Crimson;
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
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.ActiveBorderThickness = 1;
            this.btn_Fechar.ActiveCornerRadius = 1;
            this.btn_Fechar.ActiveFillColor = System.Drawing.Color.Crimson;
            this.btn_Fechar.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Fechar.ActiveLineColor = System.Drawing.Color.Crimson;
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
            // drag_Login
            // 
            this.drag_Login.Activate = true;
            this.drag_Login.Target = this.pnl_Titulo;
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_Login);
            this.Controls.Add(this.pnl_Titulo);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SGMI";
            this.pnl_Titulo.ResumeLayout(false);
            this.pnl_Titulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel pnl_Titulo;
        private System.Windows.Forms.Label lbl_Titulo;
        private Bunifu.Framework.UI.BunifuGradientPanel pnl_Login;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Fechar;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_MaxRes;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Minimizar;
        private AdrielDev.DragControl drag_Login;
    }
}


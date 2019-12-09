namespace SGMI
{
    partial class frm_Anexo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Anexo));
            this.elip_Form = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnl_BG = new System.Windows.Forms.Panel();
            this.lbl_Titulo = new LollipopLabel();
            this.elip_BG = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Fechar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pnl_BG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // elip_Form
            // 
            this.elip_Form.ElipseRadius = 10;
            this.elip_Form.TargetControl = this;
            // 
            // pnl_BG
            // 
            this.pnl_BG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnl_BG.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_BG.Controls.Add(this.pictureBox1);
            this.pnl_BG.Controls.Add(this.btn_Fechar);
            this.pnl_BG.Controls.Add(this.lbl_Titulo);
            this.pnl_BG.Location = new System.Drawing.Point(1, 1);
            this.pnl_BG.Name = "pnl_BG";
            this.pnl_BG.Size = new System.Drawing.Size(498, 58);
            this.pnl_BG.TabIndex = 0;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoEllipsis = true;
            this.lbl_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Titulo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Titulo.Location = new System.Drawing.Point(72, 2);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(328, 52);
            this.lbl_Titulo.TabIndex = 7;
            this.lbl_Titulo.Text = "Anexando arquivo...";
            this.lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // elip_BG
            // 
            this.elip_BG.ElipseRadius = 10;
            this.elip_BG.TargetControl = this.pnl_BG;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SGMI.Properties.Resources.gif_load;
            this.pictureBox1.Location = new System.Drawing.Point(23, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.ActiveBorderThickness = 1;
            this.btn_Fechar.ActiveCornerRadius = 1;
            this.btn_Fechar.ActiveFillColor = System.Drawing.Color.Crimson;
            this.btn_Fechar.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Fechar.ActiveLineColor = System.Drawing.Color.Crimson;
            this.btn_Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Fechar.BackColor = System.Drawing.Color.WhiteSmoke;
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
            this.btn_Fechar.Location = new System.Drawing.Point(464, 10);
            this.btn_Fechar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Padding = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.btn_Fechar.Size = new System.Drawing.Size(29, 38);
            this.btn_Fechar.TabIndex = 8;
            this.btn_Fechar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // frm_Anexo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(500, 60);
            this.Controls.Add(this.pnl_BG);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Anexo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_Anexo";
            this.pnl_BG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse elip_Form;
        private System.Windows.Forms.Panel pnl_BG;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Fechar;
        private LollipopLabel lbl_Titulo;
        private Bunifu.Framework.UI.BunifuElipse elip_BG;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
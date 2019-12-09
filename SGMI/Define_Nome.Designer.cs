namespace SGMI
{
    partial class frm_Define_Nome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Define_Nome));
            this.pnl_BG = new System.Windows.Forms.Panel();
            this.lbl_Titulo = new LollipopLabel();
            this.elip_Form = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elip_BG = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txt_Nome = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_OK = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnl_BG.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_BG
            // 
            this.pnl_BG.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_BG.Controls.Add(this.btn_OK);
            this.pnl_BG.Controls.Add(this.txt_Nome);
            this.pnl_BG.Controls.Add(this.lbl_Titulo);
            this.pnl_BG.Location = new System.Drawing.Point(1, 1);
            this.pnl_BG.Name = "pnl_BG";
            this.pnl_BG.Size = new System.Drawing.Size(348, 78);
            this.pnl_BG.TabIndex = 1;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoEllipsis = true;
            this.lbl_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Titulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Titulo.Location = new System.Drawing.Point(11, 5);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(295, 36);
            this.lbl_Titulo.TabIndex = 7;
            this.lbl_Titulo.Text = "Defina um nome:";
            this.lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // elip_Form
            // 
            this.elip_Form.ElipseRadius = 10;
            this.elip_Form.TargetControl = this;
            // 
            // elip_BG
            // 
            this.elip_BG.ElipseRadius = 10;
            this.elip_BG.TargetControl = this.pnl_BG;
            // 
            // txt_Nome
            // 
            this.txt_Nome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Nome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_Nome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_Nome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Nome.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Nome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Nome.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Nome.ForeColor = System.Drawing.Color.Maroon;
            this.txt_Nome.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Nome.HintText = "Nome do Arquivo";
            this.txt_Nome.isPassword = false;
            this.txt_Nome.LineFocusedColor = System.Drawing.Color.Maroon;
            this.txt_Nome.LineIdleColor = System.Drawing.Color.Silver;
            this.txt_Nome.LineMouseHoverColor = System.Drawing.Color.IndianRed;
            this.txt_Nome.LineThickness = 3;
            this.txt_Nome.Location = new System.Drawing.Point(15, 38);
            this.txt_Nome.Margin = new System.Windows.Forms.Padding(0);
            this.txt_Nome.MaxLength = 50;
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Nome.Size = new System.Drawing.Size(265, 33);
            this.txt_Nome.TabIndex = 9;
            this.txt_Nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nome_KeyPress);
            // 
            // btn_OK
            // 
            this.btn_OK.Active = false;
            this.btn_OK.Activecolor = System.Drawing.Color.DarkRed;
            this.btn_OK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_OK.BackColor = System.Drawing.Color.DarkRed;
            this.btn_OK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_OK.BorderRadius = 0;
            this.btn_OK.ButtonText = "OK";
            this.btn_OK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_OK.DisabledColor = System.Drawing.Color.Gray;
            this.btn_OK.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OK.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_OK.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_OK.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_OK.Iconimage")));
            this.btn_OK.Iconimage_right = null;
            this.btn_OK.Iconimage_right_Selected = null;
            this.btn_OK.Iconimage_Selected = null;
            this.btn_OK.IconMarginLeft = 0;
            this.btn_OK.IconMarginRight = 0;
            this.btn_OK.IconRightVisible = false;
            this.btn_OK.IconRightZoom = 0D;
            this.btn_OK.IconVisible = false;
            this.btn_OK.IconZoom = 100D;
            this.btn_OK.IsTab = false;
            this.btn_OK.Location = new System.Drawing.Point(285, 38);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(5);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Normalcolor = System.Drawing.Color.DarkRed;
            this.btn_OK.OnHovercolor = System.Drawing.Color.Maroon;
            this.btn_OK.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_OK.selected = false;
            this.btn_OK.Size = new System.Drawing.Size(58, 34);
            this.btn_OK.TabIndex = 10;
            this.btn_OK.Text = "OK";
            this.btn_OK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_OK.Textcolor = System.Drawing.Color.White;
            this.btn_OK.TextFont = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // frm_Define_Nome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(350, 80);
            this.Controls.Add(this.pnl_BG);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Define_Nome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Definir Novo Nome";
            this.pnl_BG.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_BG;
        private LollipopLabel lbl_Titulo;
        private Bunifu.Framework.UI.BunifuElipse elip_Form;
        private Bunifu.Framework.UI.BunifuElipse elip_BG;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Nome;
        private Bunifu.Framework.UI.BunifuFlatButton btn_OK;
    }
}
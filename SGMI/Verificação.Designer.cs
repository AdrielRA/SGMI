namespace SGMI
{
    partial class frm_Verificação
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Verificação));
            this.epli_Form = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elip_BG = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnl_BG = new System.Windows.Forms.Panel();
            this.lbl_Tirulo = new LollipopLabel();
            this.btn_Verificar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Cancelar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_Codigo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_ReenviarCod = new LollipopLabel();
            this.pnl_BG.SuspendLayout();
            this.SuspendLayout();
            // 
            // epli_Form
            // 
            this.epli_Form.ElipseRadius = 10;
            this.epli_Form.TargetControl = this;
            // 
            // elip_BG
            // 
            this.elip_BG.ElipseRadius = 10;
            this.elip_BG.TargetControl = this.pnl_BG;
            // 
            // pnl_BG
            // 
            this.pnl_BG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_BG.BackColor = System.Drawing.Color.White;
            this.pnl_BG.Controls.Add(this.btn_ReenviarCod);
            this.pnl_BG.Controls.Add(this.txt_Codigo);
            this.pnl_BG.Controls.Add(this.btn_Verificar);
            this.pnl_BG.Controls.Add(this.btn_Cancelar);
            this.pnl_BG.Controls.Add(this.lbl_Tirulo);
            this.pnl_BG.Location = new System.Drawing.Point(1, 1);
            this.pnl_BG.Name = "pnl_BG";
            this.pnl_BG.Size = new System.Drawing.Size(242, 203);
            this.pnl_BG.TabIndex = 51;
            // 
            // lbl_Tirulo
            // 
            this.lbl_Tirulo.AutoEllipsis = true;
            this.lbl_Tirulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Tirulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tirulo.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Tirulo.Location = new System.Drawing.Point(11, 8);
            this.lbl_Tirulo.Name = "lbl_Tirulo";
            this.lbl_Tirulo.Size = new System.Drawing.Size(220, 54);
            this.lbl_Tirulo.TabIndex = 0;
            this.lbl_Tirulo.Text = "Digite o código recebido em seu e-mail:";
            this.lbl_Tirulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Verificar
            // 
            this.btn_Verificar.Active = false;
            this.btn_Verificar.Activecolor = System.Drawing.Color.DarkRed;
            this.btn_Verificar.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Verificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Verificar.BorderRadius = 0;
            this.btn_Verificar.ButtonText = "VERIFICAR";
            this.btn_Verificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Verificar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Verificar.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Verificar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Verificar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Verificar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Verificar.Iconimage")));
            this.btn_Verificar.Iconimage_right = null;
            this.btn_Verificar.Iconimage_right_Selected = null;
            this.btn_Verificar.Iconimage_Selected = null;
            this.btn_Verificar.IconMarginLeft = 0;
            this.btn_Verificar.IconMarginRight = 0;
            this.btn_Verificar.IconRightVisible = false;
            this.btn_Verificar.IconRightZoom = 0D;
            this.btn_Verificar.IconVisible = false;
            this.btn_Verificar.IconZoom = 100D;
            this.btn_Verificar.IsTab = false;
            this.btn_Verificar.Location = new System.Drawing.Point(123, 148);
            this.btn_Verificar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Verificar.Name = "btn_Verificar";
            this.btn_Verificar.Normalcolor = System.Drawing.Color.DarkRed;
            this.btn_Verificar.OnHovercolor = System.Drawing.Color.Maroon;
            this.btn_Verificar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Verificar.selected = false;
            this.btn_Verificar.Size = new System.Drawing.Size(106, 35);
            this.btn_Verificar.TabIndex = 54;
            this.btn_Verificar.Text = "VERIFICAR";
            this.btn_Verificar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Verificar.Textcolor = System.Drawing.Color.White;
            this.btn_Verificar.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Verificar.Click += new System.EventHandler(this.btn_Verificar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.ActiveBorderThickness = 1;
            this.btn_Cancelar.ActiveCornerRadius = 1;
            this.btn_Cancelar.ActiveFillColor = System.Drawing.Color.Crimson;
            this.btn_Cancelar.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Cancelar.ActiveLineColor = System.Drawing.Color.Crimson;
            this.btn_Cancelar.BackColor = System.Drawing.Color.White;
            this.btn_Cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.BackgroundImage")));
            this.btn_Cancelar.ButtonText = "CANCELAR";
            this.btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Cancelar.IdleBorderThickness = 1;
            this.btn_Cancelar.IdleCornerRadius = 1;
            this.btn_Cancelar.IdleFillColor = System.Drawing.Color.White;
            this.btn_Cancelar.IdleForecolor = System.Drawing.Color.Crimson;
            this.btn_Cancelar.IdleLineColor = System.Drawing.Color.Crimson;
            this.btn_Cancelar.Location = new System.Drawing.Point(8, 142);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Padding = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.btn_Cancelar.Size = new System.Drawing.Size(106, 45);
            this.btn_Cancelar.TabIndex = 44;
            this.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_Codigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_Codigo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Codigo.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Codigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Codigo.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Codigo.ForeColor = System.Drawing.Color.Maroon;
            this.txt_Codigo.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Codigo.HintText = "CÓDIGO";
            this.txt_Codigo.isPassword = false;
            this.txt_Codigo.LineFocusedColor = System.Drawing.Color.Maroon;
            this.txt_Codigo.LineIdleColor = System.Drawing.Color.Silver;
            this.txt_Codigo.LineMouseHoverColor = System.Drawing.Color.IndianRed;
            this.txt_Codigo.LineThickness = 3;
            this.txt_Codigo.Location = new System.Drawing.Point(8, 65);
            this.txt_Codigo.Margin = new System.Windows.Forms.Padding(0);
            this.txt_Codigo.MaxLength = 6;
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Codigo.Size = new System.Drawing.Size(223, 47);
            this.txt_Codigo.TabIndex = 55;
            this.txt_Codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Codigo_KeyPress);
            // 
            // btn_ReenviarCod
            // 
            this.btn_ReenviarCod.AutoEllipsis = true;
            this.btn_ReenviarCod.BackColor = System.Drawing.Color.Transparent;
            this.btn_ReenviarCod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ReenviarCod.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ReenviarCod.ForeColor = System.Drawing.Color.Maroon;
            this.btn_ReenviarCod.Location = new System.Drawing.Point(11, 115);
            this.btn_ReenviarCod.Name = "btn_ReenviarCod";
            this.btn_ReenviarCod.Size = new System.Drawing.Size(220, 22);
            this.btn_ReenviarCod.TabIndex = 56;
            this.btn_ReenviarCod.Text = "Não recebi meu código!";
            this.btn_ReenviarCod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ReenviarCod.Click += new System.EventHandler(this.btn_ReenviarCod_Click);
            // 
            // frm_Verificação
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(244, 205);
            this.Controls.Add(this.pnl_BG);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Verificação";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Verificação";
            this.pnl_BG.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btn_Cancelar;
        private Bunifu.Framework.UI.BunifuElipse epli_Form;
        private System.Windows.Forms.Panel pnl_BG;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Verificar;
        private LollipopLabel lbl_Tirulo;
        private Bunifu.Framework.UI.BunifuElipse elip_BG;
        private LollipopLabel btn_ReenviarCod;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Codigo;
    }
}
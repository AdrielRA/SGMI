namespace SGMI
{
    partial class frm_Detalhes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Detalhes));
            this.lbl_DataRegistro = new LollipopLabel();
            this.lbl_Descrição = new LollipopLabel();
            this.btn_Fechar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.epli_Form = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elip_Data = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elip_Desc = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txt_Desc = new System.Windows.Forms.TextBox();
            this.lollipopLabel1 = new LollipopLabel();
            this.dt_Registro = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dt_Ocorrido = new Bunifu.Framework.UI.BunifuDatepicker();
            this.pnl_BG = new System.Windows.Forms.Panel();
            this.lollipopLabel2 = new LollipopLabel();
            this.lb_Anexos = new System.Windows.Forms.ListBox();
            this.date_Ocorrido = new System.Windows.Forms.Label();
            this.date_Registro = new System.Windows.Forms.Label();
            this.elip_BG = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elip_Anexos = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btn_RemAnexo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_AddAnexo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnl_BG.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_DataRegistro
            // 
            this.lbl_DataRegistro.AutoEllipsis = true;
            this.lbl_DataRegistro.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DataRegistro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DataRegistro.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_DataRegistro.Location = new System.Drawing.Point(10, 39);
            this.lbl_DataRegistro.Name = "lbl_DataRegistro";
            this.lbl_DataRegistro.Size = new System.Drawing.Size(105, 20);
            this.lbl_DataRegistro.TabIndex = 0;
            this.lbl_DataRegistro.Text = "Registro:";
            this.lbl_DataRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Descrição
            // 
            this.lbl_Descrição.AutoEllipsis = true;
            this.lbl_Descrição.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Descrição.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descrição.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Descrição.Location = new System.Drawing.Point(10, 107);
            this.lbl_Descrição.Name = "lbl_Descrição";
            this.lbl_Descrição.Size = new System.Drawing.Size(105, 20);
            this.lbl_Descrição.TabIndex = 1;
            this.lbl_Descrição.Text = "Descrição:";
            this.lbl_Descrição.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.ActiveBorderThickness = 1;
            this.btn_Fechar.ActiveCornerRadius = 1;
            this.btn_Fechar.ActiveFillColor = System.Drawing.Color.Crimson;
            this.btn_Fechar.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Fechar.ActiveLineColor = System.Drawing.Color.Crimson;
            this.btn_Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Fechar.BackColor = System.Drawing.Color.White;
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
            this.btn_Fechar.Location = new System.Drawing.Point(541, 5);
            this.btn_Fechar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Padding = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.btn_Fechar.Size = new System.Drawing.Size(40, 40);
            this.btn_Fechar.TabIndex = 44;
            this.btn_Fechar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Fechar.Click += new System.EventHandler(this.Btn_Fechar_Click);
            // 
            // epli_Form
            // 
            this.epli_Form.ElipseRadius = 10;
            this.epli_Form.TargetControl = this;
            // 
            // elip_Data
            // 
            this.elip_Data.ElipseRadius = 5;
            this.elip_Data.TargetControl = this;
            // 
            // elip_Desc
            // 
            this.elip_Desc.ElipseRadius = 5;
            this.elip_Desc.TargetControl = this.txt_Desc;
            // 
            // txt_Desc
            // 
            this.txt_Desc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Desc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Desc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Desc.Location = new System.Drawing.Point(14, 130);
            this.txt_Desc.Multiline = true;
            this.txt_Desc.Name = "txt_Desc";
            this.txt_Desc.ReadOnly = true;
            this.txt_Desc.Size = new System.Drawing.Size(316, 94);
            this.txt_Desc.TabIndex = 49;
            // 
            // lollipopLabel1
            // 
            this.lollipopLabel1.AutoEllipsis = true;
            this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lollipopLabel1.ForeColor = System.Drawing.Color.Maroon;
            this.lollipopLabel1.Location = new System.Drawing.Point(177, 39);
            this.lollipopLabel1.Name = "lollipopLabel1";
            this.lollipopLabel1.Size = new System.Drawing.Size(105, 20);
            this.lollipopLabel1.TabIndex = 46;
            this.lollipopLabel1.Text = "Ocorrência:";
            this.lollipopLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dt_Registro
            // 
            this.dt_Registro.BackColor = System.Drawing.Color.DarkRed;
            this.dt_Registro.BorderRadius = 0;
            this.dt_Registro.Enabled = false;
            this.dt_Registro.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_Registro.ForeColor = System.Drawing.Color.White;
            this.dt_Registro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Registro.FormatCustom = null;
            this.dt_Registro.Location = new System.Drawing.Point(14, 64);
            this.dt_Registro.Margin = new System.Windows.Forms.Padding(5);
            this.dt_Registro.Name = "dt_Registro";
            this.dt_Registro.Size = new System.Drawing.Size(152, 35);
            this.dt_Registro.TabIndex = 47;
            this.dt_Registro.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // dt_Ocorrido
            // 
            this.dt_Ocorrido.BackColor = System.Drawing.Color.DarkRed;
            this.dt_Ocorrido.BorderRadius = 0;
            this.dt_Ocorrido.Enabled = false;
            this.dt_Ocorrido.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_Ocorrido.ForeColor = System.Drawing.Color.White;
            this.dt_Ocorrido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Ocorrido.FormatCustom = null;
            this.dt_Ocorrido.Location = new System.Drawing.Point(179, 64);
            this.dt_Ocorrido.Margin = new System.Windows.Forms.Padding(5);
            this.dt_Ocorrido.Name = "dt_Ocorrido";
            this.dt_Ocorrido.Size = new System.Drawing.Size(152, 35);
            this.dt_Ocorrido.TabIndex = 48;
            this.dt_Ocorrido.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // pnl_BG
            // 
            this.pnl_BG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_BG.BackColor = System.Drawing.Color.White;
            this.pnl_BG.Controls.Add(this.btn_RemAnexo);
            this.pnl_BG.Controls.Add(this.btn_AddAnexo);
            this.pnl_BG.Controls.Add(this.lollipopLabel2);
            this.pnl_BG.Controls.Add(this.lb_Anexos);
            this.pnl_BG.Controls.Add(this.date_Ocorrido);
            this.pnl_BG.Controls.Add(this.date_Registro);
            this.pnl_BG.Controls.Add(this.btn_Fechar);
            this.pnl_BG.Controls.Add(this.txt_Desc);
            this.pnl_BG.Controls.Add(this.lbl_DataRegistro);
            this.pnl_BG.Controls.Add(this.dt_Ocorrido);
            this.pnl_BG.Controls.Add(this.lbl_Descrição);
            this.pnl_BG.Controls.Add(this.dt_Registro);
            this.pnl_BG.Controls.Add(this.lollipopLabel1);
            this.pnl_BG.Location = new System.Drawing.Point(1, 1);
            this.pnl_BG.Name = "pnl_BG";
            this.pnl_BG.Size = new System.Drawing.Size(593, 235);
            this.pnl_BG.TabIndex = 50;
            // 
            // lollipopLabel2
            // 
            this.lollipopLabel2.AutoEllipsis = true;
            this.lollipopLabel2.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lollipopLabel2.ForeColor = System.Drawing.Color.Maroon;
            this.lollipopLabel2.Location = new System.Drawing.Point(333, 105);
            this.lollipopLabel2.Name = "lollipopLabel2";
            this.lollipopLabel2.Size = new System.Drawing.Size(103, 20);
            this.lollipopLabel2.TabIndex = 53;
            this.lollipopLabel2.Text = "Anexos:";
            this.lollipopLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_Anexos
            // 
            this.lb_Anexos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_Anexos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_Anexos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lb_Anexos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Anexos.ForeColor = System.Drawing.Color.DarkRed;
            this.lb_Anexos.FormattingEnabled = true;
            this.lb_Anexos.ItemHeight = 16;
            this.lb_Anexos.Location = new System.Drawing.Point(337, 128);
            this.lb_Anexos.Name = "lb_Anexos";
            this.lb_Anexos.Size = new System.Drawing.Size(245, 96);
            this.lb_Anexos.TabIndex = 52;
            this.lb_Anexos.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lb_Anexos_DrawItem);
            this.lb_Anexos.DoubleClick += new System.EventHandler(this.lb_Anexos_DoubleClick);
            // 
            // date_Ocorrido
            // 
            this.date_Ocorrido.AutoEllipsis = true;
            this.date_Ocorrido.BackColor = System.Drawing.Color.DarkRed;
            this.date_Ocorrido.ForeColor = System.Drawing.Color.White;
            this.date_Ocorrido.Location = new System.Drawing.Point(217, 64);
            this.date_Ocorrido.Name = "date_Ocorrido";
            this.date_Ocorrido.Size = new System.Drawing.Size(113, 33);
            this.date_Ocorrido.TabIndex = 51;
            this.date_Ocorrido.Text = "00/00/0000";
            this.date_Ocorrido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // date_Registro
            // 
            this.date_Registro.AutoEllipsis = true;
            this.date_Registro.BackColor = System.Drawing.Color.DarkRed;
            this.date_Registro.ForeColor = System.Drawing.Color.White;
            this.date_Registro.Location = new System.Drawing.Point(52, 64);
            this.date_Registro.Name = "date_Registro";
            this.date_Registro.Size = new System.Drawing.Size(113, 33);
            this.date_Registro.TabIndex = 50;
            this.date_Registro.Text = "00/00/0000";
            this.date_Registro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // elip_BG
            // 
            this.elip_BG.ElipseRadius = 10;
            this.elip_BG.TargetControl = this.pnl_BG;
            // 
            // elip_Anexos
            // 
            this.elip_Anexos.ElipseRadius = 5;
            this.elip_Anexos.TargetControl = this.lb_Anexos;
            // 
            // btn_RemAnexo
            // 
            this.btn_RemAnexo.Active = false;
            this.btn_RemAnexo.Activecolor = System.Drawing.Color.DarkRed;
            this.btn_RemAnexo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_RemAnexo.BackColor = System.Drawing.Color.DarkRed;
            this.btn_RemAnexo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_RemAnexo.BorderRadius = 0;
            this.btn_RemAnexo.ButtonText = "REMOVER";
            this.btn_RemAnexo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RemAnexo.DisabledColor = System.Drawing.Color.Gray;
            this.btn_RemAnexo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RemAnexo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_RemAnexo.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_RemAnexo.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_RemAnexo.Iconimage")));
            this.btn_RemAnexo.Iconimage_right = null;
            this.btn_RemAnexo.Iconimage_right_Selected = null;
            this.btn_RemAnexo.Iconimage_Selected = null;
            this.btn_RemAnexo.IconMarginLeft = 0;
            this.btn_RemAnexo.IconMarginRight = 0;
            this.btn_RemAnexo.IconRightVisible = false;
            this.btn_RemAnexo.IconRightZoom = 0D;
            this.btn_RemAnexo.IconVisible = false;
            this.btn_RemAnexo.IconZoom = 100D;
            this.btn_RemAnexo.IsTab = false;
            this.btn_RemAnexo.Location = new System.Drawing.Point(461, 64);
            this.btn_RemAnexo.Margin = new System.Windows.Forms.Padding(5);
            this.btn_RemAnexo.Name = "btn_RemAnexo";
            this.btn_RemAnexo.Normalcolor = System.Drawing.Color.DarkRed;
            this.btn_RemAnexo.OnHovercolor = System.Drawing.Color.Maroon;
            this.btn_RemAnexo.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_RemAnexo.selected = false;
            this.btn_RemAnexo.Size = new System.Drawing.Size(120, 35);
            this.btn_RemAnexo.TabIndex = 55;
            this.btn_RemAnexo.Text = "REMOVER";
            this.btn_RemAnexo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_RemAnexo.Textcolor = System.Drawing.Color.White;
            this.btn_RemAnexo.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RemAnexo.Click += new System.EventHandler(this.btn_RemAnexo_Click);
            // 
            // btn_AddAnexo
            // 
            this.btn_AddAnexo.Active = false;
            this.btn_AddAnexo.Activecolor = System.Drawing.Color.DarkRed;
            this.btn_AddAnexo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddAnexo.BackColor = System.Drawing.Color.DarkRed;
            this.btn_AddAnexo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AddAnexo.BorderRadius = 0;
            this.btn_AddAnexo.ButtonText = "ADICIONAR";
            this.btn_AddAnexo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddAnexo.DisabledColor = System.Drawing.Color.Gray;
            this.btn_AddAnexo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddAnexo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_AddAnexo.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_AddAnexo.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_AddAnexo.Iconimage")));
            this.btn_AddAnexo.Iconimage_right = null;
            this.btn_AddAnexo.Iconimage_right_Selected = null;
            this.btn_AddAnexo.Iconimage_Selected = null;
            this.btn_AddAnexo.IconMarginLeft = 0;
            this.btn_AddAnexo.IconMarginRight = 0;
            this.btn_AddAnexo.IconRightVisible = false;
            this.btn_AddAnexo.IconRightZoom = 0D;
            this.btn_AddAnexo.IconVisible = false;
            this.btn_AddAnexo.IconZoom = 100D;
            this.btn_AddAnexo.IsTab = false;
            this.btn_AddAnexo.Location = new System.Drawing.Point(336, 64);
            this.btn_AddAnexo.Margin = new System.Windows.Forms.Padding(5);
            this.btn_AddAnexo.Name = "btn_AddAnexo";
            this.btn_AddAnexo.Normalcolor = System.Drawing.Color.DarkRed;
            this.btn_AddAnexo.OnHovercolor = System.Drawing.Color.Maroon;
            this.btn_AddAnexo.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_AddAnexo.selected = false;
            this.btn_AddAnexo.Size = new System.Drawing.Size(120, 35);
            this.btn_AddAnexo.TabIndex = 54;
            this.btn_AddAnexo.Text = "ADICIONAR";
            this.btn_AddAnexo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_AddAnexo.Textcolor = System.Drawing.Color.White;
            this.btn_AddAnexo.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddAnexo.Click += new System.EventHandler(this.btn_AddAnexo_Click);
            // 
            // frm_Detalhes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(595, 237);
            this.Controls.Add(this.pnl_BG);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Detalhes";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_Detalhes";
            this.pnl_BG.ResumeLayout(false);
            this.pnl_BG.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private LollipopLabel lbl_DataRegistro;
        private LollipopLabel lbl_Descrição;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Fechar;
        private Bunifu.Framework.UI.BunifuElipse epli_Form;
        private Bunifu.Framework.UI.BunifuElipse elip_Data;
        private Bunifu.Framework.UI.BunifuElipse elip_Desc;
        private LollipopLabel lollipopLabel1;
        private System.Windows.Forms.TextBox txt_Desc;
        private Bunifu.Framework.UI.BunifuDatepicker dt_Ocorrido;
        private Bunifu.Framework.UI.BunifuDatepicker dt_Registro;
        private System.Windows.Forms.Panel pnl_BG;
        private Bunifu.Framework.UI.BunifuElipse elip_BG;
        private System.Windows.Forms.Label date_Registro;
        private System.Windows.Forms.Label date_Ocorrido;
        private LollipopLabel lollipopLabel2;
        private System.Windows.Forms.ListBox lb_Anexos;
        private Bunifu.Framework.UI.BunifuElipse elip_Anexos;
        private Bunifu.Framework.UI.BunifuFlatButton btn_RemAnexo;
        private Bunifu.Framework.UI.BunifuFlatButton btn_AddAnexo;
    }
}
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
            this.lbl_Data = new LollipopLabel();
            this.lbl_Descrição = new LollipopLabel();
            this.btn_Fechar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_data = new System.Windows.Forms.TextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lb_Desc = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl_Data
            // 
            this.lbl_Data.AutoSize = true;
            this.lbl_Data.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Data.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_Data.Location = new System.Drawing.Point(10, 47);
            this.lbl_Data.Name = "lbl_Data";
            this.lbl_Data.Size = new System.Drawing.Size(48, 20);
            this.lbl_Data.TabIndex = 0;
            this.lbl_Data.Text = "Data";
            // 
            // lbl_Descrição
            // 
            this.lbl_Descrição.AutoSize = true;
            this.lbl_Descrição.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Descrição.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descrição.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_Descrição.Location = new System.Drawing.Point(10, 82);
            this.lbl_Descrição.Name = "lbl_Descrição";
            this.lbl_Descrição.Size = new System.Drawing.Size(89, 20);
            this.lbl_Descrição.TabIndex = 1;
            this.lbl_Descrição.Text = "Descrição";
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
            this.btn_Fechar.Location = new System.Drawing.Point(293, -2);
            this.btn_Fechar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(40, 40);
            this.btn_Fechar.TabIndex = 44;
            this.btn_Fechar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Fechar.Click += new System.EventHandler(this.Btn_Fechar_Click);
            // 
            // txt_data
            // 
            this.txt_data.BackColor = System.Drawing.Color.Silver;
            this.txt_data.Location = new System.Drawing.Point(64, 49);
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(100, 20);
            this.txt_data.TabIndex = 45;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this.txt_data;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 10;
            this.bunifuElipse3.TargetControl = this.lb_Desc;
            // 
            // lb_Desc
            // 
            this.lb_Desc.BackColor = System.Drawing.Color.Silver;
            this.lb_Desc.FormatString = "Desc";
            this.lb_Desc.FormattingEnabled = true;
            this.lb_Desc.Location = new System.Drawing.Point(14, 105);
            this.lb_Desc.Name = "lb_Desc";
            this.lb_Desc.Size = new System.Drawing.Size(308, 82);
            this.lb_Desc.TabIndex = 43;
            // 
            // frm_Detalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(336, 215);
            this.Controls.Add(this.txt_data);
            this.Controls.Add(this.btn_Fechar);
            this.Controls.Add(this.lb_Desc);
            this.Controls.Add(this.lbl_Descrição);
            this.Controls.Add(this.lbl_Data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Detalhes";
            this.Text = "frm_Detalhes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LollipopLabel lbl_Data;
        private LollipopLabel lbl_Descrição;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Fechar;
        private System.Windows.Forms.TextBox txt_data;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private System.Windows.Forms.ListBox lb_Desc;
    }
}
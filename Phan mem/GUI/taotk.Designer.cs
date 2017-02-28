namespace GUI
{
    partial class taotk
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
            this.label1 = new System.Windows.Forms.Label();
            this.txttk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.btnthot = new GUI.ComponentForm.Thin_Button();
            this.btntaotk = new GUI.ComponentForm.Thin_Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(232, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tài Khoản";
            // 
            // txttk
            // 
            this.txttk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txttk.Location = new System.Drawing.Point(315, 41);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(175, 20);
            this.txttk.TabIndex = 6;
            this.txttk.Text = "Nhập tài khoản";
            this.txttk.Click += new System.EventHandler(this.txttk_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(232, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mật Khẩu";
            // 
            // txtmk
            // 
            this.txtmk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtmk.Location = new System.Drawing.Point(315, 76);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(175, 20);
            this.txtmk.TabIndex = 8;
            this.txtmk.Text = "Nhập password";
            // 
            // btnthot
            // 
            this.btnthot.Active = false;
            this.btnthot.BackColor = System.Drawing.Color.Transparent;
            this.btnthot.BoderColorDisable = System.Drawing.Color.Empty;
            this.btnthot.BorderColorClick = System.Drawing.Color.Empty;
            this.btnthot.BorderColorHover = System.Drawing.Color.Empty;
            this.btnthot.BorderColorNomal = System.Drawing.Color.Green;
            this.btnthot.InnerColorClick = System.Drawing.Color.Empty;
            this.btnthot.InnerColorDisable = System.Drawing.Color.Empty;
            this.btnthot.InnerColorHover = System.Drawing.Color.Empty;
            this.btnthot.InnerColorNomal = System.Drawing.Color.Transparent;
            this.btnthot.Location = new System.Drawing.Point(395, 177);
            this.btnthot.Name = "btnthot";
            this.btnthot.Size = new System.Drawing.Size(75, 23);
            this.btnthot.SizeBorder = 1;
            this.btnthot.TabIndex = 10;
            this.btnthot.Text = "Thoát";
            this.btnthot.TextAlignmentHorizontal = System.Drawing.StringAlignment.Center;
            this.btnthot.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.btnthot.TextColorClick = System.Drawing.Color.Empty;
            this.btnthot.TextColorDisable = System.Drawing.Color.Empty;
            this.btnthot.TextColorHover = System.Drawing.Color.Empty;
            this.btnthot.TextColorNomal = System.Drawing.Color.Black;
            this.btnthot.UseActive = false;
            this.btnthot.UseBorderColorHoverClick = false;
            this.btnthot.UseInnerColorHoverClick = false;
            this.btnthot.UseTextColorHoverClick = false;
            this.btnthot.Click += new System.EventHandler(this.btnthot_Click);
            // 
            // btntaotk
            // 
            this.btntaotk.Active = false;
            this.btntaotk.BackColor = System.Drawing.Color.Transparent;
            this.btntaotk.BoderColorDisable = System.Drawing.Color.Empty;
            this.btntaotk.BorderColorClick = System.Drawing.Color.Empty;
            this.btntaotk.BorderColorHover = System.Drawing.Color.Empty;
            this.btntaotk.BorderColorNomal = System.Drawing.Color.Green;
            this.btntaotk.InnerColorClick = System.Drawing.Color.Empty;
            this.btntaotk.InnerColorDisable = System.Drawing.Color.Empty;
            this.btntaotk.InnerColorHover = System.Drawing.Color.Empty;
            this.btntaotk.InnerColorNomal = System.Drawing.Color.Transparent;
            this.btntaotk.Location = new System.Drawing.Point(234, 177);
            this.btntaotk.Name = "btntaotk";
            this.btntaotk.Size = new System.Drawing.Size(75, 23);
            this.btntaotk.SizeBorder = 1;
            this.btntaotk.TabIndex = 9;
            this.btntaotk.Text = "Tạo tài Khoản";
            this.btntaotk.TextAlignmentHorizontal = System.Drawing.StringAlignment.Center;
            this.btntaotk.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.btntaotk.TextColorClick = System.Drawing.Color.Empty;
            this.btntaotk.TextColorDisable = System.Drawing.Color.Empty;
            this.btntaotk.TextColorHover = System.Drawing.Color.Empty;
            this.btntaotk.TextColorNomal = System.Drawing.Color.Black;
            this.btntaotk.UseActive = false;
            this.btntaotk.UseBorderColorHoverClick = false;
            this.btntaotk.UseInnerColorHoverClick = false;
            this.btntaotk.UseTextColorHoverClick = false;
            this.btntaotk.Click += new System.EventHandler(this.btntaotk_Click);
            // 
            // taotk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.loginstyle1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(526, 222);
            this.Controls.Add(this.btnthot);
            this.Controls.Add(this.btntaotk);
            this.Controls.Add(this.txtmk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttk);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "taotk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "taotk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmk;
        private ComponentForm.Thin_Button btntaotk;
        private ComponentForm.Thin_Button btnthot;
    }
}
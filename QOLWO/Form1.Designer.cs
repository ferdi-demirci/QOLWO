
namespace QOLWO
{
    partial class Form1
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
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.btngiris = new DevExpress.XtraEditors.SimpleButton();
            this.btncikis = new System.Windows.Forms.LinkLabel();
            this.btnbaglanti = new System.Windows.Forms.LinkLabel();
            this.btnaktif = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(95, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log in";
            // 
            // txtuser
            // 
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtuser.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtuser.Location = new System.Drawing.Point(103, 144);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(322, 56);
            this.txtuser.TabIndex = 1;
            this.txtuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtpass
            // 
            this.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtpass.Location = new System.Drawing.Point(103, 219);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(322, 56);
            this.txtpass.TabIndex = 2;
            this.txtpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // btngiris
            // 
            this.btngiris.Appearance.BackColor = System.Drawing.Color.Teal;
            this.btngiris.Appearance.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngiris.Appearance.Options.UseBackColor = true;
            this.btngiris.Appearance.Options.UseFont = true;
            this.btngiris.AppearanceHovered.BackColor = System.Drawing.Color.Turquoise;
            this.btngiris.AppearanceHovered.Options.UseBackColor = true;
            this.btngiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngiris.Location = new System.Drawing.Point(103, 293);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(322, 52);
            this.btngiris.TabIndex = 3;
            this.btngiris.Text = "Log in";
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // btncikis
            // 
            this.btncikis.AutoSize = true;
            this.btncikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncikis.LinkColor = System.Drawing.Color.Red;
            this.btncikis.Location = new System.Drawing.Point(377, 359);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(48, 17);
            this.btncikis.TabIndex = 4;
            this.btncikis.TabStop = true;
            this.btncikis.Text = "Close";
            this.btncikis.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btncikis_LinkClicked);
            // 
            // btnbaglanti
            // 
            this.btnbaglanti.AutoSize = true;
            this.btnbaglanti.LinkColor = System.Drawing.Color.Chocolate;
            this.btnbaglanti.Location = new System.Drawing.Point(12, 444);
            this.btnbaglanti.Name = "btnbaglanti";
            this.btnbaglanti.Size = new System.Drawing.Size(144, 17);
            this.btnbaglanti.TabIndex = 5;
            this.btnbaglanti.TabStop = true;
            this.btnbaglanti.Text = "Database Connection";
            this.btnbaglanti.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnbaglanti_LinkClicked);
            // 
            // btnaktif
            // 
            this.btnaktif.Appearance.BackColor = System.Drawing.Color.Teal;
            this.btnaktif.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnaktif.Appearance.Options.UseBackColor = true;
            this.btnaktif.Appearance.Options.UseFont = true;
            this.btnaktif.AppearanceHovered.BackColor = System.Drawing.Color.Turquoise;
            this.btnaktif.AppearanceHovered.Options.UseBackColor = true;
            this.btnaktif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaktif.Location = new System.Drawing.Point(478, 434);
            this.btnaktif.Name = "btnaktif";
            this.btnaktif.Size = new System.Drawing.Size(55, 32);
            this.btnaktif.TabIndex = 6;
            this.btnaktif.Text = "Beta";
            this.btnaktif.Click += new System.EventHandler(this.btnaktif_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btngiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(545, 470);
            this.Controls.Add(this.btnaktif);
            this.Controls.Add(this.btnbaglanti);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.btngiris);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpass;
        private DevExpress.XtraEditors.SimpleButton btngiris;
        private System.Windows.Forms.LinkLabel btncikis;
        private System.Windows.Forms.LinkLabel btnbaglanti;
        private DevExpress.XtraEditors.SimpleButton btnaktif;
    }
}


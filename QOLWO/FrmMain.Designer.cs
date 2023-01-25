
namespace QOLWO
{
    partial class FrmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonMin = new System.Windows.Forms.PictureBox();
            this.ButtonClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblbaglantidurumu = new System.Windows.Forms.Label();
            this.lbldbadi = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblgunceltarihsaat = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblkullaniciadi = new System.Windows.Forms.Label();
            this.ButtonIcHareket = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonDisHareket = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonHareket = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonModeller = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonIcKalip = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonDisKalip = new DevExpress.XtraEditors.SimpleButton();
            this.pnlMdi = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonClose)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.ButtonMin);
            this.panel1.Controls.Add(this.ButtonClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1975, 60);
            this.panel1.TabIndex = 0;
            // 
            // ButtonMin
            // 
            this.ButtonMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonMin.Image = global::QOLWO.Properties.Resources.navigate_minus;
            this.ButtonMin.Location = new System.Drawing.Point(1897, 0);
            this.ButtonMin.Name = "ButtonMin";
            this.ButtonMin.Size = new System.Drawing.Size(39, 60);
            this.ButtonMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButtonMin.TabIndex = 4;
            this.ButtonMin.TabStop = false;
            this.ButtonMin.Click += new System.EventHandler(this.ButtonMin_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonClose.Image = global::QOLWO.Properties.Resources.delete;
            this.ButtonClose.Location = new System.Drawing.Point(1936, 0);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(39, 60);
            this.ButtonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButtonClose.TabIndex = 3;
            this.ButtonClose.TabStop = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kalıp Takip Programı";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lblgunceltarihsaat);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblkullaniciadi);
            this.panel2.Controls.Add(this.ButtonIcHareket);
            this.panel2.Controls.Add(this.ButtonDisHareket);
            this.panel2.Controls.Add(this.ButtonHareket);
            this.panel2.Controls.Add(this.ButtonModeller);
            this.panel2.Controls.Add(this.ButtonIcKalip);
            this.panel2.Controls.Add(this.ButtonDisKalip);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(247, 1020);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblbaglantidurumu);
            this.panel3.Controls.Add(this.lbldbadi);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 920);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(247, 100);
            this.panel3.TabIndex = 16;
            // 
            // lblbaglantidurumu
            // 
            this.lblbaglantidurumu.AutoSize = true;
            this.lblbaglantidurumu.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblbaglantidurumu.Location = new System.Drawing.Point(71, 55);
            this.lblbaglantidurumu.Name = "lblbaglantidurumu";
            this.lblbaglantidurumu.Size = new System.Drawing.Size(129, 21);
            this.lblbaglantidurumu.TabIndex = 16;
            this.lblbaglantidurumu.Text = "Bağlantı Başarılı !";
            // 
            // lbldbadi
            // 
            this.lbldbadi.AutoSize = true;
            this.lbldbadi.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbldbadi.Location = new System.Drawing.Point(71, 25);
            this.lbldbadi.Name = "lbldbadi";
            this.lbldbadi.Size = new System.Drawing.Size(82, 21);
            this.lbldbadi.TabIndex = 15;
            this.lbldbadi.Text = "DBQOWO";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::QOLWO.Properties.Resources.data_green;
            this.pictureBox3.Location = new System.Drawing.Point(3, 17);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(62, 62);
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Creattion Demo", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 684);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 35);
            this.label8.TabIndex = 15;
            this.label8.Text = "Developer By Ferdi";
            // 
            // lblgunceltarihsaat
            // 
            this.lblgunceltarihsaat.AutoSize = true;
            this.lblgunceltarihsaat.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblgunceltarihsaat.Location = new System.Drawing.Point(30, 95);
            this.lblgunceltarihsaat.Name = "lblgunceltarihsaat";
            this.lblgunceltarihsaat.Size = new System.Drawing.Size(174, 23);
            this.lblgunceltarihsaat.TabIndex = 3;
            this.lblgunceltarihsaat.Text = "09.01.2023 17:14:05";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QOLWO.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(35, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 52);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(97, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Hoşgeldiniz..";
            // 
            // lblkullaniciadi
            // 
            this.lblkullaniciadi.AutoSize = true;
            this.lblkullaniciadi.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkullaniciadi.Location = new System.Drawing.Point(97, 29);
            this.lblkullaniciadi.Name = "lblkullaniciadi";
            this.lblkullaniciadi.Size = new System.Drawing.Size(71, 21);
            this.lblkullaniciadi.TabIndex = 3;
            this.lblkullaniciadi.Text = "okedoke";
            // 
            // ButtonIcHareket
            // 
            this.ButtonIcHareket.Appearance.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ButtonIcHareket.Appearance.BackColor2 = System.Drawing.Color.Teal;
            this.ButtonIcHareket.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonIcHareket.Appearance.Options.UseBackColor = true;
            this.ButtonIcHareket.Appearance.Options.UseBorderColor = true;
            this.ButtonIcHareket.Appearance.Options.UseFont = true;
            this.ButtonIcHareket.Appearance.Options.UseForeColor = true;
            this.ButtonIcHareket.Appearance.Options.UseImage = true;
            this.ButtonIcHareket.AppearanceHovered.BackColor = System.Drawing.Color.Turquoise;
            this.ButtonIcHareket.AppearanceHovered.Options.UseBackColor = true;
            this.ButtonIcHareket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonIcHareket.Location = new System.Drawing.Point(5, 559);
            this.ButtonIcHareket.Name = "ButtonIcHareket";
            this.ButtonIcHareket.Size = new System.Drawing.Size(235, 82);
            this.ButtonIcHareket.TabIndex = 9;
            this.ButtonIcHareket.Text = "İç Hareketler";
            // 
            // ButtonDisHareket
            // 
            this.ButtonDisHareket.Appearance.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ButtonDisHareket.Appearance.BackColor2 = System.Drawing.Color.Teal;
            this.ButtonDisHareket.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonDisHareket.Appearance.Options.UseBackColor = true;
            this.ButtonDisHareket.Appearance.Options.UseBorderColor = true;
            this.ButtonDisHareket.Appearance.Options.UseFont = true;
            this.ButtonDisHareket.Appearance.Options.UseForeColor = true;
            this.ButtonDisHareket.Appearance.Options.UseImage = true;
            this.ButtonDisHareket.AppearanceHovered.BackColor = System.Drawing.Color.Turquoise;
            this.ButtonDisHareket.AppearanceHovered.Options.UseBackColor = true;
            this.ButtonDisHareket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDisHareket.Location = new System.Drawing.Point(5, 473);
            this.ButtonDisHareket.Name = "ButtonDisHareket";
            this.ButtonDisHareket.Size = new System.Drawing.Size(235, 82);
            this.ButtonDisHareket.TabIndex = 8;
            this.ButtonDisHareket.Text = "Dış Hareketler";
            // 
            // ButtonHareket
            // 
            this.ButtonHareket.Appearance.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ButtonHareket.Appearance.BackColor2 = System.Drawing.Color.Teal;
            this.ButtonHareket.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonHareket.Appearance.Options.UseBackColor = true;
            this.ButtonHareket.Appearance.Options.UseBorderColor = true;
            this.ButtonHareket.Appearance.Options.UseFont = true;
            this.ButtonHareket.Appearance.Options.UseForeColor = true;
            this.ButtonHareket.Appearance.Options.UseImage = true;
            this.ButtonHareket.AppearanceHovered.BackColor = System.Drawing.Color.Turquoise;
            this.ButtonHareket.AppearanceHovered.Options.UseBackColor = true;
            this.ButtonHareket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonHareket.Location = new System.Drawing.Point(5, 387);
            this.ButtonHareket.Name = "ButtonHareket";
            this.ButtonHareket.Size = new System.Drawing.Size(235, 82);
            this.ButtonHareket.TabIndex = 7;
            this.ButtonHareket.Text = "Hareket Oluştur";
            // 
            // ButtonModeller
            // 
            this.ButtonModeller.Appearance.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ButtonModeller.Appearance.BackColor2 = System.Drawing.Color.Teal;
            this.ButtonModeller.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonModeller.Appearance.Options.UseBackColor = true;
            this.ButtonModeller.Appearance.Options.UseBorderColor = true;
            this.ButtonModeller.Appearance.Options.UseFont = true;
            this.ButtonModeller.Appearance.Options.UseForeColor = true;
            this.ButtonModeller.Appearance.Options.UseImage = true;
            this.ButtonModeller.AppearanceHovered.BackColor = System.Drawing.Color.Turquoise;
            this.ButtonModeller.AppearanceHovered.Options.UseBackColor = true;
            this.ButtonModeller.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonModeller.Location = new System.Drawing.Point(5, 302);
            this.ButtonModeller.Name = "ButtonModeller";
            this.ButtonModeller.Size = new System.Drawing.Size(235, 82);
            this.ButtonModeller.TabIndex = 6;
            this.ButtonModeller.Text = "Modeller";
            this.ButtonModeller.Click += new System.EventHandler(this.ButtonModeller_Click);
            // 
            // ButtonIcKalip
            // 
            this.ButtonIcKalip.Appearance.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ButtonIcKalip.Appearance.BackColor2 = System.Drawing.Color.Teal;
            this.ButtonIcKalip.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonIcKalip.Appearance.Options.UseBackColor = true;
            this.ButtonIcKalip.Appearance.Options.UseBorderColor = true;
            this.ButtonIcKalip.Appearance.Options.UseFont = true;
            this.ButtonIcKalip.Appearance.Options.UseForeColor = true;
            this.ButtonIcKalip.Appearance.Options.UseImage = true;
            this.ButtonIcKalip.AppearanceHovered.BackColor = System.Drawing.Color.Turquoise;
            this.ButtonIcKalip.AppearanceHovered.Options.UseBackColor = true;
            this.ButtonIcKalip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonIcKalip.Location = new System.Drawing.Point(5, 217);
            this.ButtonIcKalip.Name = "ButtonIcKalip";
            this.ButtonIcKalip.Size = new System.Drawing.Size(235, 82);
            this.ButtonIcKalip.TabIndex = 5;
            this.ButtonIcKalip.Text = "İç Kalıplar";
            this.ButtonIcKalip.Click += new System.EventHandler(this.ButtonIcKalip_Click);
            // 
            // ButtonDisKalip
            // 
            this.ButtonDisKalip.Appearance.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ButtonDisKalip.Appearance.BackColor2 = System.Drawing.Color.Teal;
            this.ButtonDisKalip.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonDisKalip.Appearance.Options.UseBackColor = true;
            this.ButtonDisKalip.Appearance.Options.UseBorderColor = true;
            this.ButtonDisKalip.Appearance.Options.UseFont = true;
            this.ButtonDisKalip.Appearance.Options.UseForeColor = true;
            this.ButtonDisKalip.Appearance.Options.UseImage = true;
            this.ButtonDisKalip.AppearanceHovered.BackColor = System.Drawing.Color.Turquoise;
            this.ButtonDisKalip.AppearanceHovered.Options.UseBackColor = true;
            this.ButtonDisKalip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDisKalip.Location = new System.Drawing.Point(5, 132);
            this.ButtonDisKalip.Name = "ButtonDisKalip";
            this.ButtonDisKalip.Size = new System.Drawing.Size(235, 82);
            this.ButtonDisKalip.TabIndex = 4;
            this.ButtonDisKalip.Text = "Dış Kalıplar";
            this.ButtonDisKalip.Click += new System.EventHandler(this.ButtonDisKalip_Click);
            // 
            // pnlMdi
            // 
            this.pnlMdi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMdi.Location = new System.Drawing.Point(247, 60);
            this.pnlMdi.Name = "pnlMdi";
            this.pnlMdi.Size = new System.Drawing.Size(1728, 1020);
            this.pnlMdi.TabIndex = 4;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1975, 1080);
            this.Controls.Add(this.pnlMdi);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[Main]";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonClose)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton ButtonIcHareket;
        private DevExpress.XtraEditors.SimpleButton ButtonDisHareket;
        private DevExpress.XtraEditors.SimpleButton ButtonHareket;
        private DevExpress.XtraEditors.SimpleButton ButtonModeller;
        private DevExpress.XtraEditors.SimpleButton ButtonIcKalip;
        private DevExpress.XtraEditors.SimpleButton ButtonDisKalip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblgunceltarihsaat;
        private System.Windows.Forms.PictureBox ButtonMin;
        private System.Windows.Forms.PictureBox ButtonClose;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlMdi;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblbaglantidurumu;
        private System.Windows.Forms.Label lbldbadi;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.Label lblkullaniciadi;
    }
}

namespace QOLWO
{
    partial class FrmBaglanti
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
            this.btnkaydet = new System.Windows.Forms.Button();
            this.lbldatabese = new System.Windows.Forms.Label();
            this.lblsifre = new System.Windows.Forms.Label();
            this.lblkullaniciadi = new System.Windows.Forms.Label();
            this.lblipadresi = new System.Windows.Forms.Label();
            this.txtsifre = new DevExpress.XtraEditors.TextEdit();
            this.txtdatabese = new DevExpress.XtraEditors.TextEdit();
            this.txtipadres = new DevExpress.XtraEditors.TextEdit();
            this.txtkullaniciadi = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdatabese.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtipadres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkullaniciadi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnkaydet
            // 
            this.btnkaydet.BackColor = System.Drawing.Color.Green;
            this.btnkaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnkaydet.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkaydet.ForeColor = System.Drawing.Color.White;
            this.btnkaydet.Location = new System.Drawing.Point(164, 198);
            this.btnkaydet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(182, 37);
            this.btnkaydet.TabIndex = 68;
            this.btnkaydet.Text = "Save and Test";
            this.btnkaydet.UseVisualStyleBackColor = false;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // lbldatabese
            // 
            this.lbldatabese.AutoSize = true;
            this.lbldatabese.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbldatabese.Location = new System.Drawing.Point(58, 150);
            this.lbldatabese.Name = "lbldatabese";
            this.lbldatabese.Size = new System.Drawing.Size(84, 17);
            this.lbldatabese.TabIndex = 67;
            this.lbldatabese.Text = "DB Name :";
            // 
            // lblsifre
            // 
            this.lblsifre.AutoSize = true;
            this.lblsifre.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsifre.Location = new System.Drawing.Point(58, 113);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(86, 17);
            this.lblsifre.TabIndex = 66;
            this.lblsifre.Text = "Password :";
            // 
            // lblkullaniciadi
            // 
            this.lblkullaniciadi.AutoSize = true;
            this.lblkullaniciadi.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkullaniciadi.Location = new System.Drawing.Point(47, 73);
            this.lblkullaniciadi.Name = "lblkullaniciadi";
            this.lblkullaniciadi.Size = new System.Drawing.Size(95, 17);
            this.lblkullaniciadi.TabIndex = 65;
            this.lblkullaniciadi.Text = "User Name :";
            this.lblkullaniciadi.Click += new System.EventHandler(this.lblkullaniciadi_Click);
            // 
            // lblipadresi
            // 
            this.lblipadresi.AutoSize = true;
            this.lblipadresi.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblipadresi.Location = new System.Drawing.Point(110, 42);
            this.lblipadresi.Name = "lblipadresi";
            this.lblipadresi.Size = new System.Drawing.Size(32, 17);
            this.lblipadresi.TabIndex = 64;
            this.lblipadresi.Text = "IP :";
            // 
            // txtsifre
            // 
            this.txtsifre.EnterMoveNextControl = true;
            this.txtsifre.Location = new System.Drawing.Point(148, 110);
            this.txtsifre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsifre.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtsifre.Properties.Appearance.Options.UseFont = true;
            this.txtsifre.Properties.Appearance.Options.UseForeColor = true;
            this.txtsifre.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtsifre.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtsifre.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtsifre.Properties.UseSystemPasswordChar = true;
            this.txtsifre.Size = new System.Drawing.Size(228, 24);
            this.txtsifre.TabIndex = 62;
            this.txtsifre.Tag = "";
            // 
            // txtdatabese
            // 
            this.txtdatabese.Location = new System.Drawing.Point(148, 147);
            this.txtdatabese.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdatabese.Name = "txtdatabese";
            this.txtdatabese.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtdatabese.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtdatabese.Properties.Appearance.Options.UseFont = true;
            this.txtdatabese.Properties.Appearance.Options.UseForeColor = true;
            this.txtdatabese.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtdatabese.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtdatabese.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtdatabese.Size = new System.Drawing.Size(228, 24);
            this.txtdatabese.TabIndex = 63;
            this.txtdatabese.Tag = "";
            // 
            // txtipadres
            // 
            this.txtipadres.EnterMoveNextControl = true;
            this.txtipadres.Location = new System.Drawing.Point(148, 31);
            this.txtipadres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtipadres.Name = "txtipadres";
            this.txtipadres.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtipadres.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtipadres.Properties.Appearance.Options.UseFont = true;
            this.txtipadres.Properties.Appearance.Options.UseForeColor = true;
            this.txtipadres.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtipadres.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtipadres.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtipadres.Size = new System.Drawing.Size(228, 24);
            this.txtipadres.TabIndex = 60;
            this.txtipadres.Tag = "";
            // 
            // txtkullaniciadi
            // 
            this.txtkullaniciadi.EnterMoveNextControl = true;
            this.txtkullaniciadi.Location = new System.Drawing.Point(148, 70);
            this.txtkullaniciadi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtkullaniciadi.Name = "txtkullaniciadi";
            this.txtkullaniciadi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkullaniciadi.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtkullaniciadi.Properties.Appearance.Options.UseFont = true;
            this.txtkullaniciadi.Properties.Appearance.Options.UseForeColor = true;
            this.txtkullaniciadi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtkullaniciadi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtkullaniciadi.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtkullaniciadi.Size = new System.Drawing.Size(228, 24);
            this.txtkullaniciadi.TabIndex = 61;
            this.txtkullaniciadi.Tag = "";
            // 
            // FrmBaglanti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 240);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.lbldatabese);
            this.Controls.Add(this.lblsifre);
            this.Controls.Add(this.lblkullaniciadi);
            this.Controls.Add(this.lblipadresi);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.txtdatabese);
            this.Controls.Add(this.txtipadres);
            this.Controls.Add(this.txtkullaniciadi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmBaglanti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connection";
            this.Load += new System.EventHandler(this.FrmBaglanti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtsifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdatabese.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtipadres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkullaniciadi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Label lbldatabese;
        private System.Windows.Forms.Label lblsifre;
        private System.Windows.Forms.Label lblkullaniciadi;
        private System.Windows.Forms.Label lblipadresi;
        private DevExpress.XtraEditors.TextEdit txtsifre;
        private DevExpress.XtraEditors.TextEdit txtdatabese;
        private DevExpress.XtraEditors.TextEdit txtipadres;
        private DevExpress.XtraEditors.TextEdit txtkullaniciadi;
    }
}
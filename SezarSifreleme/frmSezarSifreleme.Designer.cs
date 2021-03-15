namespace SezarSifreleme
{
    partial class frmSezarSifreleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSezarSifreleme));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSifrele = new DevExpress.XtraEditors.SimpleButton();
            this.txtSifrelenmisMetin = new System.Windows.Forms.TextBox();
            this.txtSifrelenecekMetin = new System.Windows.Forms.TextBox();
            this.lblSonra = new System.Windows.Forms.Label();
            this.lblOnce = new System.Windows.Forms.Label();
            this.txtKaydirmaSayisi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDil = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelControl1.Appearance.BackColor2 = System.Drawing.Color.LightSlateGray;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.btnSifrele);
            this.panelControl1.Controls.Add(this.txtSifrelenmisMetin);
            this.panelControl1.Controls.Add(this.txtSifrelenecekMetin);
            this.panelControl1.Controls.Add(this.lblSonra);
            this.panelControl1.Controls.Add(this.lblOnce);
            this.panelControl1.Controls.Add(this.txtKaydirmaSayisi);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.cmbDil);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(735, 474);
            this.panelControl1.TabIndex = 0;
            // 
            // btnSifrele
            // 
            this.btnSifrele.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifrele.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.btnSifrele.Appearance.Options.UseFont = true;
            this.btnSifrele.Appearance.Options.UseForeColor = true;
            this.btnSifrele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSifrele.ImageOptions.Image")));
            this.btnSifrele.Location = new System.Drawing.Point(384, 190);
            this.btnSifrele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSifrele.Name = "btnSifrele";
            this.btnSifrele.Size = new System.Drawing.Size(244, 38);
            this.btnSifrele.TabIndex = 20;
            this.btnSifrele.Text = "ŞİFRELE";
            this.btnSifrele.Click += new System.EventHandler(this.btnSifrele_Click);
            // 
            // txtSifrelenmisMetin
            // 
            this.txtSifrelenmisMetin.Enabled = false;
            this.txtSifrelenmisMetin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifrelenmisMetin.ForeColor = System.Drawing.Color.Gray;
            this.txtSifrelenmisMetin.Location = new System.Drawing.Point(112, 250);
            this.txtSifrelenmisMetin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSifrelenmisMetin.Multiline = true;
            this.txtSifrelenmisMetin.Name = "txtSifrelenmisMetin";
            this.txtSifrelenmisMetin.Size = new System.Drawing.Size(515, 37);
            this.txtSifrelenmisMetin.TabIndex = 19;
            this.txtSifrelenmisMetin.Text = "Şifrelenmiş Metin";
            // 
            // txtSifrelenecekMetin
            // 
            this.txtSifrelenecekMetin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifrelenecekMetin.ForeColor = System.Drawing.Color.Gray;
            this.txtSifrelenecekMetin.Location = new System.Drawing.Point(112, 132);
            this.txtSifrelenecekMetin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSifrelenecekMetin.Multiline = true;
            this.txtSifrelenecekMetin.Name = "txtSifrelenecekMetin";
            this.txtSifrelenecekMetin.Size = new System.Drawing.Size(515, 37);
            this.txtSifrelenecekMetin.TabIndex = 18;
            this.txtSifrelenecekMetin.Text = "Şifrelenecek Metin";
            this.txtSifrelenecekMetin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSifrelenecekMetin_MouseClick);
            this.txtSifrelenecekMetin.TextChanged += new System.EventHandler(this.txtSifrelenecekMetin_TextChanged);
            // 
            // lblSonra
            // 
            this.lblSonra.AutoSize = true;
            this.lblSonra.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonra.ForeColor = System.Drawing.Color.Red;
            this.lblSonra.Location = new System.Drawing.Point(112, 368);
            this.lblSonra.Name = "lblSonra";
            this.lblSonra.Size = new System.Drawing.Size(483, 27);
            this.lblSonra.TabIndex = 17;
            this.lblSonra.Text = "a b c ç d e f g ğ h ı i j k l m n o ö p r s ş t u ü v y z";
            // 
            // lblOnce
            // 
            this.lblOnce.AutoSize = true;
            this.lblOnce.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOnce.Location = new System.Drawing.Point(112, 315);
            this.lblOnce.Name = "lblOnce";
            this.lblOnce.Size = new System.Drawing.Size(483, 27);
            this.lblOnce.TabIndex = 16;
            this.lblOnce.Text = "a b c ç d e f g ğ h ı i j k l m n o ö p r s ş t u ü v y z";
            // 
            // txtKaydirmaSayisi
            // 
            this.txtKaydirmaSayisi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKaydirmaSayisi.ForeColor = System.Drawing.Color.Gray;
            this.txtKaydirmaSayisi.Location = new System.Drawing.Point(305, 190);
            this.txtKaydirmaSayisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKaydirmaSayisi.Multiline = true;
            this.txtKaydirmaSayisi.Name = "txtKaydirmaSayisi";
            this.txtKaydirmaSayisi.Size = new System.Drawing.Size(72, 37);
            this.txtKaydirmaSayisi.TabIndex = 15;
            this.txtKaydirmaSayisi.Text = "0";
            this.txtKaydirmaSayisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(112, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 27);
            this.label2.TabIndex = 14;
            this.label2.Text = "Kaydırma Sayısı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(112, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 27);
            this.label1.TabIndex = 13;
            this.label1.Text = "Dil:";
            // 
            // cmbDil
            // 
            this.cmbDil.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDil.ForeColor = System.Drawing.Color.Gray;
            this.cmbDil.FormattingEnabled = true;
            this.cmbDil.Items.AddRange(new object[] {
            "Türkçe",
            "İngilizce"});
            this.cmbDil.Location = new System.Drawing.Point(164, 75);
            this.cmbDil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDil.Name = "cmbDil";
            this.cmbDil.Size = new System.Drawing.Size(177, 35);
            this.cmbDil.TabIndex = 11;
            this.cmbDil.SelectedIndexChanged += new System.EventHandler(this.cmbDil_SelectedIndexChanged);
            // 
            // frmSezarSifreleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 474);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmSezarSifreleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SEZAR ŞİFRELEME";
            this.Load += new System.EventHandler(this.frmSezarSifreleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSifrele;
        private System.Windows.Forms.TextBox txtSifrelenmisMetin;
        private System.Windows.Forms.TextBox txtSifrelenecekMetin;
        private System.Windows.Forms.Label lblSonra;
        private System.Windows.Forms.Label lblOnce;
        private System.Windows.Forms.TextBox txtKaydirmaSayisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDil;
    }
}


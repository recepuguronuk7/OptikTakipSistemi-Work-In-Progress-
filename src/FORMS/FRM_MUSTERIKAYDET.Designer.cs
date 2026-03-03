namespace Optik_Takip_Sistemi
{
    partial class FRM_MUSTERIKAYDET
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
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btn_musteriKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.t_adres = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.t_tcno = new DevExpress.XtraEditors.TextEdit();
            this.t_telno = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.t_soyad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.t_ad = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_adres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_tcno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_telno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_soyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_ad.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btn_musteriKaydet);
            this.groupControl2.Controls.Add(this.t_adres);
            this.groupControl2.Controls.Add(this.labelControl8);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.t_tcno);
            this.groupControl2.Controls.Add(this.t_telno);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.t_soyad);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.t_ad);
            this.groupControl2.Location = new System.Drawing.Point(14, 3);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(359, 250);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "MÜŞTERİ BİLGİLERİ";
            // 
            // btn_musteriKaydet
            // 
            this.btn_musteriKaydet.Location = new System.Drawing.Point(246, 201);
            this.btn_musteriKaydet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_musteriKaydet.Name = "btn_musteriKaydet";
            this.btn_musteriKaydet.Size = new System.Drawing.Size(88, 27);
            this.btn_musteriKaydet.TabIndex = 15;
            this.btn_musteriKaydet.Text = "Kaydet";
            this.btn_musteriKaydet.Click += new System.EventHandler(this.btn_musteriKaydet_Click);
            // 
            // t_adres
            // 
            this.t_adres.Location = new System.Drawing.Point(93, 168);
            this.t_adres.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.t_adres.Name = "t_adres";
            this.t_adres.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.t_adres.Properties.Appearance.Options.UseFont = true;
            this.t_adres.Size = new System.Drawing.Size(240, 22);
            this.t_adres.TabIndex = 14;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(20, 170);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(38, 16);
            this.labelControl8.TabIndex = 13;
            this.labelControl8.Text = "Adres:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(20, 107);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(40, 16);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "TC No:";
            // 
            // t_tcno
            // 
            this.t_tcno.Location = new System.Drawing.Point(93, 104);
            this.t_tcno.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.t_tcno.Name = "t_tcno";
            this.t_tcno.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.t_tcno.Properties.Appearance.Options.UseFont = true;
            this.t_tcno.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.t_tcno.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
            this.t_tcno.Properties.MaskSettings.Set("mask", "99999999999");
            this.t_tcno.Properties.MaskSettings.Set("ignoreMaskBlank", true);
            this.t_tcno.Size = new System.Drawing.Size(240, 22);
            this.t_tcno.TabIndex = 11;
            // 
            // t_telno
            // 
            this.t_telno.Location = new System.Drawing.Point(93, 136);
            this.t_telno.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.t_telno.Name = "t_telno";
            this.t_telno.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.t_telno.Properties.Appearance.Options.UseFont = true;
            this.t_telno.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.t_telno.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
            this.t_telno.Properties.MaskSettings.Set("mask", "000 000 00 00");
            this.t_telno.Size = new System.Drawing.Size(240, 22);
            this.t_telno.TabIndex = 7;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(20, 137);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(42, 16);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Tel No:";
            // 
            // t_soyad
            // 
            this.t_soyad.Location = new System.Drawing.Point(93, 72);
            this.t_soyad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.t_soyad.Name = "t_soyad";
            this.t_soyad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.t_soyad.Properties.Appearance.Options.UseFont = true;
            this.t_soyad.Size = new System.Drawing.Size(240, 22);
            this.t_soyad.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(20, 75);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(40, 16);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Soyad:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(20, 43);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(20, 16);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Ad:";
            // 
            // t_ad
            // 
            this.t_ad.Location = new System.Drawing.Point(93, 39);
            this.t_ad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.t_ad.Name = "t_ad";
            this.t_ad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.t_ad.Properties.Appearance.Options.UseFont = true;
            this.t_ad.Size = new System.Drawing.Size(240, 22);
            this.t_ad.TabIndex = 0;
            // 
            // FRM_MUSTERIKAYDET
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 268);
            this.Controls.Add(this.groupControl2);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FRM_MUSTERIKAYDET";
            this.Text = "FRM_MUSTERIKAYDET";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_adres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_tcno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_telno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_soyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_ad.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit t_adres;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit t_tcno;
        private DevExpress.XtraEditors.TextEdit t_telno;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit t_soyad;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit t_ad;
        private DevExpress.XtraEditors.SimpleButton btn_musteriKaydet;
    }
}
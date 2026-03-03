namespace Optik_Takip_Sistemi
{
    partial class FRM_HASTANELER
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
            this.gc_hastaneler = new DevExpress.XtraGrid.GridControl();
            this.gv_hastaneler = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clm_hastaneAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clm_sehir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clm_ilce = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clm_hastaneKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_hastaneEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btn_hastaneIptal = new DevExpress.XtraEditors.SimpleButton();
            this.btn_hastaneKaydet = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gc_hastaneler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_hastaneler)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_hastaneler
            // 
            this.gc_hastaneler.Location = new System.Drawing.Point(12, 12);
            this.gc_hastaneler.MainView = this.gv_hastaneler;
            this.gc_hastaneler.Name = "gc_hastaneler";
            this.gc_hastaneler.Size = new System.Drawing.Size(536, 369);
            this.gc_hastaneler.TabIndex = 0;
            this.gc_hastaneler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_hastaneler});
            // 
            // gv_hastaneler
            // 
            this.gv_hastaneler.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clm_hastaneAd,
            this.clm_sehir,
            this.clm_ilce,
            this.clm_hastaneKodu});
            this.gv_hastaneler.GridControl = this.gc_hastaneler;
            this.gv_hastaneler.Name = "gv_hastaneler";
            this.gv_hastaneler.OptionsBehavior.Editable = false;
            this.gv_hastaneler.OptionsNavigation.EnterMoveNextColumn = true;
            this.gv_hastaneler.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gv_hastanelerCustomDrawRowIndicator);
            this.gv_hastaneler.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gv_hastaneler_InvalidRowException);
            this.gv_hastaneler.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gv_hastaneler_ValidateRow);
            this.gv_hastaneler.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gv_hastaneler_RowUpdated);
            // 
            // clm_hastaneAd
            // 
            this.clm_hastaneAd.Caption = "Hastane Adı";
            this.clm_hastaneAd.FieldName = "HastaneAd";
            this.clm_hastaneAd.Name = "clm_hastaneAd";
            this.clm_hastaneAd.Visible = true;
            this.clm_hastaneAd.VisibleIndex = 0;
            // 
            // clm_sehir
            // 
            this.clm_sehir.Caption = "Şehir";
            this.clm_sehir.FieldName = "Sehir";
            this.clm_sehir.Name = "clm_sehir";
            this.clm_sehir.Visible = true;
            this.clm_sehir.VisibleIndex = 1;
            // 
            // clm_ilce
            // 
            this.clm_ilce.Caption = "İlçe";
            this.clm_ilce.FieldName = "Ilce";
            this.clm_ilce.Name = "clm_ilce";
            this.clm_ilce.Visible = true;
            this.clm_ilce.VisibleIndex = 2;
            // 
            // clm_hastaneKodu
            // 
            this.clm_hastaneKodu.Caption = "Hastane Kodu";
            this.clm_hastaneKodu.FieldName = "HastaneKodu";
            this.clm_hastaneKodu.Name = "clm_hastaneKodu";
            this.clm_hastaneKodu.Visible = true;
            this.clm_hastaneKodu.VisibleIndex = 3;
            // 
            // btn_hastaneEkle
            // 
            this.btn_hastaneEkle.Location = new System.Drawing.Point(12, 387);
            this.btn_hastaneEkle.Name = "btn_hastaneEkle";
            this.btn_hastaneEkle.Size = new System.Drawing.Size(75, 23);
            this.btn_hastaneEkle.TabIndex = 1;
            this.btn_hastaneEkle.Text = "Ekle";
            this.btn_hastaneEkle.Click += new System.EventHandler(this.btn_hastaneEkle_Click);
            // 
            // btn_hastaneIptal
            // 
            this.btn_hastaneIptal.CausesValidation = false;
            this.btn_hastaneIptal.Enabled = false;
            this.btn_hastaneIptal.Location = new System.Drawing.Point(392, 387);
            this.btn_hastaneIptal.Name = "btn_hastaneIptal";
            this.btn_hastaneIptal.Size = new System.Drawing.Size(75, 23);
            this.btn_hastaneIptal.TabIndex = 2;
            this.btn_hastaneIptal.Text = "İptal";
            this.btn_hastaneIptal.Click += new System.EventHandler(this.btn_hastaneIptal_Click);
            // 
            // btn_hastaneKaydet
            // 
            this.btn_hastaneKaydet.CausesValidation = false;
            this.btn_hastaneKaydet.Enabled = false;
            this.btn_hastaneKaydet.Location = new System.Drawing.Point(473, 387);
            this.btn_hastaneKaydet.Name = "btn_hastaneKaydet";
            this.btn_hastaneKaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_hastaneKaydet.TabIndex = 3;
            this.btn_hastaneKaydet.Text = "Kaydet";
            this.btn_hastaneKaydet.Click += new System.EventHandler(this.btn_hastaneKaydet_Click);
            // 
            // FRM_HASTANELER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 426);
            this.Controls.Add(this.btn_hastaneKaydet);
            this.Controls.Add(this.btn_hastaneIptal);
            this.Controls.Add(this.btn_hastaneEkle);
            this.Controls.Add(this.gc_hastaneler);
            this.Name = "FRM_HASTANELER";
            this.Text = "FRM_HASTANELER";
            this.Load += new System.EventHandler(this.FRM_HASTANELER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_hastaneler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_hastaneler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_hastaneler;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_hastaneler;
        private DevExpress.XtraGrid.Columns.GridColumn clm_hastaneAd;
        private DevExpress.XtraGrid.Columns.GridColumn clm_sehir;
        private DevExpress.XtraGrid.Columns.GridColumn clm_ilce;
        private DevExpress.XtraEditors.SimpleButton btn_hastaneEkle;
        private DevExpress.XtraEditors.SimpleButton btn_hastaneIptal;
        private DevExpress.XtraEditors.SimpleButton btn_hastaneKaydet;
        private DevExpress.XtraGrid.Columns.GridColumn clm_hastaneKodu;
    }
}
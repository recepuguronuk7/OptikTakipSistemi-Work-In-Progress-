namespace Optik_Takip_Sistemi
{
    partial class FRM_GUNLUKSATIS
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gc_gunlukSatis = new DevExpress.XtraGrid.GridControl();
            this.gv_gunlukSatis = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_barkodNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_bildirimId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_adet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_belgeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_digerKurumNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_urunTanimi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_gonderenKurumAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_satisTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.col_musteriAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_musteriSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_musteriTCNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_satisFiyati = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_gunlukSatis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_gunlukSatis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gc_gunlukSatis);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1198, 649);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gc_gunlukSatis
            // 
            this.gc_gunlukSatis.Location = new System.Drawing.Point(12, 12);
            this.gc_gunlukSatis.MainView = this.gv_gunlukSatis;
            this.gc_gunlukSatis.Name = "gc_gunlukSatis";
            this.gc_gunlukSatis.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2});
            this.gc_gunlukSatis.Size = new System.Drawing.Size(1174, 625);
            this.gc_gunlukSatis.TabIndex = 4;
            this.gc_gunlukSatis.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_gunlukSatis});
            // 
            // gv_gunlukSatis
            // 
            this.gv_gunlukSatis.Appearance.Row.Options.UseTextOptions = true;
            this.gv_gunlukSatis.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gv_gunlukSatis.Appearance.ViewCaption.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.gv_gunlukSatis.Appearance.ViewCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gv_gunlukSatis.Appearance.ViewCaption.Options.UseFont = true;
            this.gv_gunlukSatis.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_barkodNo,
            this.col_bildirimId,
            this.col_adet,
            this.col_belgeNo,
            this.col_digerKurumNo,
            this.col_urunTanimi,
            this.col_gonderenKurumAdi,
            this.col_satisTarihi,
            this.col_musteriAd,
            this.col_musteriSoyad,
            this.col_musteriTCNo,
            this.col_satisFiyati});
            this.gv_gunlukSatis.GridControl = this.gc_gunlukSatis;
            this.gv_gunlukSatis.IndicatorWidth = 40;
            this.gv_gunlukSatis.Name = "gv_gunlukSatis";
            this.gv_gunlukSatis.OptionsView.ShowFooter = true;
            this.gv_gunlukSatis.OptionsView.ShowViewCaption = true;
            this.gv_gunlukSatis.RowHeight = 35;
            this.gv_gunlukSatis.ViewCaption = "BUGÜN YAPILAN SATIŞLAR";
            this.gv_gunlukSatis.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gv_gunlukSatis_CustomDrawRowIndicator);
            // 
            // col_barkodNo
            // 
            this.col_barkodNo.Caption = "Barkod No";
            this.col_barkodNo.FieldName = "barkodNo";
            this.col_barkodNo.Name = "col_barkodNo";
            this.col_barkodNo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "barkodNo", "{0}")});
            this.col_barkodNo.Visible = true;
            this.col_barkodNo.VisibleIndex = 1;
            this.col_barkodNo.Width = 86;
            // 
            // col_bildirimId
            // 
            this.col_bildirimId.Caption = "Bildirim No";
            this.col_bildirimId.FieldName = "BildirimId";
            this.col_bildirimId.Name = "col_bildirimId";
            this.col_bildirimId.Width = 96;
            // 
            // col_adet
            // 
            this.col_adet.Caption = "Adet";
            this.col_adet.FieldName = "adet";
            this.col_adet.Name = "col_adet";
            this.col_adet.Visible = true;
            this.col_adet.VisibleIndex = 2;
            this.col_adet.Width = 71;
            // 
            // col_belgeNo
            // 
            this.col_belgeNo.Caption = "Belge No";
            this.col_belgeNo.FieldName = "BelgeNo";
            this.col_belgeNo.Name = "col_belgeNo";
            this.col_belgeNo.Width = 96;
            // 
            // col_digerKurumNo
            // 
            this.col_digerKurumNo.Caption = "Gönderen Kurum No";
            this.col_digerKurumNo.FieldName = "DigerKurumNo";
            this.col_digerKurumNo.Name = "col_digerKurumNo";
            this.col_digerKurumNo.Width = 165;
            // 
            // col_urunTanimi
            // 
            this.col_urunTanimi.Caption = "Ürün Tanımı";
            this.col_urunTanimi.FieldName = "urunTanimi";
            this.col_urunTanimi.Name = "col_urunTanimi";
            this.col_urunTanimi.Visible = true;
            this.col_urunTanimi.VisibleIndex = 0;
            this.col_urunTanimi.Width = 139;
            // 
            // col_gonderenKurumAdi
            // 
            this.col_gonderenKurumAdi.Caption = "Gönderen Kurum Adı";
            this.col_gonderenKurumAdi.FieldName = "gonderenKurumAdi";
            this.col_gonderenKurumAdi.Name = "col_gonderenKurumAdi";
            this.col_gonderenKurumAdi.Visible = true;
            this.col_gonderenKurumAdi.VisibleIndex = 3;
            this.col_gonderenKurumAdi.Width = 139;
            // 
            // col_satisTarihi
            // 
            this.col_satisTarihi.Caption = "SatisTarihi";
            this.col_satisTarihi.ColumnEdit = this.repositoryItemTextEdit1;
            this.col_satisTarihi.FieldName = "satisTarihi";
            this.col_satisTarihi.Name = "col_satisTarihi";
            this.col_satisTarihi.Visible = true;
            this.col_satisTarihi.VisibleIndex = 7;
            this.col_satisTarihi.Width = 139;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.DateTimeMaskManager));
            this.repositoryItemTextEdit1.MaskSettings.Set("mask", "G");
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.repositoryItemTextEdit1.UseMaskAsDisplayFormat = true;
            // 
            // col_musteriAd
            // 
            this.col_musteriAd.Caption = "Müşteri Adı";
            this.col_musteriAd.FieldName = "musteriAd";
            this.col_musteriAd.Name = "col_musteriAd";
            this.col_musteriAd.Visible = true;
            this.col_musteriAd.VisibleIndex = 4;
            this.col_musteriAd.Width = 139;
            // 
            // col_musteriSoyad
            // 
            this.col_musteriSoyad.Caption = "Müşteri Soyad";
            this.col_musteriSoyad.FieldName = "musteriSoyad";
            this.col_musteriSoyad.Name = "col_musteriSoyad";
            this.col_musteriSoyad.Visible = true;
            this.col_musteriSoyad.VisibleIndex = 5;
            this.col_musteriSoyad.Width = 139;
            // 
            // col_musteriTCNo
            // 
            this.col_musteriTCNo.Caption = "Müşteri TC No";
            this.col_musteriTCNo.FieldName = "musteriTCNo";
            this.col_musteriTCNo.Name = "col_musteriTCNo";
            this.col_musteriTCNo.Visible = true;
            this.col_musteriTCNo.VisibleIndex = 6;
            this.col_musteriTCNo.Width = 139;
            // 
            // col_satisFiyati
            // 
            this.col_satisFiyati.Caption = "Satış Fiyatı";
            this.col_satisFiyati.ColumnEdit = this.repositoryItemTextEdit2;
            this.col_satisFiyati.FieldName = "satisFiyati";
            this.col_satisFiyati.Name = "col_satisFiyati";
            this.col_satisFiyati.Visible = true;
            this.col_satisFiyati.VisibleIndex = 8;
            this.col_satisFiyati.Width = 165;
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.repositoryItemTextEdit2.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.repositoryItemTextEdit2.MaskSettings.Set("mask", "c2");
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            this.repositoryItemTextEdit2.UseMaskAsDisplayFormat = true;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1198, 649);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gc_gunlukSatis;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1178, 629);
            this.layoutControlItem1.TextVisible = false;
            // 
            // FRM_GUNLUKSATIS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 649);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FRM_GUNLUKSATIS";
            this.Text = "FRM_GUNLUKSATIS";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_gunlukSatis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_gunlukSatis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gc_gunlukSatis;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_gunlukSatis;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn col_barkodNo;
        private DevExpress.XtraGrid.Columns.GridColumn col_bildirimId;
        private DevExpress.XtraGrid.Columns.GridColumn col_adet;
        private DevExpress.XtraGrid.Columns.GridColumn col_belgeNo;
        private DevExpress.XtraGrid.Columns.GridColumn col_digerKurumNo;
        private DevExpress.XtraGrid.Columns.GridColumn col_urunTanimi;
        private DevExpress.XtraGrid.Columns.GridColumn col_gonderenKurumAdi;
        private DevExpress.XtraGrid.Columns.GridColumn col_satisTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn col_musteriAd;
        private DevExpress.XtraGrid.Columns.GridColumn col_musteriSoyad;
        private DevExpress.XtraGrid.Columns.GridColumn col_musteriTCNo;
        private DevExpress.XtraGrid.Columns.GridColumn col_satisFiyati;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
    }
}
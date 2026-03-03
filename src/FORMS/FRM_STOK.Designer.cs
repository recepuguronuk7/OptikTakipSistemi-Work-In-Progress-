namespace Optik_Takip_Sistemi
{
    partial class FRM_STOK
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
            this.gc_stok = new DevExpress.XtraGrid.GridControl();
            this.gv_stok = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_urunAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_gonderenKurumAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_gonderenKurumNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_bildirimId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_lotBatchNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_seriNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_adet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_belgeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_bildirimZamani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.col_stokEklenmeTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.col_barkodNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_stok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_stok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gc_stok);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1195, 626);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gc_stok
            // 
            this.gc_stok.Location = new System.Drawing.Point(12, 12);
            this.gc_stok.MainView = this.gv_stok;
            this.gc_stok.Name = "gc_stok";
            this.gc_stok.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2});
            this.gc_stok.Size = new System.Drawing.Size(1171, 602);
            this.gc_stok.TabIndex = 4;
            this.gc_stok.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_stok});
            // 
            // gv_stok
            // 
            this.gv_stok.Appearance.Row.Options.UseTextOptions = true;
            this.gv_stok.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gv_stok.Appearance.ViewCaption.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.gv_stok.Appearance.ViewCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gv_stok.Appearance.ViewCaption.Options.UseFont = true;
            this.gv_stok.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_urunAdi,
            this.col_gonderenKurumAdi,
            this.col_gonderenKurumNo,
            this.col_bildirimId,
            this.col_lotBatchNo,
            this.col_seriNo,
            this.col_adet,
            this.col_belgeNo,
            this.col_bildirimZamani,
            this.col_stokEklenmeTarihi,
            this.col_barkodNo});
            this.gv_stok.GridControl = this.gc_stok;
            this.gv_stok.IndicatorWidth = 40;
            this.gv_stok.Name = "gv_stok";
            this.gv_stok.OptionsView.ShowViewCaption = true;
            this.gv_stok.RowHeight = 35;
            this.gv_stok.ViewCaption = "Stokta Bulunan Ürünler";
            this.gv_stok.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gv_stok_CustomDrawRowIndicator);
            // 
            // col_urunAdi
            // 
            this.col_urunAdi.Caption = "Ürün Tanımı";
            this.col_urunAdi.FieldName = "UrunTanimi";
            this.col_urunAdi.Name = "col_urunAdi";
            this.col_urunAdi.Visible = true;
            this.col_urunAdi.VisibleIndex = 0;
            // 
            // col_gonderenKurumAdi
            // 
            this.col_gonderenKurumAdi.Caption = "Gönderen Kurum Adı";
            this.col_gonderenKurumAdi.FieldName = "GonderenKurumAdi";
            this.col_gonderenKurumAdi.Name = "col_gonderenKurumAdi";
            this.col_gonderenKurumAdi.Visible = true;
            this.col_gonderenKurumAdi.VisibleIndex = 1;
            // 
            // col_gonderenKurumNo
            // 
            this.col_gonderenKurumNo.Caption = "Gönderen Kurum No";
            this.col_gonderenKurumNo.FieldName = "GonderenKurumNo";
            this.col_gonderenKurumNo.Name = "col_gonderenKurumNo";
            // 
            // col_bildirimId
            // 
            this.col_bildirimId.Caption = "Bildirim No";
            this.col_bildirimId.FieldName = "BildirimId";
            this.col_bildirimId.Name = "col_bildirimId";
            // 
            // col_lotBatchNo
            // 
            this.col_lotBatchNo.Caption = "Lot/Batch No";
            this.col_lotBatchNo.FieldName = "LotBatchNo";
            this.col_lotBatchNo.Name = "col_lotBatchNo";
            // 
            // col_seriNo
            // 
            this.col_seriNo.Caption = "Seri No";
            this.col_seriNo.FieldName = "SeriNo";
            this.col_seriNo.Name = "col_seriNo";
            // 
            // col_adet
            // 
            this.col_adet.Caption = "Adet";
            this.col_adet.FieldName = "Adet";
            this.col_adet.Name = "col_adet";
            this.col_adet.Visible = true;
            this.col_adet.VisibleIndex = 2;
            // 
            // col_belgeNo
            // 
            this.col_belgeNo.Caption = "Belge No";
            this.col_belgeNo.FieldName = "BelgeNo";
            this.col_belgeNo.Name = "col_belgeNo";
            // 
            // col_bildirimZamani
            // 
            this.col_bildirimZamani.Caption = "Bildirim Tarihi";
            this.col_bildirimZamani.ColumnEdit = this.repositoryItemTextEdit1;
            this.col_bildirimZamani.FieldName = "BildirimZamani";
            this.col_bildirimZamani.Name = "col_bildirimZamani";
            this.col_bildirimZamani.Visible = true;
            this.col_bildirimZamani.VisibleIndex = 3;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.DateTimeMaskManager));
            this.repositoryItemTextEdit1.MaskSettings.Set("mask", "G");
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.repositoryItemTextEdit1.UseMaskAsDisplayFormat = true;
            // 
            // col_stokEklenmeTarihi
            // 
            this.col_stokEklenmeTarihi.Caption = "Stok Eklenme Tarihi";
            this.col_stokEklenmeTarihi.ColumnEdit = this.repositoryItemTextEdit2;
            this.col_stokEklenmeTarihi.FieldName = "StokEklenmeTarihi";
            this.col_stokEklenmeTarihi.Name = "col_stokEklenmeTarihi";
            this.col_stokEklenmeTarihi.Visible = true;
            this.col_stokEklenmeTarihi.VisibleIndex = 4;
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.DateTimeMaskManager));
            this.repositoryItemTextEdit2.MaskSettings.Set("mask", "G");
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            this.repositoryItemTextEdit2.UseMaskAsDisplayFormat = true;
            // 
            // col_barkodNo
            // 
            this.col_barkodNo.Caption = "Barkod No";
            this.col_barkodNo.FieldName = "BarkodNo";
            this.col_barkodNo.Name = "col_barkodNo";
            this.col_barkodNo.Visible = true;
            this.col_barkodNo.VisibleIndex = 5;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1195, 626);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gc_stok;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1175, 606);
            this.layoutControlItem1.TextVisible = false;
            // 
            // FRM_STOK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 626);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FRM_STOK";
            this.Text = "FRM_STOK";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_stok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_stok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gc_stok;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_stok;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn col_urunAdi;
        private DevExpress.XtraGrid.Columns.GridColumn col_gonderenKurumAdi;
        private DevExpress.XtraGrid.Columns.GridColumn col_gonderenKurumNo;
        private DevExpress.XtraGrid.Columns.GridColumn col_bildirimId;
        private DevExpress.XtraGrid.Columns.GridColumn col_lotBatchNo;
        private DevExpress.XtraGrid.Columns.GridColumn col_seriNo;
        private DevExpress.XtraGrid.Columns.GridColumn col_adet;
        private DevExpress.XtraGrid.Columns.GridColumn col_belgeNo;
        private DevExpress.XtraGrid.Columns.GridColumn col_bildirimZamani;
        private DevExpress.XtraGrid.Columns.GridColumn col_stokEklenmeTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn col_barkodNo;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
    }
}
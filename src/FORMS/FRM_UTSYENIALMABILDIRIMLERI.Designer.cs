namespace Optik_Takip_Sistemi
{
    partial class FRM_UTSYENIALMABILDIRIMLERI
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_UTSYENIALMABILDIRIMLERI));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.che_hepsiniSec = new DevExpress.XtraEditors.CheckEdit();
            this.gc_UTSListesi = new DevExpress.XtraGrid.GridControl();
            this.gv_UTSListesi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_UrunNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_gonderenKurumNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_bildirimId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_LotNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_seriNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_urunAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_gonderenKurumAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Adet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_belgeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_bildirimDurumu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_bildirimZamani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.col_VermeTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_secim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.btn_iptal = new DevExpress.XtraEditors.SimpleButton();
            this.btn_urunleriAl = new DevExpress.XtraEditors.SimpleButton();
            this.btn_UTSAlmaVeriGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.che_hepsiniSec.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_UTSListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_UTSListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.che_hepsiniSec);
            this.layoutControl1.Controls.Add(this.gc_UTSListesi);
            this.layoutControl1.Controls.Add(this.btn_iptal);
            this.layoutControl1.Controls.Add(this.btn_urunleriAl);
            this.layoutControl1.Controls.Add(this.btn_UTSAlmaVeriGuncelle);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1390, 868);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // che_hepsiniSec
            // 
            this.che_hepsiniSec.Location = new System.Drawing.Point(12, 52);
            this.che_hepsiniSec.Name = "che_hepsiniSec";
            this.che_hepsiniSec.Properties.Caption = " Tüm Ürünleri Seç";
            this.che_hepsiniSec.Size = new System.Drawing.Size(299, 19);
            this.che_hepsiniSec.StyleController = this.layoutControl1;
            this.che_hepsiniSec.TabIndex = 8;
            this.che_hepsiniSec.CheckedChanged += new System.EventHandler(this.che_hepsiniSec_CheckedChanged);
            // 
            // gc_UTSListesi
            // 
            gridLevelNode1.RelationName = "Level1";
            this.gc_UTSListesi.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gc_UTSListesi.Location = new System.Drawing.Point(12, 75);
            this.gc_UTSListesi.MainView = this.gv_UTSListesi;
            this.gc_UTSListesi.Name = "gc_UTSListesi";
            this.gc_UTSListesi.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemTextEdit1});
            this.gc_UTSListesi.Size = new System.Drawing.Size(1366, 781);
            this.gc_UTSListesi.TabIndex = 7;
            this.gc_UTSListesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_UTSListesi});
            // 
            // gv_UTSListesi
            // 
            this.gv_UTSListesi.Appearance.Row.Options.UseTextOptions = true;
            this.gv_UTSListesi.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gv_UTSListesi.Appearance.ViewCaption.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.gv_UTSListesi.Appearance.ViewCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gv_UTSListesi.Appearance.ViewCaption.Options.UseFont = true;
            this.gv_UTSListesi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_UrunNo,
            this.col_gonderenKurumNo,
            this.col_bildirimId,
            this.col_LotNo,
            this.col_seriNo,
            this.col_urunAdi,
            this.col_gonderenKurumAdi,
            this.col_Adet,
            this.col_belgeNo,
            this.col_bildirimDurumu,
            this.col_bildirimZamani,
            this.col_VermeTarihi,
            this.col_secim});
            this.gv_UTSListesi.GridControl = this.gc_UTSListesi;
            this.gv_UTSListesi.IndicatorWidth = 40;
            this.gv_UTSListesi.Name = "gv_UTSListesi";
            this.gv_UTSListesi.OptionsView.ShowGroupedColumns = true;
            this.gv_UTSListesi.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.gv_UTSListesi.OptionsView.ShowViewCaption = true;
            this.gv_UTSListesi.RowHeight = 35;
            this.gv_UTSListesi.ViewCaption = "UTS ALMA BİLDİRİMLERİ ONAY BEKLEYEN ÜRÜNLER";
            this.gv_UTSListesi.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gv_UTSListesi_CustomDrawRowIndicator);
            this.gv_UTSListesi.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gv_UTSListesi_CustomUnboundColumnData);
            // 
            // col_UrunNo
            // 
            this.col_UrunNo.Caption = "Ürün No";
            this.col_UrunNo.FieldName = "UrunNo";
            this.col_UrunNo.Name = "col_UrunNo";
            this.col_UrunNo.OptionsColumn.ReadOnly = true;
            this.col_UrunNo.Visible = true;
            this.col_UrunNo.VisibleIndex = 1;
            this.col_UrunNo.Width = 129;
            // 
            // col_gonderenKurumNo
            // 
            this.col_gonderenKurumNo.Caption = "Gönderen Kurum No";
            this.col_gonderenKurumNo.FieldName = "GonderenKurumNo";
            this.col_gonderenKurumNo.Name = "col_gonderenKurumNo";
            this.col_gonderenKurumNo.OptionsColumn.ReadOnly = true;
            this.col_gonderenKurumNo.Visible = true;
            this.col_gonderenKurumNo.VisibleIndex = 2;
            this.col_gonderenKurumNo.Width = 143;
            // 
            // col_bildirimId
            // 
            this.col_bildirimId.Caption = "Bildirim No";
            this.col_bildirimId.FieldName = "BildirimId";
            this.col_bildirimId.Name = "col_bildirimId";
            this.col_bildirimId.OptionsColumn.ReadOnly = true;
            this.col_bildirimId.Visible = true;
            this.col_bildirimId.VisibleIndex = 3;
            this.col_bildirimId.Width = 134;
            // 
            // col_LotNo
            // 
            this.col_LotNo.Caption = "Lot/Batch No";
            this.col_LotNo.FieldName = "LotBatchNo";
            this.col_LotNo.Name = "col_LotNo";
            this.col_LotNo.OptionsColumn.ReadOnly = true;
            this.col_LotNo.Visible = true;
            this.col_LotNo.VisibleIndex = 4;
            this.col_LotNo.Width = 87;
            // 
            // col_seriNo
            // 
            this.col_seriNo.Caption = "SeriNo";
            this.col_seriNo.FieldName = "SeriNo";
            this.col_seriNo.Name = "col_seriNo";
            this.col_seriNo.OptionsColumn.ReadOnly = true;
            this.col_seriNo.Visible = true;
            this.col_seriNo.VisibleIndex = 5;
            this.col_seriNo.Width = 71;
            // 
            // col_urunAdi
            // 
            this.col_urunAdi.Caption = "Ürün Tanımı";
            this.col_urunAdi.FieldName = "UrunTanimi";
            this.col_urunAdi.Name = "col_urunAdi";
            this.col_urunAdi.OptionsColumn.ReadOnly = true;
            this.col_urunAdi.Visible = true;
            this.col_urunAdi.VisibleIndex = 6;
            this.col_urunAdi.Width = 190;
            // 
            // col_gonderenKurumAdi
            // 
            this.col_gonderenKurumAdi.Caption = "Gönderen Kurum Adı";
            this.col_gonderenKurumAdi.FieldName = "GonderenKurumAdi";
            this.col_gonderenKurumAdi.Name = "col_gonderenKurumAdi";
            this.col_gonderenKurumAdi.OptionsColumn.ReadOnly = true;
            this.col_gonderenKurumAdi.Visible = true;
            this.col_gonderenKurumAdi.VisibleIndex = 7;
            this.col_gonderenKurumAdi.Width = 164;
            // 
            // col_Adet
            // 
            this.col_Adet.Caption = "Adet";
            this.col_Adet.FieldName = "Adet";
            this.col_Adet.Name = "col_Adet";
            this.col_Adet.OptionsColumn.ReadOnly = true;
            this.col_Adet.Visible = true;
            this.col_Adet.VisibleIndex = 8;
            this.col_Adet.Width = 35;
            // 
            // col_belgeNo
            // 
            this.col_belgeNo.Caption = "Belge No";
            this.col_belgeNo.FieldName = "BelgeNo";
            this.col_belgeNo.Name = "col_belgeNo";
            this.col_belgeNo.OptionsColumn.ReadOnly = true;
            this.col_belgeNo.Visible = true;
            this.col_belgeNo.VisibleIndex = 9;
            this.col_belgeNo.Width = 91;
            // 
            // col_bildirimDurumu
            // 
            this.col_bildirimDurumu.Caption = "Bildirim Durumu";
            this.col_bildirimDurumu.FieldName = "BildirimDurumu";
            this.col_bildirimDurumu.Name = "col_bildirimDurumu";
            this.col_bildirimDurumu.OptionsColumn.ReadOnly = true;
            this.col_bildirimDurumu.Visible = true;
            this.col_bildirimDurumu.VisibleIndex = 10;
            this.col_bildirimDurumu.Width = 71;
            // 
            // col_bildirimZamani
            // 
            this.col_bildirimZamani.Caption = "Bildirim Zamanı";
            this.col_bildirimZamani.ColumnEdit = this.repositoryItemTextEdit1;
            this.col_bildirimZamani.FieldName = "BildirimZamani";
            this.col_bildirimZamani.Name = "col_bildirimZamani";
            this.col_bildirimZamani.OptionsColumn.ReadOnly = true;
            this.col_bildirimZamani.Visible = true;
            this.col_bildirimZamani.VisibleIndex = 11;
            this.col_bildirimZamani.Width = 88;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.DateTimeMaskManager));
            this.repositoryItemTextEdit1.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.repositoryItemTextEdit1.MaskSettings.Set("mask", "G");
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.repositoryItemTextEdit1.UseMaskAsDisplayFormat = true;
            // 
            // col_VermeTarihi
            // 
            this.col_VermeTarihi.Caption = "Verme Tarihi";
            this.col_VermeTarihi.FieldName = "VermeTarihi";
            this.col_VermeTarihi.Name = "col_VermeTarihi";
            this.col_VermeTarihi.OptionsColumn.ReadOnly = true;
            this.col_VermeTarihi.Visible = true;
            this.col_VermeTarihi.VisibleIndex = 12;
            this.col_VermeTarihi.Width = 78;
            // 
            // col_secim
            // 
            this.col_secim.Caption = "Seçim";
            this.col_secim.ColumnEdit = this.repositoryItemCheckEdit1;
            this.col_secim.FieldName = "secim";
            this.col_secim.Name = "col_secim";
            this.col_secim.UnboundDataType = typeof(bool);
            this.col_secim.Visible = true;
            this.col_secim.VisibleIndex = 0;
            this.col_secim.Width = 67;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.EditValueChanged += new System.EventHandler(this.repositoryItemCheckEdit1_EditValueChanged);
            // 
            // btn_iptal
            // 
            this.btn_iptal.Appearance.Font = new System.Drawing.Font("Arial", 12F);
            this.btn_iptal.Appearance.Options.UseFont = true;
            this.btn_iptal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_iptal.ImageOptions.Image")));
            this.btn_iptal.Location = new System.Drawing.Point(847, 12);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(267, 36);
            this.btn_iptal.StyleController = this.layoutControl1;
            this.btn_iptal.TabIndex = 6;
            this.btn_iptal.Text = "Ürünleri İptal Et";
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // btn_urunleriAl
            // 
            this.btn_urunleriAl.Appearance.Font = new System.Drawing.Font("Arial", 12F);
            this.btn_urunleriAl.Appearance.Options.UseFont = true;
            this.btn_urunleriAl.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_urunleriAl.ImageOptions.Image")));
            this.btn_urunleriAl.Location = new System.Drawing.Point(1118, 12);
            this.btn_urunleriAl.Name = "btn_urunleriAl";
            this.btn_urunleriAl.Size = new System.Drawing.Size(260, 36);
            this.btn_urunleriAl.StyleController = this.layoutControl1;
            this.btn_urunleriAl.TabIndex = 5;
            this.btn_urunleriAl.Text = "Ürünleri Al";
            this.btn_urunleriAl.Click += new System.EventHandler(this.btn_urunleriAl_Click);
            // 
            // btn_UTSAlmaVeriGuncelle
            // 
            this.btn_UTSAlmaVeriGuncelle.Appearance.Font = new System.Drawing.Font("Arial", 12F);
            this.btn_UTSAlmaVeriGuncelle.Appearance.Options.UseFont = true;
            this.btn_UTSAlmaVeriGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_UTSAlmaVeriGuncelle.ImageOptions.Image")));
            this.btn_UTSAlmaVeriGuncelle.Location = new System.Drawing.Point(12, 12);
            this.btn_UTSAlmaVeriGuncelle.Name = "btn_UTSAlmaVeriGuncelle";
            this.btn_UTSAlmaVeriGuncelle.Size = new System.Drawing.Size(341, 36);
            this.btn_UTSAlmaVeriGuncelle.StyleController = this.layoutControl1;
            this.btn_UTSAlmaVeriGuncelle.TabIndex = 4;
            this.btn_UTSAlmaVeriGuncelle.Text = "UTS\'den Alma Bildirimlerini Güncelle";
            this.btn_UTSAlmaVeriGuncelle.Click += new System.EventHandler(this.btn_UTSAlmaVeriGuncelle_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem2,
            this.emptySpaceItem2,
            this.layoutControlItem4,
            this.emptySpaceItem1,
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1390, 868);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btn_UTSAlmaVeriGuncelle;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(0, 40);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(207, 40);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(345, 40);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btn_iptal;
            this.layoutControlItem3.Location = new System.Drawing.Point(835, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(0, 40);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(94, 40);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(271, 40);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btn_urunleriAl;
            this.layoutControlItem2.Location = new System.Drawing.Point(1106, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(0, 40);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(69, 40);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(264, 40);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.Location = new System.Drawing.Point(345, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(490, 40);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.gc_UTSListesi;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 63);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(1370, 785);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.Location = new System.Drawing.Point(303, 40);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(1067, 23);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.che_hepsiniSec;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(303, 23);
            this.layoutControlItem5.TextVisible = false;
            // 
            // FRM_UTSYENIALMABILDIRIMLERI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 868);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FRM_UTSYENIALMABILDIRIMLERI";
            this.Text = "FRM_UTSYENIALMABILDIRIMLERI";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.che_hepsiniSec.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_UTSListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_UTSListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton btn_iptal;
        private DevExpress.XtraEditors.SimpleButton btn_urunleriAl;
        private DevExpress.XtraEditors.SimpleButton btn_UTSAlmaVeriGuncelle;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraGrid.GridControl gc_UTSListesi;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_UTSListesi;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.Columns.GridColumn col_UrunNo;
        private DevExpress.XtraGrid.Columns.GridColumn col_gonderenKurumNo;
        private DevExpress.XtraGrid.Columns.GridColumn col_bildirimId;
        private DevExpress.XtraGrid.Columns.GridColumn col_LotNo;
        private DevExpress.XtraGrid.Columns.GridColumn col_seriNo;
        private DevExpress.XtraGrid.Columns.GridColumn col_urunAdi;
        private DevExpress.XtraGrid.Columns.GridColumn col_gonderenKurumAdi;
        private DevExpress.XtraGrid.Columns.GridColumn col_Adet;
        private DevExpress.XtraGrid.Columns.GridColumn col_belgeNo;
        private DevExpress.XtraGrid.Columns.GridColumn col_bildirimDurumu;
        private DevExpress.XtraGrid.Columns.GridColumn col_bildirimZamani;
        private DevExpress.XtraGrid.Columns.GridColumn col_VermeTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn col_secim;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.CheckEdit che_hepsiniSec;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}
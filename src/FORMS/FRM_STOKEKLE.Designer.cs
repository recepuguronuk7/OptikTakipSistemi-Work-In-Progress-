namespace Optik_Takip_Sistemi
{
    partial class FRM_STOKEKLE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_STOKEKLE));
            this.t_barkodNo = new DevExpress.XtraEditors.TextEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_stokKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btn_UTSveriCek = new DevExpress.XtraEditors.SimpleButton();
            this.gc_UTSListesi = new DevExpress.XtraGrid.GridControl();
            this.gv_UTSListesi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_lotNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_urunBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_urunAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_bildirimZamani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.col_adet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_onaylama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.col_bildirimKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_GonderenKurumNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_belgeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_gonderenKurum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_seriNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.btn_urunSec = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btn_kaydet = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.t_barkodNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_UTSListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_UTSListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // t_barkodNo
            // 
            this.t_barkodNo.Location = new System.Drawing.Point(97, 12);
            this.t_barkodNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.t_barkodNo.Name = "t_barkodNo";
            this.t_barkodNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            this.t_barkodNo.Properties.Appearance.Options.UseFont = true;
            this.t_barkodNo.Size = new System.Drawing.Size(509, 36);
            this.t_barkodNo.StyleController = this.layoutControl1;
            this.t_barkodNo.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Controls.Add(this.btn_stokKaydet);
            this.layoutControl1.Controls.Add(this.btn_UTSveriCek);
            this.layoutControl1.Controls.Add(this.gc_UTSListesi);
            this.layoutControl1.Controls.Add(this.t_barkodNo);
            this.layoutControl1.Controls.Add(this.btn_urunSec);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(2742, 223, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1590, 868);
            this.layoutControl1.TabIndex = 7;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Arial", 12F);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(610, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(140, 36);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "Barkod Oku";
            // 
            // btn_stokKaydet
            // 
            this.btn_stokKaydet.Appearance.Font = new System.Drawing.Font("Arial", 12F);
            this.btn_stokKaydet.Appearance.Options.UseFont = true;
            this.btn_stokKaydet.Location = new System.Drawing.Point(1348, 820);
            this.btn_stokKaydet.Name = "btn_stokKaydet";
            this.btn_stokKaydet.Size = new System.Drawing.Size(230, 36);
            this.btn_stokKaydet.StyleController = this.layoutControl1;
            this.btn_stokKaydet.TabIndex = 7;
            this.btn_stokKaydet.Text = "Stoğa Kaydet";
            this.btn_stokKaydet.Click += new System.EventHandler(this.btn_stokKaydet_Click);
            // 
            // btn_UTSveriCek
            // 
            this.btn_UTSveriCek.Appearance.Font = new System.Drawing.Font("Arial", 12F);
            this.btn_UTSveriCek.Appearance.Options.UseFont = true;
            this.btn_UTSveriCek.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_UTSveriCek.ImageOptions.Image")));
            this.btn_UTSveriCek.Location = new System.Drawing.Point(1330, 12);
            this.btn_UTSveriCek.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_UTSveriCek.Name = "btn_UTSveriCek";
            this.btn_UTSveriCek.Size = new System.Drawing.Size(248, 36);
            this.btn_UTSveriCek.StyleController = this.layoutControl1;
            this.btn_UTSveriCek.TabIndex = 6;
            this.btn_UTSveriCek.Text = "UTS Alınan Ürünleri Getir";
            this.btn_UTSveriCek.Click += new System.EventHandler(this.btn_UTSveriCek_Click);
            // 
            // gc_UTSListesi
            // 
            this.gc_UTSListesi.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gc_UTSListesi.Location = new System.Drawing.Point(12, 65);
            this.gc_UTSListesi.MainView = this.gv_UTSListesi;
            this.gc_UTSListesi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gc_UTSListesi.Name = "gc_UTSListesi";
            this.gc_UTSListesi.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit2,
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2});
            this.gc_UTSListesi.Size = new System.Drawing.Size(1566, 751);
            this.gc_UTSListesi.TabIndex = 4;
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
            this.col_lotNo,
            this.col_urunBarkod,
            this.col_urunAd,
            this.col_bildirimZamani,
            this.col_adet,
            this.col_onaylama,
            this.col_bildirimKodu,
            this.col_GonderenKurumNo,
            this.col_belgeNo,
            this.col_gonderenKurum,
            this.col_seriNo});
            this.gv_UTSListesi.DetailHeight = 404;
            this.gv_UTSListesi.GridControl = this.gc_UTSListesi;
            this.gv_UTSListesi.IndicatorWidth = 40;
            this.gv_UTSListesi.Name = "gv_UTSListesi";
            this.gv_UTSListesi.OptionsEditForm.PopupEditFormWidth = 933;
            this.gv_UTSListesi.OptionsView.ShowGroupedColumns = true;
            this.gv_UTSListesi.OptionsView.ShowViewCaption = true;
            this.gv_UTSListesi.RowHeight = 35;
            this.gv_UTSListesi.ViewCaption = "UTS ALMA BİLDİRİMİ ONAYLANMIŞ ÜRÜNLER";
            this.gv_UTSListesi.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gv_UTSListesi_CustomDrawRowIndicator);
            this.gv_UTSListesi.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gv_UTSListesi_RowStyle);
            this.gv_UTSListesi.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gv_UTSListesi_CustomUnboundColumnData);
            // 
            // col_lotNo
            // 
            this.col_lotNo.Caption = "Lot/Batch No";
            this.col_lotNo.FieldName = "LotBatchNo";
            this.col_lotNo.Name = "col_lotNo";
            this.col_lotNo.Visible = true;
            this.col_lotNo.VisibleIndex = 3;
            this.col_lotNo.Width = 96;
            // 
            // col_urunBarkod
            // 
            this.col_urunBarkod.Caption = "Ürün Barkodu";
            this.col_urunBarkod.FieldName = "BarkodNo";
            this.col_urunBarkod.MinWidth = 23;
            this.col_urunBarkod.Name = "col_urunBarkod";
            this.col_urunBarkod.OptionsColumn.ReadOnly = true;
            this.col_urunBarkod.UnboundDataType = typeof(string);
            this.col_urunBarkod.Visible = true;
            this.col_urunBarkod.VisibleIndex = 0;
            this.col_urunBarkod.Width = 192;
            // 
            // col_urunAd
            // 
            this.col_urunAd.Caption = "Ürün Tanımı";
            this.col_urunAd.FieldName = "UrunTanimi";
            this.col_urunAd.MinWidth = 23;
            this.col_urunAd.Name = "col_urunAd";
            this.col_urunAd.OptionsColumn.ReadOnly = true;
            this.col_urunAd.Visible = true;
            this.col_urunAd.VisibleIndex = 5;
            this.col_urunAd.Width = 185;
            // 
            // col_bildirimZamani
            // 
            this.col_bildirimZamani.Caption = "Bildirim Zamanı";
            this.col_bildirimZamani.ColumnEdit = this.repositoryItemTextEdit2;
            this.col_bildirimZamani.FieldName = "OlusturulmaTarihi";
            this.col_bildirimZamani.MinWidth = 23;
            this.col_bildirimZamani.Name = "col_bildirimZamani";
            this.col_bildirimZamani.OptionsColumn.ReadOnly = true;
            this.col_bildirimZamani.Visible = true;
            this.col_bildirimZamani.VisibleIndex = 9;
            this.col_bildirimZamani.Width = 97;
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.DateTimeMaskManager));
            this.repositoryItemTextEdit2.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.repositoryItemTextEdit2.MaskSettings.Set("mask", "G");
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            this.repositoryItemTextEdit2.UseMaskAsDisplayFormat = true;
            // 
            // col_adet
            // 
            this.col_adet.Caption = "Adet";
            this.col_adet.FieldName = "Adet";
            this.col_adet.MinWidth = 23;
            this.col_adet.Name = "col_adet";
            this.col_adet.OptionsColumn.ReadOnly = true;
            this.col_adet.Visible = true;
            this.col_adet.VisibleIndex = 7;
            this.col_adet.Width = 45;
            // 
            // col_onaylama
            // 
            this.col_onaylama.Caption = "İşlem Durumu";
            this.col_onaylama.ColumnEdit = this.repositoryItemCheckEdit2;
            this.col_onaylama.FieldName = "UTSDurum";
            this.col_onaylama.MinWidth = 23;
            this.col_onaylama.Name = "col_onaylama";
            this.col_onaylama.OptionsColumn.ReadOnly = true;
            this.col_onaylama.UnboundDataType = typeof(int);
            this.col_onaylama.Visible = true;
            this.col_onaylama.VisibleIndex = 10;
            this.col_onaylama.Width = 60;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            this.repositoryItemCheckEdit2.ValueChecked = 1;
            this.repositoryItemCheckEdit2.ValueUnchecked = 0;
            // 
            // col_bildirimKodu
            // 
            this.col_bildirimKodu.Caption = "Bildirim Kodu";
            this.col_bildirimKodu.FieldName = "BildirimId";
            this.col_bildirimKodu.MinWidth = 23;
            this.col_bildirimKodu.Name = "col_bildirimKodu";
            this.col_bildirimKodu.Visible = true;
            this.col_bildirimKodu.VisibleIndex = 2;
            this.col_bildirimKodu.Width = 196;
            // 
            // col_GonderenKurumNo
            // 
            this.col_GonderenKurumNo.Caption = "Gönderen Kurum No";
            this.col_GonderenKurumNo.FieldName = "DigerKurumNo";
            this.col_GonderenKurumNo.Name = "col_GonderenKurumNo";
            this.col_GonderenKurumNo.Visible = true;
            this.col_GonderenKurumNo.VisibleIndex = 1;
            this.col_GonderenKurumNo.Width = 123;
            // 
            // col_belgeNo
            // 
            this.col_belgeNo.Caption = "Belge No";
            this.col_belgeNo.FieldName = "BelgeNo";
            this.col_belgeNo.Name = "col_belgeNo";
            this.col_belgeNo.Visible = true;
            this.col_belgeNo.VisibleIndex = 8;
            this.col_belgeNo.Width = 156;
            // 
            // col_gonderenKurum
            // 
            this.col_gonderenKurum.Caption = "Gönderen Kurum";
            this.col_gonderenKurum.FieldName = "GonderenKurum";
            this.col_gonderenKurum.Name = "col_gonderenKurum";
            this.col_gonderenKurum.UnboundDataType = typeof(string);
            this.col_gonderenKurum.Visible = true;
            this.col_gonderenKurum.VisibleIndex = 6;
            this.col_gonderenKurum.Width = 141;
            // 
            // col_seriNo
            // 
            this.col_seriNo.Caption = "Seri/Sıra No";
            this.col_seriNo.FieldName = "SeriNo";
            this.col_seriNo.Name = "col_seriNo";
            this.col_seriNo.Visible = true;
            this.col_seriNo.VisibleIndex = 4;
            this.col_seriNo.Width = 96;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.repositoryItemTextEdit1.MaskSettings.Set("mask", "c2");
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.repositoryItemTextEdit1.UseMaskAsDisplayFormat = true;
            // 
            // btn_urunSec
            // 
            this.btn_urunSec.Appearance.Font = new System.Drawing.Font("Arial", 12F);
            this.btn_urunSec.Appearance.Options.UseFont = true;
            this.btn_urunSec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_urunSec.ImageOptions.Image")));
            this.btn_urunSec.Location = new System.Drawing.Point(754, 12);
            this.btn_urunSec.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_urunSec.Name = "btn_urunSec";
            this.btn_urunSec.Size = new System.Drawing.Size(157, 36);
            this.btn_urunSec.StyleController = this.layoutControl1;
            this.btn_urunSec.TabIndex = 1;
            this.btn_urunSec.Text = "Ürünü Seç";
            this.btn_urunSec.Click += new System.EventHandler(this.btn_urunSec_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem2,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.emptySpaceItem3,
            this.layoutControlItem6});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1590, 868);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.t_barkodNo;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(139, 40);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(598, 40);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "Barkod No: ";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(81, 21);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 40);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(1570, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btn_urunSec;
            this.layoutControlItem2.Location = new System.Drawing.Point(742, 0);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(85, 40);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(161, 40);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btn_UTSveriCek;
            this.layoutControlItem3.Location = new System.Drawing.Point(1318, 0);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(140, 40);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(252, 40);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.Location = new System.Drawing.Point(903, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(415, 40);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.gc_UTSListesi;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 53);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(1570, 755);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btn_stokKaydet;
            this.layoutControlItem5.Location = new System.Drawing.Point(1336, 808);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(90, 40);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(234, 40);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 808);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(1336, 40);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.simpleButton1;
            this.layoutControlItem6.Location = new System.Drawing.Point(598, 0);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(96, 40);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(144, 40);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextVisible = false;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn_kaydet.Appearance.Options.UseFont = true;
            this.btn_kaydet.Location = new System.Drawing.Point(1199, 736);
            this.btn_kaydet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(139, 31);
            this.btn_kaydet.TabIndex = 5;
            this.btn_kaydet.Text = "Kaydet";
            // 
            // FRM_STOKEKLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1590, 868);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.btn_kaydet);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FRM_STOKEKLE";
            this.Text = "FRM_STOKEKLE";
            ((System.ComponentModel.ISupportInitialize)(this.t_barkodNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_UTSListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_UTSListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit t_barkodNo;
        private DevExpress.XtraEditors.SimpleButton btn_urunSec;
        private DevExpress.XtraGrid.GridControl gc_UTSListesi;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_UTSListesi;
        private DevExpress.XtraGrid.Columns.GridColumn col_urunBarkod;
        private DevExpress.XtraGrid.Columns.GridColumn col_urunAd;
        private DevExpress.XtraGrid.Columns.GridColumn col_bildirimZamani;
        private DevExpress.XtraGrid.Columns.GridColumn col_adet;
        private DevExpress.XtraGrid.Columns.GridColumn col_onaylama;
        private DevExpress.XtraEditors.SimpleButton btn_kaydet;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn col_bildirimKodu;
        private DevExpress.XtraEditors.SimpleButton btn_UTSveriCek;
        private DevExpress.XtraGrid.Columns.GridColumn col_GonderenKurumNo;
        private DevExpress.XtraGrid.Columns.GridColumn col_belgeNo;
        private DevExpress.XtraGrid.Columns.GridColumn col_gonderenKurum;
        private DevExpress.XtraGrid.Columns.GridColumn col_lotNo;
        private DevExpress.XtraGrid.Columns.GridColumn col_seriNo;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton btn_stokKaydet;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
    }
}
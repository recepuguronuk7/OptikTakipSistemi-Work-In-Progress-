namespace Optik_Takip_Sistemi
{
    partial class FRM_TUMSATISLARIM
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_TUMSATISLARIM));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gc_tumSatislar = new DevExpress.XtraGrid.GridControl();
            this.gv_tumSatislar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_musteriAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_musteriSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_musteriTCNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_urunTanimi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_barkodNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_satisTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.col_maliyet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.col_satisFiyati = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.col_btn_goruntule = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.entityInstantFeedbackSource1 = new DevExpress.Data.Linq.EntityInstantFeedbackSource();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_tumSatislar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_tumSatislar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gc_tumSatislar);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1202, 650);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gc_tumSatislar
            // 
            this.gc_tumSatislar.Location = new System.Drawing.Point(12, 12);
            this.gc_tumSatislar.MainView = this.gv_tumSatislar;
            this.gc_tumSatislar.Name = "gc_tumSatislar";
            this.gc_tumSatislar.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2,
            this.repositoryItemTextEdit3,
            this.repositoryItemButtonEdit1});
            this.gc_tumSatislar.Size = new System.Drawing.Size(1178, 626);
            this.gc_tumSatislar.TabIndex = 4;
            this.gc_tumSatislar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_tumSatislar});
            // 
            // gv_tumSatislar
            // 
            this.gv_tumSatislar.Appearance.Row.Options.UseTextOptions = true;
            this.gv_tumSatislar.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gv_tumSatislar.Appearance.ViewCaption.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.gv_tumSatislar.Appearance.ViewCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gv_tumSatislar.Appearance.ViewCaption.Options.UseFont = true;
            this.gv_tumSatislar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_musteriAd,
            this.col_musteriSoyad,
            this.col_musteriTCNo,
            this.col_urunTanimi,
            this.col_barkodNo,
            this.col_satisTarihi,
            this.col_maliyet,
            this.col_satisFiyati,
            this.col_btn_goruntule});
            this.gv_tumSatislar.GridControl = this.gc_tumSatislar;
            this.gv_tumSatislar.IndicatorWidth = 40;
            this.gv_tumSatislar.Name = "gv_tumSatislar";
            this.gv_tumSatislar.OptionsView.EnableAppearanceEvenRow = true;
            this.gv_tumSatislar.OptionsView.ShowFooter = true;
            this.gv_tumSatislar.OptionsView.ShowViewCaption = true;
            this.gv_tumSatislar.RowHeight = 35;
            this.gv_tumSatislar.ViewCaption = "TÜM SATIŞLAR";
            this.gv_tumSatislar.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gv_tumSatislar_CustomDrawRowIndicator);
            // 
            // col_musteriAd
            // 
            this.col_musteriAd.Caption = "Müşteri Ad";
            this.col_musteriAd.FieldName = "Ad";
            this.col_musteriAd.Name = "col_musteriAd";
            this.col_musteriAd.Visible = true;
            this.col_musteriAd.VisibleIndex = 2;
            this.col_musteriAd.Width = 102;
            // 
            // col_musteriSoyad
            // 
            this.col_musteriSoyad.Caption = "Müşteri Soyad";
            this.col_musteriSoyad.FieldName = "Soyad";
            this.col_musteriSoyad.Name = "col_musteriSoyad";
            this.col_musteriSoyad.Visible = true;
            this.col_musteriSoyad.VisibleIndex = 3;
            this.col_musteriSoyad.Width = 93;
            // 
            // col_musteriTCNo
            // 
            this.col_musteriTCNo.Caption = "Müşteri TC No";
            this.col_musteriTCNo.FieldName = "TCNo";
            this.col_musteriTCNo.Name = "col_musteriTCNo";
            this.col_musteriTCNo.Visible = true;
            this.col_musteriTCNo.VisibleIndex = 4;
            this.col_musteriTCNo.Width = 142;
            // 
            // col_urunTanimi
            // 
            this.col_urunTanimi.Caption = "Ürün Tanımı";
            this.col_urunTanimi.FieldName = "UrunTanimi";
            this.col_urunTanimi.Name = "col_urunTanimi";
            this.col_urunTanimi.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "UrunTanimi", "Satılan Ürün: {0}")});
            this.col_urunTanimi.Visible = true;
            this.col_urunTanimi.VisibleIndex = 0;
            this.col_urunTanimi.Width = 204;
            // 
            // col_barkodNo
            // 
            this.col_barkodNo.Caption = "Barkod No";
            this.col_barkodNo.FieldName = "BarkodNo";
            this.col_barkodNo.Name = "col_barkodNo";
            this.col_barkodNo.Visible = true;
            this.col_barkodNo.VisibleIndex = 1;
            this.col_barkodNo.Width = 98;
            // 
            // col_satisTarihi
            // 
            this.col_satisTarihi.Caption = "Satış Tarihi";
            this.col_satisTarihi.ColumnEdit = this.repositoryItemTextEdit3;
            this.col_satisTarihi.FieldName = "SatisTarihi";
            this.col_satisTarihi.Name = "col_satisTarihi";
            this.col_satisTarihi.Visible = true;
            this.col_satisTarihi.VisibleIndex = 7;
            this.col_satisTarihi.Width = 126;
            // 
            // repositoryItemTextEdit3
            // 
            this.repositoryItemTextEdit3.AutoHeight = false;
            this.repositoryItemTextEdit3.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.DateTimeMaskManager));
            this.repositoryItemTextEdit3.MaskSettings.Set("mask", "G");
            this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
            this.repositoryItemTextEdit3.UseMaskAsDisplayFormat = true;
            // 
            // col_maliyet
            // 
            this.col_maliyet.Caption = "Maliyet";
            this.col_maliyet.ColumnEdit = this.repositoryItemTextEdit2;
            this.col_maliyet.FieldName = "Maliyet";
            this.col_maliyet.Name = "col_maliyet";
            this.col_maliyet.Visible = true;
            this.col_maliyet.VisibleIndex = 5;
            this.col_maliyet.Width = 126;
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
            // col_satisFiyati
            // 
            this.col_satisFiyati.Caption = "Satış Fiyatı";
            this.col_satisFiyati.ColumnEdit = this.repositoryItemTextEdit1;
            this.col_satisFiyati.FieldName = "UrunSatisFiyati";
            this.col_satisFiyati.Name = "col_satisFiyati";
            this.col_satisFiyati.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "UrunSatisFiyati", "Toplam: {0:C2}")});
            this.col_satisFiyati.Visible = true;
            this.col_satisFiyati.VisibleIndex = 6;
            this.col_satisFiyati.Width = 189;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.repositoryItemTextEdit1.MaskSettings.Set("mask", "c2");
            this.repositoryItemTextEdit1.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.repositoryItemTextEdit1.UseMaskAsDisplayFormat = true;
            // 
            // col_btn_goruntule
            // 
            this.col_btn_goruntule.Caption = "Ayrıntılar";
            this.col_btn_goruntule.ColumnEdit = this.repositoryItemButtonEdit1;
            this.col_btn_goruntule.Name = "col_btn_goruntule";
            this.col_btn_goruntule.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.col_btn_goruntule.OptionsFilter.AllowAutoFilter = false;
            this.col_btn_goruntule.OptionsFilter.AllowFilter = false;
            this.col_btn_goruntule.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.col_btn_goruntule.Visible = true;
            this.col_btn_goruntule.VisibleIndex = 8;
            this.col_btn_goruntule.Width = 78;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Görüntüle", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEdit1_ButtonClick);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1202, 650);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gc_tumSatislar;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1182, 630);
            this.layoutControlItem1.TextVisible = false;
            // 
            // FRM_TUMSATISLARIM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 650);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FRM_TUMSATISLARIM";
            this.Text = "FRM_TUMSATISLARIM";
            this.Load += new System.EventHandler(this.FRM_TUMSATISLARIM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_tumSatislar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_tumSatislar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gc_tumSatislar;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_tumSatislar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn col_musteriAd;
        private DevExpress.XtraGrid.Columns.GridColumn col_musteriSoyad;
        private DevExpress.XtraGrid.Columns.GridColumn col_musteriTCNo;
        private DevExpress.XtraGrid.Columns.GridColumn col_urunTanimi;
        private DevExpress.XtraGrid.Columns.GridColumn col_barkodNo;
        private DevExpress.XtraGrid.Columns.GridColumn col_satisTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn col_maliyet;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn col_satisFiyati;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.Data.Linq.EntityInstantFeedbackSource entityInstantFeedbackSource1;
        private DevExpress.XtraGrid.Columns.GridColumn col_btn_goruntule;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
    }
}
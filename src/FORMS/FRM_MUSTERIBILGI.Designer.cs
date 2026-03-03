namespace Optik_Takip_Sistemi
{
    partial class FRM_MUSTERIBILGI
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
            this.gc_yapilanAlimlar = new DevExpress.XtraGrid.GridControl();
            this.gv_yapilanAlimlar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_satisTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.col_urunTanimi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_satisFiyati = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.t_adres = new DevExpress.XtraEditors.TextEdit();
            this.t_telNo = new DevExpress.XtraEditors.TextEdit();
            this.t_TCNo = new DevExpress.XtraEditors.TextEdit();
            this.t_soyad = new DevExpress.XtraEditors.TextEdit();
            this.t_ad = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_yapilanAlimlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_yapilanAlimlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_adres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_telNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_TCNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_soyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_ad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gc_yapilanAlimlar);
            this.layoutControl1.Controls.Add(this.t_adres);
            this.layoutControl1.Controls.Add(this.t_telNo);
            this.layoutControl1.Controls.Add(this.t_TCNo);
            this.layoutControl1.Controls.Add(this.t_soyad);
            this.layoutControl1.Controls.Add(this.t_ad);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(726, 597);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gc_yapilanAlimlar
            // 
            this.gc_yapilanAlimlar.Location = new System.Drawing.Point(12, 142);
            this.gc_yapilanAlimlar.MainView = this.gv_yapilanAlimlar;
            this.gc_yapilanAlimlar.Name = "gc_yapilanAlimlar";
            this.gc_yapilanAlimlar.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2});
            this.gc_yapilanAlimlar.Size = new System.Drawing.Size(702, 443);
            this.gc_yapilanAlimlar.TabIndex = 9;
            this.gc_yapilanAlimlar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_yapilanAlimlar});
            // 
            // gv_yapilanAlimlar
            // 
            this.gv_yapilanAlimlar.Appearance.Row.Options.UseTextOptions = true;
            this.gv_yapilanAlimlar.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gv_yapilanAlimlar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_satisTarihi,
            this.col_urunTanimi,
            this.col_satisFiyati});
            this.gv_yapilanAlimlar.GridControl = this.gc_yapilanAlimlar;
            this.gv_yapilanAlimlar.IndicatorWidth = 40;
            this.gv_yapilanAlimlar.Name = "gv_yapilanAlimlar";
            this.gv_yapilanAlimlar.OptionsView.ShowViewCaption = true;
            this.gv_yapilanAlimlar.RowHeight = 35;
            this.gv_yapilanAlimlar.ViewCaption = "Geçmiş Alımları";
            this.gv_yapilanAlimlar.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gv_yapilanAlimlar_CustomDrawRowIndicator);
            // 
            // col_satisTarihi
            // 
            this.col_satisTarihi.Caption = "Satış Tarihi";
            this.col_satisTarihi.ColumnEdit = this.repositoryItemTextEdit1;
            this.col_satisTarihi.FieldName = "satisTarihi";
            this.col_satisTarihi.Name = "col_satisTarihi";
            this.col_satisTarihi.Visible = true;
            this.col_satisTarihi.VisibleIndex = 1;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.DateTimeMaskManager));
            this.repositoryItemTextEdit1.MaskSettings.Set("mask", "G");
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.repositoryItemTextEdit1.UseMaskAsDisplayFormat = true;
            // 
            // col_urunTanimi
            // 
            this.col_urunTanimi.Caption = "Ürün Tanımı";
            this.col_urunTanimi.FieldName = "urunTanimi";
            this.col_urunTanimi.Name = "col_urunTanimi";
            this.col_urunTanimi.Visible = true;
            this.col_urunTanimi.VisibleIndex = 0;
            // 
            // col_satisFiyati
            // 
            this.col_satisFiyati.Caption = "Satış Fiyatı";
            this.col_satisFiyati.ColumnEdit = this.repositoryItemTextEdit2;
            this.col_satisFiyati.FieldName = "satisFiyati";
            this.col_satisFiyati.Name = "col_satisFiyati";
            this.col_satisFiyati.Visible = true;
            this.col_satisFiyati.VisibleIndex = 2;
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.repositoryItemTextEdit2.MaskSettings.Set("mask", "c2");
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            this.repositoryItemTextEdit2.UseMaskAsDisplayFormat = true;
            // 
            // t_adres
            // 
            this.t_adres.Location = new System.Drawing.Point(86, 116);
            this.t_adres.Name = "t_adres";
            this.t_adres.Size = new System.Drawing.Size(628, 22);
            this.t_adres.StyleController = this.layoutControl1;
            this.t_adres.TabIndex = 8;
            // 
            // t_telNo
            // 
            this.t_telNo.Location = new System.Drawing.Point(86, 90);
            this.t_telNo.Name = "t_telNo";
            this.t_telNo.Size = new System.Drawing.Size(628, 22);
            this.t_telNo.StyleController = this.layoutControl1;
            this.t_telNo.TabIndex = 7;
            // 
            // t_TCNo
            // 
            this.t_TCNo.Location = new System.Drawing.Point(86, 64);
            this.t_TCNo.Name = "t_TCNo";
            this.t_TCNo.Size = new System.Drawing.Size(628, 22);
            this.t_TCNo.StyleController = this.layoutControl1;
            this.t_TCNo.TabIndex = 6;
            // 
            // t_soyad
            // 
            this.t_soyad.Location = new System.Drawing.Point(86, 38);
            this.t_soyad.Name = "t_soyad";
            this.t_soyad.Size = new System.Drawing.Size(628, 22);
            this.t_soyad.StyleController = this.layoutControl1;
            this.t_soyad.TabIndex = 5;
            // 
            // t_ad
            // 
            this.t_ad.Location = new System.Drawing.Point(86, 12);
            this.t_ad.Name = "t_ad";
            this.t_ad.Size = new System.Drawing.Size(628, 22);
            this.t_ad.StyleController = this.layoutControl1;
            this.t_ad.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(726, 597);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.t_ad;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(706, 26);
            this.layoutControlItem1.Text = "Ad:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(70, 15);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.t_soyad;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(706, 26);
            this.layoutControlItem2.Text = "Soyad:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(70, 15);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.t_TCNo;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 52);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(706, 26);
            this.layoutControlItem3.Text = "TC Kimlik No";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(70, 15);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.t_telNo;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 78);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(706, 26);
            this.layoutControlItem4.Text = "Telefon No:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(70, 15);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.t_adres;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 104);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(706, 26);
            this.layoutControlItem5.Text = "Adres:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(70, 15);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.gc_yapilanAlimlar;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 130);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(706, 447);
            this.layoutControlItem6.TextVisible = false;
            // 
            // FRM_MUSTERIBILGI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 597);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FRM_MUSTERIBILGI";
            this.Text = "FRM_MUSTERIBILGI";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_yapilanAlimlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_yapilanAlimlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_adres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_telNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_TCNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_soyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_ad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gc_yapilanAlimlar;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_yapilanAlimlar;
        private DevExpress.XtraEditors.TextEdit t_adres;
        private DevExpress.XtraEditors.TextEdit t_telNo;
        private DevExpress.XtraEditors.TextEdit t_TCNo;
        private DevExpress.XtraEditors.TextEdit t_soyad;
        private DevExpress.XtraEditors.TextEdit t_ad;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraGrid.Columns.GridColumn col_satisTarihi;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn col_urunTanimi;
        private DevExpress.XtraGrid.Columns.GridColumn col_satisFiyati;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
    }
}
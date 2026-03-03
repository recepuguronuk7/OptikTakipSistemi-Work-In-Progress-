using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optik_Takip_Sistemi
{
    using DevExpress.XtraGrid.Localization;

    public class TurkceGridLocalizer : GridLocalizer
    {
        public override string GetLocalizedString(GridStringId id)
        {
            // İhtiyaç duyduğunuz ID'leri yakalayıp Türkçe karşılığını döndürün
            switch (id)
            {
                // Sağ Tık Menüsü
                case GridStringId.MenuColumnSortAscending: return "A'dan Z'ye Sırala";
                case GridStringId.MenuColumnSortDescending: return "Z'den A'ya Sırala";
                case GridStringId.MenuColumnClearSorting: return "Sıralamayı Temizle";
                case GridStringId.MenuGroupPanelHide: return "Gruplama Panelini Gizle";
                case GridStringId.MenuColumnGroup: return "Bu Sütuna Göre Grupla";
                case GridStringId.MenuGroupPanelShow: return "Gruplama Panelini Göster";
                case GridStringId.MenuColumnRemoveColumn: return "Sütunu Gizle"; // "Hide Column" karşılığı
                case GridStringId.MenuColumnColumnCustomization: return "Sütun Seçici (Gizlenenler)";
                case GridStringId.MenuColumnBestFit: return "Otomatik Genişlik (Bu Sütun)";
                case GridStringId.MenuColumnBestFitAllColumns: return "Otomatik Genişlik (Tümü)";
                case GridStringId.MenuColumnFilterEditor: return "Filtre Düzenleyici...";
                case GridStringId.MenuColumnFindFilterShow: return "Arama Panelini Göster";
                case GridStringId.MenuColumnAutoFilterRowShow: return "Otomatik Filtreleme Satırını Göster";

                // Grid Genel Yazıları
                case GridStringId.GridGroupPanelText: return "Gruplamak istediğiniz sütunu buraya sürükleyin";
                case GridStringId.FilterBuilderCaption: return "Filtre Oluşturucu";

                // Varsayılan (Değiştirmediğiniz diğer her şey orijinal kalsın)
                default: return base.GetLocalizedString(id);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optik_Takip_Sistemi
{
    internal class Modul_Ek
    {
        public void Angle(object sender, PaintEventArgs e)
        {
            DevExpress.XtraEditors.LabelControl lbl = sender as DevExpress.XtraEditors.LabelControl;
            if (lbl == null) return;

            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;                 

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            
            using (Brush firca = new SolidBrush(Color.FromArgb(64, 64, 64))) 
            {
                SizeF yaziBoyutu = e.Graphics.MeasureString(lbl.Text, lbl.Appearance.Font);

                
                e.Graphics.TranslateTransform(lbl.Width / 2, lbl.Height / 2);

                
                e.Graphics.RotateTransform(-90);

                
                e.Graphics.DrawString(lbl.Text,
                                      lbl.Appearance.Font,
                                      firca,
                                      -(yaziBoyutu.Width / 2),
                                      -(yaziBoyutu.Height / 2));
            }
        }

        public decimal DecimalCevir(string text)
        {
            if(string.IsNullOrWhiteSpace(text)) return 0;
            decimal val;
            return decimal.TryParse(text, out val) ? val : 0;
        }

        public void KontrolleriTemizle(Control parent)
        {
            
            foreach (Control c in parent.Controls)
            {
                
                if (c is DevExpress.XtraEditors.BaseEdit)
                {
                   
                    (c as DevExpress.XtraEditors.BaseEdit).EditValue = null;
                }
                                
                if (c.HasChildren)
                {
                    KontrolleriTemizle(c);
                }
            }
        }
    }
}

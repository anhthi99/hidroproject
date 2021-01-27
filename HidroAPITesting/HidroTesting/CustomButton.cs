using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HidroTesting
{
    class CustomButton : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            LinearGradientBrush brush = new LinearGradientBrush
                (
                    new RectangleF(0,0,Width,Height),
                    Color.Gray,
                    Color.White,
                    LinearGradientMode.Vertical
                );
            
            pevent.Graphics.FillRectangle(brush, 0,0,Width, Height);
            
            TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;
            TextRenderer.DrawText(pevent.Graphics, Text, Font, new Point(Width + 3, this.Height / 2), ForeColor, flags);
        }
    }
}

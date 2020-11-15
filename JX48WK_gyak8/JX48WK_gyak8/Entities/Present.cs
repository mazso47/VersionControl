using JX48WK_gyak8.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JX48WK_gyak8.Entities
{
    class Present : Toy
    {
        public SolidBrush ribbonColor { get; private set; }
        public SolidBrush boxColor { get; private set; }
        public Present(Color color1, Color color2)
        {
            ribbonColor = new SolidBrush(color1);
            boxColor = new SolidBrush(color2);
        }
       

        protected override void DrawImage(Graphics g)
        {
            g.FillRectangle(ribbonColor, 25, 0, Width, Height);
            g.FillRectangle(ribbonColor, 0, 25, Width, Height);
            g.FillRectangle(boxColor, 0, 0, Width, Height);
        }
    }
}

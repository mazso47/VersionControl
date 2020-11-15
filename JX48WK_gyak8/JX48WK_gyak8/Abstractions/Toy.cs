using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JX48WK_gyak8.Abstractions
{
    public abstract class Toy : Label
    {
        public Toy()
        {
            this.AutoSize = false;
            this.Width = 50;
            this.Height = 50;
            Paint += Toy_Paint;
        }

        private void Toy_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
        }

        protected abstract void DrawImage(Graphics g);
       

        public virtual void MoveToy()
        {
            Left += 1;
        }
    }
}

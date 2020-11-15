using JX48WK_gyak8.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JX48WK_gyak8.Entities
{
    class PresentFactory : IToyFactory
    {
        public Color boxColor { get; set; }
        public Color ribbonColor { get; set; }
        public Toy CreateNew()
        {
            return new Present(boxColor, ribbonColor);
        }
    }
}

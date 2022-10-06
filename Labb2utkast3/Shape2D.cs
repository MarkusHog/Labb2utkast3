using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Labb2
{
    public abstract class Shape2D : Shape
    {
        public override Vector3 Center { get; }

        public override float Area { get; }
        public abstract float Circumference { get; }
    }
}

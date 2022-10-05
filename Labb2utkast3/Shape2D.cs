using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Labb2utkast3
{
    public abstract class Shape2D : Shape
    {
        private Vector3 _center;
        private float _area;

        public override Vector3 Center => _center;

        public override float Area => _area;
        public float Circumference { get; }
    }
}

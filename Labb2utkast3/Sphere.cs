using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Labb2
{
    public class Sphere : Shape3D
    {
        private float _volume;
        private Vector3 _center;
        private float radius;
        private float _area;

        public override float Volume => _volume;

        public override Vector3 Center => _center;

        public override float Area => _area;

        public Sphere(Vector3 center, float radius)
        {
            this._center = center;
            this.radius = radius;
            this._area = (float)(Math.PI * 4 * radius * radius);
            this._volume = (float)(Math.PI * Math.Pow(radius, 3) * 4/3);
        }
        public override string ToString() => $"sphere @{_center:f2}: r = {radius:f2} " ;
    }
}

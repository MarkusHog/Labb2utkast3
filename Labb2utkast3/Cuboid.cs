using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Labb2
{
    public class Cuboid : Shape3D
    {
        private float _volume;
        private Vector3 _center;
        private float width;
        private Vector3 _size;
        private float _area;
       
        public override float Volume => _volume;

        public override Vector3 Center => _center;

        public override float Area => _area;
        public bool IsCube => _size.X == _size.Y && _size.Y == _size.Z;

        public Cuboid(Vector3 center, Vector3 size)
        {
            this._center = center;
            this._size = size;
            this._area = (size.X * size.Y * 2) + (size.X * size.Z * 2) + (size.Z * size.Y * 2);
            this._volume = size.X * size.Y * size.Z;
            this.width = _size.X;        
        }
        public Cuboid(Vector3 center, float width)
        {
            this._center = center;
            this.width = width;
            this._area = width * width * 6;
            this._volume = (float)Math.Pow(width,3);
            this._size.X = width;
            this._size.Y = width;
            this._size.Z = width;
        }

        public override string ToString()
        {
            if (!IsCube)
            {
                return $"cuboid @{_center}, w = {_size.X}, h = {_size.Y} l = {_size.Z} ";

            }
            return $"cube @{_center}, w, h and l = {width} ";

            
        }
    }
}

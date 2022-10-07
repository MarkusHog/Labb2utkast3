using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Labb2
{
    public class Rectangle : Shape2D
    {

        private Vector2 center;
        private float width;
        private Vector2 size;
        private float _area;
        private float circumference;
        
        public override float Area => _area;
        
        public bool IsSquare => size.X == size.Y;

        public override float Circumference => circumference;

        public Rectangle(Vector2 center, Vector2 size)
        {            
            this.center = center;
            this.size = size;
            this._area = size.X * size.Y;
            this.circumference = size.X * 2 + size.Y * 2;
        }
        public Rectangle(Vector2 center, float width) 
        {
            this.center = center;
            this.width = width;
            this.size.X = width;
            this.size.Y = width;
            this._area = width * width;
            this.circumference = width * 4;           
        }
        
        public override string ToString()
        {
            if (IsSquare)
            {
                return $"Sqare @{center}: width and heigth = {width} ";
            }
            else
            {
                return $"rectangle @{center}: w = {size.X}, h = {size.Y} ";
            }

        }
       
    }
}

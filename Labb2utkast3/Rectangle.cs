using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Labb2utkast3
{
    public class Rectangle : Shape2D
    {

        private Vector2 center;
        private Vector2 size;
        private float _area;
        private float circumference;
        

        public override float Area => _area;
        public float Circumference => circumference;

        public Vector2 Center => center;
        public bool IsSquare
        {
            get
            {
                return size.X == size.Y;
                
            }
            
        }


        public Rectangle(Vector2 center, Vector2 size)
        {            
            this.center = center;
            this.size = size;
            this._area = size.X * size.Y;
            this.circumference = size.X*2+size.Y * 2;
        }
        public Rectangle(Vector2 center, float width) 
        {
            this.center = center;
            this.size.X = width;
            this.size.Y = width;
            this._area = width * width;
            this.circumference = width * 4;
            
        }
        
        public override string ToString()
        {
            if (IsSquare)
            {
                return $"Sqare @{center}: width and heigth = {size.X} ";

            }
            else
            {
                return $"rectangle @{center}: w = {size.X}, h = {size.Y} ";

            }

        }
       
    }
}

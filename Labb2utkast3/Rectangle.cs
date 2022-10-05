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
        private object y;
        private object x;
        private float x1;
        private float y1;
        private Vector2 center;
        private Vector2 size;
        private float _area;
        private float circumference;
        private object width;
        //private bool square;

        public override float Area => _area;

        public Vector3 Center { get; }
        public bool IsSquare
        {
            get
            {

                return size.X == size.Y;
                //if (size.X == size.Y)
                //{
                //    return true;
                    
                //}
                //else
                //{
                //    return false;
                //}
            }

            
        }



        public Rectangle(Vector2 center, Vector2 size)
        {
            
            this.center = center;
            this.size = size;
            this._area = size.X * size.Y;
            this.circumference = size.X+size.Y * 2;


        }
        public Rectangle(Vector2 center, float width) 
        {
            this.center = center;
            this.size.X = width;
            this.size.Y = width;
            this._area = width * width;
            this.circumference = width * 4;
            
        }
        //public override string ToString() => $"rectangle @{center}: w = {size.X} h = {size.Y} area = {_area}";
        //public override string ToString() => $"Sqare @{center} width and heigth = {size.X} area = {_area}";
        public override string ToString()
        {
            if (IsSquare)
            {
                return $"Sqare @{center} width and heigth = {size.X} area = {_area} circumference = {circumference}";

            }
            else
            {
                return $"rectangle @{center}: w = {size.X} h = {size.Y} area = {_area} circumference = {circumference}";

            }

        }
       
    }
}

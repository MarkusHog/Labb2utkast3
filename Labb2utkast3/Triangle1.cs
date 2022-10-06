using Labb2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Labb2
{
    public class Triangle : Shape2D

    {
        private Vector2 center;
        private Vector2 p1;
        private Vector2 p2;
        private Vector2 p3;
        private float area;
        private float circumference;

        public override float Circumference => circumference;
        public override float Area => area;
        public Triangle(Vector2 p1, Vector2 p2, Vector2 p3)
        {
            float x = (p1.X + p2.X + p3.X) / 3;
            float y = (p1.Y + p2.Y + p3.Y) / 3;
            Vector2 center = new Vector2(x, y);

            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.center = center;

            float area1 = (p1.Y + p2.Y) * (p2.X - p1.X) / 2;
            float area2 = (p2.Y + p3.Y) * (p3.X - p2.X) / 2;
            float area3 = (p1.Y + p3.Y) * (p3.X - p1.X) / 2;
            float areaResult = area1 + area2 - area3;
            this.area = Math.Abs(areaResult);

            double side1 = Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2);
            double side1sq = Math.Sqrt(side1);

            double side2 = Math.Pow(p3.X - p2.X, 2) + Math.Pow(p3.Y - p2.Y, 2);
            double side2sq = Math.Sqrt(side2);

            double side3 = Math.Pow(p1.X - p3.X, 2) + Math.Pow(p1.Y - p3.Y, 2);
            double side3sq = Math.Sqrt(side3);

            float result = (float)((float)side1sq + side2sq + side3sq);
            this.circumference = result;
                       
        }

        public override string ToString() => $"triangle @{center:f2}: p1{p1:f2}, p2{p2:f2}, p3{p3:f2}";

    }

}

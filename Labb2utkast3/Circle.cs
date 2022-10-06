using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Labb2utkast3;

public class Circle : Shape2D
{
    private Vector2 center;
    private float radius;
    private float _area;
    private object circumference;

    public Vector2 Center2 => center;
    public float Radius => radius;

    public override float Area => _area;

    

    public Circle(Vector2 center, float radius)
    {
        this.center = center;
        this.radius = radius;
        this._area = (float) (Math.PI* radius * radius);
        this.circumference = Math.PI * radius * 2;


    }
    public override string ToString()
    {
        return $"circle @{center}: r = {radius} area = {_area:f2} circumference = {circumference:f2}";

    }
    
}

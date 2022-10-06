using Labb2;
using System.Numerics;

Shape[] shapeArray = new Shape[20];
float sum = 0;

for (int i = 0; i < 20; i++)
{
    shapeArray[i] = Shape.GenerateShape();

    Console.WriteLine(shapeArray[i]);

    Console.WriteLine("----------------------------------------------------------------------------------");

    sum += shapeArray[i].Area;
}

float averageArea = sum / shapeArray.Length;

Console.WriteLine($"The average area is {averageArea:f2}");



//Triangle anc = new Triangle(new Vector2(3,7), new Vector2(5,8), new Vector2(4,9), new Vector2(2,2));
//Console.WriteLine(anc);

//Console.WriteLine();

Vector2 p1 = new Vector2(6, 10);
Vector2 p2 = new Vector2(8, 20);
Vector2 p3 = new Vector2(5, 9);

Vector3 v3 = new Vector3(5, 8, 3);
Vector3 v33 = new Vector3(1, 5, 9);


Triangle kkk = new Triangle(p1, p2, p3);
Console.WriteLine(kkk.Area);
Console.WriteLine(kkk.Circumference);

Console.WriteLine()
    ;
Circle abc = new Circle(p1, 4);
Console.WriteLine(abc.Area);
Console.WriteLine(abc.Circumference);
Console.WriteLine(abc.Radius);

Console.WriteLine();

Rectangle bcd = new Rectangle(p1,p2);
Console.WriteLine(bcd.Area);
Console.WriteLine(bcd.Circumference);
Console.WriteLine(bcd.IsSquare);

Console.WriteLine();

Cuboid klo = new Cuboid(v3,v33);
Console.WriteLine(klo.Area);
Console.WriteLine(klo.Volume);
Console.WriteLine(klo.IsCube);

Console.WriteLine();

Sphere qwe = new Sphere(v3,6);
Console.WriteLine(qwe.Area);
Console.WriteLine(qwe.Volume);
Console.WriteLine(qwe.Center);

//float area1 = (p1.Y + p2.Y) * (p2.X - p1.X) / 2;
//float area2 = (p2.Y + p3.Y) * (p3.X - p2.X) / 2;
//float area3 = (p1.Y + p3.Y) * (p3.X - p1.X) / 2;
//float area = area1 + area2 - area3;
//float positiveArea = Math.Abs(area);
//Console.WriteLine(area);
//Console.WriteLine(positiveArea);

//double p1p2 = Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2);
//double p1p2sq = Math.Sqrt(p1p2);

//double p2p3 = Math.Pow(p3.X - p2.X, 2) + Math.Pow(p3.Y - p2.Y, 2);
//double p2p3sq = Math.Sqrt(p2p3);

//double p3p1 = Math.Pow(p1.X - p3.X, 2) + Math.Pow(p1.Y - p3.Y, 2);
//double p3p1sq = Math.Sqrt(p3p1);

//double sum1 = p1p2sq + p2p3sq + p3p1sq;

//Console.WriteLine(sum1);
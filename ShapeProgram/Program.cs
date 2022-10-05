using Labb2utkast3;
using System.Numerics;

Shape[] shapeArray = new Shape[20];

float sum = 0;

for (int i = 0; i < 20; i++)
{
    shapeArray[i] = Shape.GenerateShape();
    Console.WriteLine(shapeArray[i]);
    sum += shapeArray[i].Area;

}
Console.WriteLine(sum);
float averageArea = sum / 20;
Console.WriteLine($"Average area is {averageArea}");




Vector3 abc = new Vector3(5, 8, 10);
Sphere mySphere = new(abc, 20);
Console.WriteLine(mySphere.Volume);
Console.WriteLine(mySphere);

Vector2 ab = new Vector2(4, 8);

Circle myCircle = new Circle(ab,2);
Console.WriteLine(myCircle.Circumference);



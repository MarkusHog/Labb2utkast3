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
Console.WriteLine($"Total area {sum:f2}");
float averageArea = sum / 20;
Console.WriteLine($"The average area is {averageArea:f2}");


//Circle

Circle abc = new Circle(new Vector2(3.0f, 4.0f),2);

Console.WriteLine(abc.Area);
Console.WriteLine(abc.Circumference);


Rectangle bcd = new Rectangle(new Vector2(3.0f, 4.0f), 2);
Console.WriteLine(bcd.Circumference);
Console.WriteLine(bcd.Area);
Console.WriteLine(bcd.IsSquare);
Console.WriteLine(bcd.Center);



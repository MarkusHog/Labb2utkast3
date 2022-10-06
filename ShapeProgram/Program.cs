using Labb2utkast3;
using System.Numerics;

Shape[] shapeArray = new Shape[20];
float sum = 0;

for (int i = 0; i < 20; i++)
{
    shapeArray[i] = Shape.GenerateShape();
    Console.WriteLine(shapeArray[i]);
    Console.WriteLine("------------------------------------------");
    sum += shapeArray[i].Area;

}
//Console.WriteLine();

float averageArea = sum / shapeArray.Length;
Console.WriteLine($"The average area is {averageArea:f2}");



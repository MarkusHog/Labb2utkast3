using Labb2;
using System.Numerics;

Shape[] shapeArray = new Shape[20];
float sumArea = 0;


for (int i = 0; i < 20; i++)
{
    shapeArray[i] = Shape.GenerateShape();

    Console.WriteLine(shapeArray[i]);

    Console.WriteLine("----------------------------------------------------------------------------------");

    sumArea += shapeArray[i].Area;
    
}

float averageArea = sumArea / shapeArray.Length;

Console.WriteLine($"The average area is {averageArea:f2}");

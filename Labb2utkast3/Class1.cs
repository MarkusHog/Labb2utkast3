using System.Numerics;

namespace Labb2utkast3
{
    public abstract class Shape
    {
        //private int randomShape;
        //private Vector3 center;
        public abstract Vector3 Center { get; }
        public abstract float Area { get; }

        public static Shape GenerateShape()
        {

            float x = Random.Shared.Next(-100, 100);
            float y = Random.Shared.Next(-100, 100);
            float z = Random.Shared.Next(-100, 100);


            Vector3 _center = new Vector3(x, y, z);
            
            Vector2 center = new Vector2(x,y);

            float x1 = Random.Shared.Next(1, 100);
            float y1 = Random.Shared.Next(1, 100);
            float z1 = Random.Shared.Next(1, 100);

            Vector2 size = new Vector2(x1, y1);
            Vector3 _size = new Vector3(x1, y1, z1);

            float width = x1;
            float radius = Random.Shared.Next(0, 50);

            int randomShape = Random.Shared.Next(0, 6);


            if(randomShape == 0)
            {
                Circle circle = new Circle(center,radius);
                return circle;
            }
            if (randomShape == 1)
            {             
                Rectangle rectangle = new Rectangle(center,size);
                return rectangle;
            }
            if(randomShape == 2)
            {
                Rectangle square = new Rectangle(center, width);
                return square;

            }
            if (randomShape == 3)
            {
                Cuboid cuboid = new Cuboid(_center,_size);
                return cuboid;
                
            }
            if(randomShape == 4)
            {
                Cuboid cube = new Cuboid(_center, width);
                return cube;
            }
            else
            {
                Sphere sphere = new Sphere(_center, radius);
                return sphere;
            
            }
           
           
            


        }
      
      
    }

        
}
﻿namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>
            {
                new Circle(5),
                new Rectangle(2, 5),
                new Triangle(3, 7)
            };

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.GetType().Name + " area = " + shape.CalculateArea());
            }

            List<Shape3D> shapes3d = new List<Shape3D>();

            foreach (Shape shape in shapes)
            {
                if (shape is Circle circle)
                {
                    shapes3d.Add(new Sphere(circle));
                    shapes3d.Add(new Cylinder(circle, 5));
                    shapes3d.Add(new Cone(circle, 5));
                }
                else if (shape is Triangle triangle)
                {

                    shapes3d.Add(new Prism(triangle, 5));
                    shapes3d.Add(new Pyramid(triangle, 5));
                }
            }
            foreach (Shape3D shape3d in shapes3d)
            {
                Console.WriteLine(shape3d.GetType().Name + " with " +
                shape3d.BaseShape.GetType().Name + " base | Volume = " +
                shape3d.CalculateVolume());
            }

            Prism test = new Prism(new Rectangle(5.0, 10.0), 15.0);
            Console.WriteLine(test.CalculateVolume());
            Prism testCircle = new Prism(new Circle(10.0), 30.0);
            Console.WriteLine(testCircle.CalculateVolume());

        }
    }
}

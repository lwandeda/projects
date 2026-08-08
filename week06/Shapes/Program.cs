using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Red", 5);

        Console.WriteLine(
            $"Square: {square.GetColor()} - Area: {square.GetArea()}"
        );


        Rectangle rectangle = new Rectangle("Blue", 6, 4);

        Console.WriteLine(
            $"Rectangle: {rectangle.GetColor()} - Area: {rectangle.GetArea()}"
        );


        Circle circle = new Circle("Green", 3);

        Console.WriteLine(
            $"Circle: {circle.GetColor()} - Area: {circle.GetArea()}"
        );


        Console.WriteLine();
        Console.WriteLine("Polymorphism with a list:");
        Console.WriteLine();


        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("Yellow", 4));

        shapes.Add(new Rectangle("Purple", 5, 3));

        shapes.Add(new Circle("Orange", 2));


        foreach (Shape shape in shapes)
        {
            Console.WriteLine(
                $"Color: {shape.GetColor()}, Area: {shape.GetArea():F2}"
            );
        }
    }
}
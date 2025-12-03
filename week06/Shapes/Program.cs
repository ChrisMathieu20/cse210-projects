using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        
        Square sq = new Square("blue",4);
        Rectangle re = new Rectangle("purple",6,2);
        Circle ci = new Circle("yellow",5);

        shapes.Add(sq);
        shapes.Add(re);
        shapes.Add(ci);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"Shape > Color: {color} - Area: {area}");
        }
    }
}
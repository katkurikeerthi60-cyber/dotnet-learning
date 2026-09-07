using ShapesLibrary;

Circle circle = new Circle(5);
Rectangle rectangle = new Rectangle(10, 4);

Console.WriteLine("Shapes Demo");
Console.WriteLine($"Circle Area: {circle.GetArea():F2}");
Console.WriteLine($"Rectangle Area: {rectangle.GetArea():F2}");

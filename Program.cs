System.Console.Write("Введите радиус круга:");
double radius = Convert.ToDouble(Console.ReadLine());

Circle circle = new Circle(radius);
System.Console.WriteLine($"Площадь круга: {circle.Area()}");

System.Console.WriteLine("Введите стороны треугольника");
System.Console.Write("a: ");
double a = Convert.ToDouble(Console.ReadLine());
System.Console.Write("b: ");
double b = Convert.ToDouble(Console.ReadLine());
System.Console.Write("c: ");
double c = Convert.ToDouble(Console.ReadLine());

Triangle triangle = new Triangle(a, b, c);

System.Console.WriteLine($"Площадь треугольника по трем сторонам: {triangle.Area()}");

if (triangle.isRightTriangle())
{
    System.Console.WriteLine("Треугольник прямоугольный");
}
else System.Console.WriteLine("Треугольник непрямоугольный");
double circleArea(double r)
{
    return Math.PI * r * r;
}

System.Console.Write("Введите радиус круга:");
double radius = Convert.ToDouble(Console.ReadLine());
double circleS = circleArea(radius);
System.Console.WriteLine($"Площадь круга: {circleS}");

System.Console.WriteLine("Введите стороны треугольника");
System.Console.Write("a: ");
double a = Convert.ToDouble(Console.ReadLine());
System.Console.Write("b: ");
double b = Convert.ToDouble(Console.ReadLine());
System.Console.Write("c: ");
double c = Convert.ToDouble(Console.ReadLine());

Triangle triangle = new Triangle(a, b, c);

System.Console.WriteLine($"Площадь треугольника по трем сторонам: {triangle.Area()}");

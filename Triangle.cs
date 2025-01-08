class Triangle : IFigure
{
    // double a;
    // double b;
    // double c;
    public Triangle(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }
    public double a { get;  set; }
    public double b { get;  set; }
    public double c { get;  set; }
    public double Area()
    {
        double semiperimeter = (a + b + c) / 2;
        return Math.Sqrt(semiperimeter * (semiperimeter - a) * (semiperimeter - b) * (semiperimeter - c));
    }
    public bool isRightTriangle()
    {
        double max;
        if (a > b && a > c) 
        {
            max = a;
            if (max*max == b*b + c*c) return true;
            else return false;
        }
        else if (b > a && b > c) 
        {
            max = b;
            if (max*max == a*a + c*c) return true;
            else return false;
        }
        else if (c > a && c > b) 
        {
            max = c;
            if (max*max == a*a + b*b) return true;
            else return false;
        }
        else return false;
    } 
}
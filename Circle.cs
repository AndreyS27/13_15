class Circle : IFigure
{
    public Circle(double radius)
    {
        this.Radius = radius;
    }
    public double Radius { get; set; }

    public double Area()
    {
        return Math.PI * this.Radius * this.Radius;
    }
}
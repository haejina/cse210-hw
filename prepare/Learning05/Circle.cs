using System;

public class Circle : Shape
{
    private double _radius;
    
    public Circle(string color, double raduis) : base(color)
    {
        _radius = raduis;
    }

    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
}
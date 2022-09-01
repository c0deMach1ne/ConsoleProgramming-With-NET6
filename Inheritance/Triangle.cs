class Triangle : Shape, IShape
{
    public Triangle()
    {

    }

    public Triangle(double hypotenuese)
    {
        Hypotenuese = hypotenuese;
    }

    public Triangle(int height, int length, double hypotenuese)
    {
        Height = height;
        Length = length;
        Hypotenuese = hypotenuese;
    }

    public double Hypotenuese { get; set; }

    public double GetArea()
    {
        return .5 * Length * Height;
    }
}
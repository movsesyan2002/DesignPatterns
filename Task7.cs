interface IShape {
    void Area();
    IShape Clone();
}


class Circle : IShape {

    public int Radius { get; set; }

    public Circle(int radius) {
        this.Radius = radius;
    }

    public void Area() {

        Console.WriteLine($"Area of circle is {Math.PI * Math.Pow(Radius,2)}");

    }

    public IShape Clone() {
        return new Circle(Radius);
    }
}

class Square : IShape {

    public int Side { get; set; }

    public Square(int Side) {
        this.Side = Side;
    }

    public void Area() {

        Console.WriteLine($"Area of square is {Math.Pow(Side,2)}");

    }

    public IShape Clone() {
        return new Square(Side);
    }
}

class Rectangle : IShape {

    public int Width { get; set; }
    public int Height { get; set; }

    public Rectangle(int width, int height) {
        this.Width = width;
        this.Height = height;
    }

    public void Area() {

        Console.WriteLine($"Area of rectange is {Width * Height}");

    }

    public IShape Clone() {
        return new Rectangle(Width,Height);
    }
}
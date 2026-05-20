// class Figure
// {
//     public double x { get; set; }
//     public double y { get; set; }

//     public Figure()
//     {
        
//     }

//     public Figure(double a, double b)
//     {
//         x = a;
//         y = b;
//     }

//     public void Show()
//     {
//         WriteLine("Figure: x={0}, y={1}", x, y);    
//     }

//     public virtual double Area()
//     {
//         return 0;
//     }
// }

// class Circle : Figure
// {
//     protected double _r;

//     public Circle()
//     {
        
//     }
//     public Circle(double a, double b, double c) : base(a,b)
//     {
//         if (c>0) _r = c;
//     }
    
//     public double r
//     {
//         get { return _r; }
//         set { if (value > 0) _r = value; }
//     }

//     public new void Show()
//     {
//         WriteLine("Circle: x={0}, y={1}, r={2}", x, y, r);    
//     }

//     public override double Area()
//     {
//         double area;
//         area = (double)(Math.PI * _r * _r);
//         return area;
//     }
// }

// class Square: Figure
// {
//     protected double _d;

//     public Square()
//     {
    
//     }

//     public Square(double a, double b, double c) : base(a,b)
//     {
//         if (c>0) _d = c;
//     }

//     public double d
//     {
//         get { return _d; }
//         set { if (value > 0) _d = value; }
//     }

//     public new void Show()
//     {
//         WriteLine("Square: x={0}, y={1}, d={2}", x, y, d);
//     }

//     public override double Area()
//     {
//         double area;
//         area = (_d * _d);
//         return area;
//     }
// }

class Program
{
    static void Main(string[] args)
    {
        // Figure a = new Figure(4,5);
        // Circle k = new Circle(4,5,10);
        // Square s = new Square(4,5,5);
        Animal baseanimal = new Animal("baseanimal", 5);
        baseanimal.Show();
        baseanimal.Voice();
        ReadKey();

        Dog alphadog = new Dog("alphadog", 3, "doggy");
        alphadog.Show();
        alphadog.Voice();
        ReadKey();

        Cat littlecat = new Cat("littlecat", 2, "black-orange");
        littlecat.Show();
        littlecat.Voice();
        ReadKey();

        WriteLine("Urgay!");
    }
}
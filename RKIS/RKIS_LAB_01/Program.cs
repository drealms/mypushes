// using System.Drawing;

// class Programm
// {
//     public static Main()
//     {
//         Point pt = new Point();
//         pt.X = 3;
//         pt.Y = 4;
//         pt.show();
//         double d = pt.dist();
//         WriteLine($"Distance to point = {d}.");
//         ReadKey();
//     }
// }

// class Point
// {
//     private int x;
//     private int y;

//     public int X
//     {
//         get
//         {
//             return x;
//         }

//         set
//         {
//             if (value > 0) x = value
//         }
//     }

//     public int Y
//     {
//         get
//         {
//             return y;
//         }

//         set
//         {
//             if (value > 0) y = value;
//         }
//     }

//     public Point()
//     {
//         X = 0;
//         Y = 0;
//     }

//     public Point(int a, int b)
//     {
//         X = a;
//         Y = b;
//     }

//     public double dist()
//     {
//         double ds = Math.Sqrt(x * x + y * y);
//         return ds;
//     }

//     public void show()
//     {
//         WriteLine($"Point: x = {X}, y = {Y}");
//         return;
//     }
// }

using System.Reflection.Metadata.Ecma335;

class Program
{
    public static int Main()
    {
        Unit defunit = new Unit();
        defunit.HP = 150;
        defunit.MP = 70;
        defunit.Attack = 20;
        defunit.Show();
        WriteLine("Test");
        Box box1 = new Box();
        box1.Height = 3;
        box1.Width = 2;
        box1.Length = 5;
        box1.Show();
        WriteLine($"Volume: {box1.Volume()}");
        return 0;
    }
}

class Unit
{
    private int hp;
    private int mp;
    private int attack;
    public int HP
    {
        get
        {
            return hp;
        }
        set
        {
            if (value > 0) hp = value;
        }
    }

    public int MP
    {
        get
        {
            return mp;
        }
        set
        {
            if (value > 0) mp = value;
        }
    }

    public int Attack
    {
        get
        {
            return attack;
        }
        set
        {
            if (value > 0) attack = value;
        }
    }

    public Unit()
    {
        HP = 100;
        MP = 50;
        Attack = 10;
    }

    public Unit(int hp, int mp, int attack)
    {
        HP = hp;
        MP = mp;
        Attack = attack;
    }

    public void Show()
    {
        WriteLine($"Unit stats: HP = {HP}, MP = {MP}, Attack = {Attack}");
        return;
    }
}

using System.Data;
using System.Security.Cryptography.X509Certificates;

public class Mat
{
    public double value;
    public double Abs
    {
        get
        {
            return value;
        }
        set
        {
            if (value < 0)
            {
                System.Console.WriteLine(value * (-1));
            }
        }
    }


    public float Abs()
    {
        get
        {
            return value;
        }
        set
        {
            if (value < 0)
            {
                System.Console.WriteLine(value * (-1));
            }
        }
    }

    public int Abs()
    {
        get
        {
            return value;
        }
        set
        {
            if (value < 0)
            {
                System.Console.WriteLine(value * (-1));
            }
        }
    }
    public double Pow()
    {
        get
        {
            return value;
        }
        set
        {
            int v = (Math.Pow = (x, y));
            System.Console.WriteLine($"{v}");

        }
    }
    public double Sqrt()
    {
        get
        {
            return value;
        }
        set
        {
            int s = (Math.Sqrt = (d));
            System.Console.WriteLine($"{d}");

        }
    }
    public int Max(var val1 in val2)
    {
        get
        {
            return value;
        }
        set
        {
            int a = (Math.Max(a));
            System.Console.WriteLine($"{a}");

        }
    }

     public int Min()
    {
        get
        {
            return value;
        }
        set
        {
            foreach (var val1 in val2)
            {
                
            }
            int w = (Math.Min(w));
            System.Console.WriteLine($"{w}");

        }
    }
}

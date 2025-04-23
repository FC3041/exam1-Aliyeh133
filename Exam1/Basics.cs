namespace Exam1;

public class Q1_Add
{
    public int a {get; set;}
    public int b {get; set;}

    public Q1_Add(int n1 , int n2)
    {
        a = n1 ;
        b = n2 ;
    }

    public static int Add(int a,int b)
    {
        return a+b ;
    }
}

public class Basics
{
    public int a {get; set;}
    public int b {get; set;}

    public Basics(int n1 , int n2)
    {
        a = n1 ;
        b = n2 ;
    }

    public static void Q2MultiplyAndReset(ref int a , ref int b)
    {
        int mul = a*b ;
        a = mul ;
        b = 1 ;
    }

}



public class Q4Person
{
    public string Name {get; set;}
    public int Age {get; set;}

    public Q4Person(string name , int age)
    {
        Name = name ;
        Age = age ;
    }

    public string Introduce()
    {
        return $"Hello, my name is {this.Name} and I am {this.Age} years old." ;
    }
}


public class Q6Temperature
{
    private double celsius;
    private double fahrenheit;

    public double Celsius 
    {
         get => celsius;
         set
         {
            celsius = value ;
            fahrenheit = (value*9/5)+32 ;
         } 
    }

    public double Fahrenheit
    {
         get => fahrenheit;
         set
         {
            fahrenheit = value;
            celsius = (value-32)*5/9 ;
        } 
    }
}

public interface IShape
{
    public double GetArea();
    public double GetPerimeter();
}

public class Q7Circle : IShape
{
    public double radius {get; set;}

    public Q7Circle(double r)
    {
        radius = r ;
    }

    public double GetArea()
    {
        return radius*radius*Math.PI ;
    }

    public double GetPerimeter()
    {
        return 2*radius*Math.PI ;
    }
}

public class Q7Rectangle : IShape
{
    public double Len {get; set;}
    public double Wid {get; set;}

    public Q7Rectangle(double l , double w)
    {
        Len = l ;
        Wid = w ;
    }

    public double GetArea()
    {
        return Len*Wid ;
    }

    public double GetPerimeter()
    {
        return 2*(Len+Wid) ;
    }
}

public class ShapeUtils
{
    public static double Q7TotalArea(IShape[] shapes)
    {
        double total = 0 ;
        foreach(var c in shapes)
            total += c.GetArea() ;
        return total ;
    }
}

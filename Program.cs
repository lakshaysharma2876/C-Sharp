using System;
using System.Diagnostics.Metrics;
using System.Security.Cryptography;



class Program
{
    public static void Counter(int x)
    {
        Console.WriteLine("Passing value of x : " + x);
    }

    public static void CounterRef(ref int x)
    {
        x += 50;
        Console.WriteLine("Updating value of x using reference : " + x);
    }

    public static void CounterOut(out int x)
    {
        x = 50;
        Console.WriteLine("This acts as a return statement and we pass value to it : " + x);
    }


    static public void Main(string[] args)
    {
        int x = 10;

        Console.WriteLine("Initial value of x : " + x);
        Counter(x);
        CounterRef(ref x);

        Console.WriteLine("value after updation is : " + x);

        int OutputValue;
        CounterOut(out OutputValue);
    }
}
using System;
using System.Linq;
using System.Threading;

public delegate void TimerDelegate(double interval); // For example 3.2 seconds
public class Timer
{
    public static void SampleMethod(double interval)
    {
        double interv = interval * 1000;
        Thread.Sleep((int)interv);
        Console.WriteLine("This is task No 7.");

    }
    static void Main()
    {
        TimerDelegate timer = new TimerDelegate(SampleMethod);

        while (true)
        {
            timer(2.0);
        }

    }
}


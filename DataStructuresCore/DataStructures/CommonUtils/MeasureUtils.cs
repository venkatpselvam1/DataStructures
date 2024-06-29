namespace CommonUtils;

using System;
using System.Diagnostics;

public class MeasureUtils
{
    // public static void Main(string[] args)
    // {
    //     // Example usage
    //     MeasureTime(() => ExampleMethod());
    // }

    public static void MeasureTime(Action methodToMeasure)
    {
        Stopwatch stopwatch = new Stopwatch();
        
        // Start the stopwatch before the method execution
        stopwatch.Start();
        
        // Execute the method
        methodToMeasure();
        
        // Stop the stopwatch after the method execution
        stopwatch.Stop();
        
        // Get the elapsed time as a TimeSpan value
        TimeSpan ts = stopwatch.Elapsed;
        
        // Format and display the elapsed time
        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime);
    }

    public static void ExampleMethod()
    {
        // Simulate some work with a delay
        System.Threading.Thread.Sleep(2000);
    }
}
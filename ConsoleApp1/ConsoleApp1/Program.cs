using System;


public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("To jest trzecia modyfikacja");

        var arr = new int[] { 10, 20, 40 };
        CalculateAndPrintAverage(arr);

    }

    public static void CalculateAndPrintAverage(int[] arr)
    {
        double avg = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            avg += arr[i];
        }
        avg /= arr.Length;
        Console.WriteLine("Average: " + avg);
    }
}

using System;


public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("To jest trzecia modyfikacja");

        var arr = new int[] { 10, 20, 40 };
        CalculateAndPrintAverage(arr);
        CalculateAndPrintMax(arr);

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

    public static void CalculateAndPrintMax(int[] arr)
    {
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        Console.WriteLine("Max: " + max);
    }
}

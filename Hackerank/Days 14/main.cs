using System;
using System.Linq;

class Difference
{
    private int[] elements;
    public int maximumDifference;

    public Difference(int[] a)
    {
        elements = a;
    }

    public void computeDifference()
    {
        int max = elements.Max();
        int min = elements.Min();

        maximumDifference = max - min;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese los numeros separados por espacio:");

        int[] arr = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        Difference d = new Difference(arr);

        d.computeDifference();

        Console.WriteLine("La diferencia maxima es: " + d.maximumDifference);

        Console.ReadKey();
    }
}
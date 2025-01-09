// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        List<int> a = new List<int> { 190, 420, 550, 660, 670 };
        var (p, s) = HotelStopsMinPenalty(a);
        Console.WriteLine($"Stops=[{string.Join(", ", a)}] Minimum penalty = {p} sequence = {string.Join(", ", s)}");

        a = new List<int> { 10, 200, 270, 430, 500 };
        (p, s) = HotelStopsMinPenalty(a);
        Console.WriteLine($"Stops=[{string.Join(", ", a)}] Minimum penalty = {p} sequence = {string.Join(", ", s)}");
    }

    static (int, List<int>) HotelStopsMinPenalty(List<int> a)
    {
        // Let's define a0 = starting position = 0
        List<int> a_ = new List<int>(a);
        a_.Insert(0, 0);
        int[] P = new int[a_.Count];
        int[] s = new int[a_.Count];

        for (int i = 1; i < a_.Count; i++)
        {
            P[i] = int.MaxValue; // initialize to infinity
            for (int j = 0; j < i; j++)
            {
                // Keep track of the previous stop that minimizes penalty at mile post i
                int p = P[j] + (200 - (a_[i] - a_[j])) * (200 - (a_[i] - a_[j]));
                if (p < P[i])
                {
                    s[i] = j;
                    P[i] = p;
                }
            }
        }

        List<int> stops = new List<int>();
        int k = a_.Count - 1;
        while (k > 0)
        {
            stops.Add(k);
            k = s[k];
        }

        stops.Reverse();
        return (P[a_.Count - 1], stops);
    }
}
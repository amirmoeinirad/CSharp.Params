
// Amir Moeini Rad
// September 2025

// Main Concept: Using 'params' keyword to pass a variable number of arguments to a method.

using System;

public class AddEm
{
    // 'params' allows you to pass a variable number of arguments to a method.
    public static long Add(params int[] args)
    {
        int ctr;
        long Total = 0;

        for(ctr = 0; ctr < args.Length; ctr++)
        {
            Total += args[ctr];
        }

        return Total;
    }


    // 'params' can actually be used with any data type.
    public static void PrintAnything(params object[] args)
    {
        int ctr;

        for (ctr = 0; ctr < args.Length; ctr++)
        {
            Console.WriteLine("Argument {0} is {1}.", ctr+1, args[ctr]);
        }

        Console.WriteLine();
    }
}


/////////////////////////////////////////////////////////////////////


class MyApp
{
    public static void Main(string[] args)
    {
        Console.WriteLine("-------------------------");
        Console.WriteLine("Params keyword in C#.NET.");
        Console.WriteLine("-------------------------\n");

        long Total;

        Total = AddEm.Add(1);
        Console.WriteLine("Total of (1) = {0}", Total);

        Total = AddEm.Add(1, 2);
        Console.WriteLine("Total of (1,2) = {0}", Total);

        Total = AddEm.Add(1, 2, 3);
        Console.WriteLine("Total of (1,2,3) = {0}", Total);

        Total = AddEm.Add(1, 2, 3, 4);
        Console.WriteLine("Total of (1,2,3,4) = {0}", Total);


        Console.WriteLine();


        AddEm.PrintAnything(1);

        AddEm.PrintAnything("Amir");

        AddEm.PrintAnything(1234567L, 12.3658M, 'A');
    }
}
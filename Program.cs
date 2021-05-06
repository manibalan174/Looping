using System;

namespace pattern
{
    class Program
    {
        // public void Add(int Values1, int values2)
        // {
        //         int Answer= Values1 + values2;
        //         Console.WriteLine("Addtion:"+Answer);
        // }
        //   public void Subraction(int Values1, int values2)
        // {
        //         int Answer= Values1 - values2;
        //         Console.WriteLine("Subraction:"+Answer);
        // }
        //    public void Multiplaction(int Values1, int values2)
        // {
        //         int Answer= Values1 * values2;
        //         Console.WriteLine("Multiplaction:"+Answer);
        // }
        //   public void Division(int Values1, int values2)
        // {
        //         int Answer= Values1 * values2;
        //         Console.WriteLine("Division:"+Answer);
        // }
        static void Main(string[] args)
        {
           
                    // ----Add,Subraction,Multiplaction,Divsion method---
        // Program Sum = new Program();
        //   Console.WriteLine("Enter X and Y values");
        //   int X=Convert.ToInt32(Console.ReadLine());
        //   int y=Convert.ToInt32(Console.ReadLine());
        //    Sum.Add(X,y);
        //    Sum.Subraction(X,y);
        //    Sum.Multiplaction(X,y);
        //    Sum.Division(X,y);

                 // ---Pattern Frist----
            //  for (int row = 8; row >= 1; --row)
            // {
            // for (int col = 1; col <=  ; ++col)
            // {
            //    System.Console.Write("*");
            // }
    
            // System.Console.WriteLine("");
            // }

            // ---Pattern Second----
             for (int row = 1; row <= 8; ++row)
            {
            for (int col = 1; col <= row; ++col)
            {
               System.Console.Write("*");
            }
            System.Console.WriteLine();
            }


          //  ---Demo Program----
        //     Console.WriteLine("Hello World!");
        //    string Age = Console.ReadLine();
           //int Ages= 1 + Age;
            //Console.WriteLine(Age);
        }
    }
}

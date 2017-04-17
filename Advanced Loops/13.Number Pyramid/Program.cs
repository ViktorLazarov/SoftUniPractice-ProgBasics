using System;


namespace Task13_NumberPyramid
{
    class NumberPyramid
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var num = 1;

            for (var red = 1; red <= n; red++)
            {
                for (var colona = 1; colona <= red; colona++)
                {
                    if (colona >= 1)
                    {
                        Console.Write(num);
                        Console.Write(" ");
                        num++;
                    }
                    if (num > n) break;
                }
                Console.WriteLine();
                if (num > n) return;
            }
        }
    }
}
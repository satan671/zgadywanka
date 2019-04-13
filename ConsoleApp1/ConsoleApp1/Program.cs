using System;
using System.IO;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            TextReader input = StringReader(test);
            //TextReader input = Console.In;

            int n = int.Parse(Console.WriteLine());
            int[] s = new int[n];
            string[] ss = input.ReadLine().Split( new char[] (' '), StringSplitOptions.RemoveEmptyEntries);
            //Debug.Assert(s.lenght == ss.Length);
            for (int i = 0; i < n; i++)
               s[i] = int.Parse(ss[i]);

            string[] qq = input.ReadLine().Split( new char[] (' '), StringSplitOptions.RemoveEmptyEntries);
            //Debug.Assert(q.lenght == qq.Length);
            for (int i = 0; i < n; i++)
                q[i] = int.Parse(ss[i]);


            string wynik = "";
        for(int i = 0; i< Math.Min(n, m); i++)
            {
                if (s[i] == qq[i])
                    wynik += (i) + ' ';
            }
            Console.WriteLine(wynik);

        }
        static string test = @"5
- 2 - 2 - 1 1 4 
6
-3 -2 -1 1 2 3";
        static string test1 = "5\n- 2 - 2 - 1 1 4\n 6\n-3 -2 -1 1 2 3";
    }
}

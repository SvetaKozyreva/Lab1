﻿namespace Lab1_Example3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "біологія алгебра історія географія геометрія";
            string c = "і";
            string[] a;
            a = s.Split(' ');
            int i;
            for(i = 0; i < a.Length; i++)
            {
                int t = a[i].IndexOf(c);
                if (t != -1) Console.WriteLine(a[i]);
            }
        }
    }
}

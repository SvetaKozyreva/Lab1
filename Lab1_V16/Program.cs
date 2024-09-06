using System.ComponentModel.DataAnnotations;

namespace Lab1_V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "dhhf.dwerffc%";
            int t = s.IndexOf(".");
            int i, k = 0;
            for (i = 0; i <= t; i++)
            {
                if (char.IsLetter(s[i])) k++;
            }
            int length = s.Length;
            int count = length - k -1;
            Console.WriteLine(count);
        }
    }
}

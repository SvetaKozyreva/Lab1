using System.ComponentModel.DataAnnotations;

namespace Lab1_V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //task1
            string str = "gaaafddr.gav.baagf.v";
            char letter = 'a';
            int indx = str.IndexOf(".");
            int i, k = 0;
            for (i = 0; i <= indx; i++)
            {
                if (str[i] == letter) k++;
            }
            Console.WriteLine($"Task 1: k = {k}");

            //task2
            string S = "Добрий ранок, ранок добрий";
            string S1 = "ранок";
            string S2 = "день";

            Console.WriteLine($"Task 2:\n{S}");

            int indx2 = S.LastIndexOf(S1);
            S = S.Remove(indx2, S1.Length);
            S = S.Insert(indx2, S2);

            Console.WriteLine($"{S}");

            //task3
            string str3 = "тато кіт мама пес халабуда";
            string[] words = str3.Split(' ');

            Console.WriteLine("Task3:");

            foreach (string word in words)
            {
                char letter3 = word[0];
                int count;
                count = word.Count(sth => sth == letter3);

                /*count = 0;
                foreach (char sth in word)
                {
                    if (sth == letter3) { count++; }*/

                if (count > 1) { Console.WriteLine(word); }
            }

            //task4
            string str4 = "тато кіт мама пес халабуда";
            string[] words4 = str4.Split(' ');
            string newnewstr4 = "";

            for (int d = 0; d < words4.Length; d++)
            {
                if ((d + 1) % 2 != 0)
                {
                    char[] newstr4 = words4[d].ToCharArray();
                    Array.Reverse(newstr4);
                    newnewstr4 += new string(newstr4) + " ";
                }
            }
            Console.WriteLine($"Task4: {newnewstr4}");
        }
    }
}

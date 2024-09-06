namespace Lab1_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Example 1
            string s = "Dfg+t5-r7y;asd*s34;rt";
            int t = s.IndexOf(";");
            int i, k = 0;

            for (i = 0; i <= t; i++)
            {
                if (char.IsLetter(s[i])) k++;
            }

            Console.WriteLine($"Example 1: {k}");

            //Example 2
            string s2 = "АУАУАПАУК";
            int i2 = 0;

            do
            {
                string ss = s2.Substring(i2, 2);
                if (ss == "АУ")
                {
                    s2 = s2.Insert(i2, "О"); i2 = i2 + 3;
                }
                else
                {
                    i2++;
                };
            }
            while (i2 < s2.Length - 1);

            Console.WriteLine($"Example 2: {s2}");

            //Example 3
            string s3 = "біологія алгебра історія географія геометрія";
            string c3 = "і";
            string[] a3;

            a3 = s3.Split(' ');
            int i3;

            Console.WriteLine("Example 3: ");

            for (i3 = 0; i3 < a3.Length; i3++)
            {
                int t3 = a3[i3].IndexOf(c3);
                if (t3 != -1) Console.WriteLine(a3[i3]);
            }

            //Example 4
            string s1_4 = "біологія алгебра історія географія геометрія";
            string[] a4;

            a4 = s1_4.Split(' ');
            Array.Reverse(a4);
            string s2_4 = string.Join(" ", a4);

            Console.WriteLine($"Example 4: {s2_4}");
        }
    }
}

namespace Lab1_Example4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "біологія алгебра історія географія геометрія";
            string[] a;
            a = s1.Split(' ');
            Array.Reverse(a);
            string s2 = string.Join(" ", a);
            Console.WriteLine(s2);
        }
    }
}

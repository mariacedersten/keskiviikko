// 2.Tulostaa konsoliin kahden numeron summan 

using System.Diagnostics.CodeAnalysis;

namespace keskiviikko
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 7;

            int num3 = num1 + num2;

            Console.WriteLine("Summa =:" + num3);
        }
    }
}
/*
using System.Diagnostics.CodeAnalysis;

namespace keskiviikko
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna numero1");
            String Nums1 = Console.ReadLine();
            int num1 = int.Parse(Nums1);

            Console.WriteLine("Anna numero2");
            String Nums2 = Console.ReadLine();
            int num2 = int.Parse(Nums2);

            int num3 = num1 + num2;

            Console.WriteLine("Summa =:" + num3);
        }
    }
}
*/
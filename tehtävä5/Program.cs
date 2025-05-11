// 5.Lukee numeron konsolista ja tulostaa sen numeron kymmenen kertotaulun. 

namespace keskiviikko
{
    internal class Program3
    
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna numero");
            String Nums1 = Console.ReadLine();
            int num1 = int.Parse(Nums1);

            for (int i = 1; i <= 10; i++)
            {
                int res = num1 * i;
                Console.WriteLine(res);
            }


        }
    }
}

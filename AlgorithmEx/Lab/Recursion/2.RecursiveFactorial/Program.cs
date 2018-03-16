namespace _2.RecursiveFactorial
{
    using System;
    using System.Linq;

    class Program
    {
        static long Facturial(int num)
        {
            //Pre-actions
            if (num == 0)
            {
                return 1;
            }
            //Recursive calls
            return num * Facturial(num - 1);
            //Post-actions
        }

        static void Main(string[] args)
        {

            var num = int.Parse(Console.ReadLine());

            var res = Facturial(num);
            Console.WriteLine(res);
        }
    }
}

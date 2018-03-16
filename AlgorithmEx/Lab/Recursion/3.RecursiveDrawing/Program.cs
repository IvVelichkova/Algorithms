namespace _3.RecursiveDrawing
{
    using System;

    class Program
    {

        static void Print(int index)
        {
            if (index==0)
            {
                return ;
            }

            Console.WriteLine(new string('*',index));
           Print(index - 1);
            Console.WriteLine(new string('#',index));

        }
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            Print(num);
        }
    }
}

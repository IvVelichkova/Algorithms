namespace _4.Generating0._1Vectors
{
    using System;

    class Program
    {

        static void Generate(int index, int[] arr)
        {
            if (index == arr.Length)
            {
                Console.WriteLine(string.Join("", arr));

            }
            else
            {
                for (int i = 0; i <= 1; i++)
                {
                    arr[index] = i;
                    Generate(index + 1, arr);
                }
            }
        }
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var arr =new int[num]; 
            Generate(0, arr);
        }
    }
}

namespace _1.RecursiveArraySum
{
    using System;
    using System.Linq;
   public class Program
    {
        static int Sum(int[] arr,int index)
        {
            if (index==arr.Length)
            {
                return 0;
            }
            var current = arr[index] + Sum(arr, index + 1);
            return current;
        }


        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
           
            var res = Sum(nums, 0);
            Console.WriteLine(res);
        }
    }
}

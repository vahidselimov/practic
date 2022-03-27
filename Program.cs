using System;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            arr();
        }
        public static void arr()
        {
            int[] arr = { 9, 12, 34, 21, 56, 78, 43, 23, 90, 65,90 };
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];

                }
            }
            Console.WriteLine(max);
        }



    }




}











































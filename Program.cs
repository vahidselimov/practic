using System;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            Console.WriteLine(sentence2(sentence));
        }
        public static bool sentence2(string sentence)
        {

            if (true)
            {
                bool hasDigit = false;
                bool hasUpper = false;
                bool hasLower = false;
                foreach (char item in sentence)
                {
                    if (char.IsDigit(item))
                    {
                        hasDigit = true;
                        continue;

                    }
                    if (char.IsUpper(item))
                    {
                        hasUpper = true;
                        continue;

                    }
                    if (char.IsLower(item))
                    {
                        hasLower = true;
                        continue;

                    }
                }
                bool result = hasDigit && hasLower && hasUpper;
                return result;
               
            }
            return false;
           





            




        }



    }




}











































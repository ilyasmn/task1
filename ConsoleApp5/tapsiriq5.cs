using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = -10;
            int b =0;

            try
            {
                if (a % b == 0)

                    Console.WriteLine("tam bolunur");


                else

                { Console.WriteLine("tam bolunmur"); }
            }
            catch (Exception)
            {
                Console.Write("0 a bolme yoxdur");

            }


            
        }


    }
}

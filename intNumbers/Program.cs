using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Write a number");
                int number = Int32.Parse(Console.ReadLine());
                for (int i = 1; i <= number; i++)
                {
                    if ((number % i) == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
                Console.ReadLine();
            }
            catch (Exception)
            {

                Console.WriteLine("Error");
            }
            
        }
    }
}

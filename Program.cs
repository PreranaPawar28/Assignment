using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int N = Convert.ToInt32(Console.ReadLine());
            if (N % 3 == 0 && N % 5 == 0)
            {
                Console.WriteLine("NUM35");
            }
            else if(N % 5 == 0){
                Console.WriteLine("NUM5");
            }
            else if(N % 3 == 0)
            {
                Console.WriteLine("NUM3");
            }
            else
            {
                Console.WriteLine("Number does not meet any condition");
            }
            Console.ReadLine();
        }
    }
}

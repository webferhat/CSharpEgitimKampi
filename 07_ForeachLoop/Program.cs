using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            int[] numbers = { 45, 22, 365, 88, 99 };

            foreach (int i in numbers)
            {
                if(i % 2 == 0) { 
                    Console.WriteLine(i);
                }
            }
            #endregion

            Console.Read();
        }
    }
}

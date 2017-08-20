/*5.	Дано целое число N (> 0), найти число, полученное при прочтении числа N справа налево.
 *  Например, если было введено число 345, то программа должна вывести число 543.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            string forLength;
            Console.WriteLine("Введите целое число(число>0): ");
            forLength=Console.ReadLine();
            number = forLength.Length-1;  
            for(int i=0 ; number>=i; number--)
            {
                Console.Write(forLength[number]);
            }
            Console.ReadLine();
        }
    }
}

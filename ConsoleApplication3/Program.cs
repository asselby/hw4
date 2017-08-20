/*4.	Даны целые положительные числа A и B (A < B). Вывести все целые числа от A до B включительно; каждое число
 *  должно выводиться на новой строке; при этом каждое число должно выводиться количество раз, равное его значению.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;
            Console.WriteLine("Введите целые положительные числа А и В(А<B):  ");
            Int32.TryParse(Console.ReadLine(), out firstNumber);
            Int32.TryParse(Console.ReadLine(), out secondNumber);
            for (; firstNumber <= secondNumber; firstNumber++) {
                for (int i=0; firstNumber>i;i++ )
                {
                    Console.Write(firstNumber);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

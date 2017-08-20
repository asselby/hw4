/*1.	Написать программу, которая считывает символы с клавиатуры, пока не будет введена точка.
 *  Программа должна сосчитать количество введенных пользователем пробелов.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication75
{
    class Program
    {
        static void Main(string[] args)
        {
           int count = 0;
            string point;
            Console.WriteLine("Введите символы:");
            do
            {
                point = Console.ReadLine();
                count++;

            } while (point != ".");
            Console.WriteLine("Количество символов: {0}", count);
            Console.ReadLine();
        }
    }
}

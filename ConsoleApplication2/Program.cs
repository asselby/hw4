/*3.	Числовые значения символов нижнего регистра в коде ASCII отличаются от значений символов верхнего регистра 
 * на величину 32. Используя эту информацию, написать программу, которая считывает с клавиатуры и конвертирует 
 * все символы нижнего регистра в символы верхнего регистра и наоборот.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символ в верхнем или нижнем регистре: ");
            char letters = Convert.ToChar(Console.ReadLine());
                  if (letters >= 'a' && letters <= 'z')
                {
                    int number = Convert.ToInt32(letters);
                    number -= 32;
                    Console.WriteLine(Convert.ToChar(number));
                }
                else if (letters >= 'A' && letters <= 'Z')
                {
                    int number = Convert.ToInt32(letters);
                    number += 32;
                    Console.WriteLine(Convert.ToChar(number));
                }
                else if (letters >= 'А' && letters <= 'Я')
                {
                    int number = Convert.ToInt32(letters);
                    number += 32;
                    Console.WriteLine(Convert.ToChar(number));                 
                }
                else if (letters >= 'а' && letters <= 'я')
                {
                    int number = Convert.ToInt32(letters);
                    number -= 32;
                    Console.WriteLine(Convert.ToChar(number));
                }

                else
                    Console.WriteLine("Попробуйте еще раз!");
                
            
            Console.ReadLine();
        }
    }
}

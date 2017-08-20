/*2.	Ввести с клавиатуры номер трамвайного билета (6-значное число) и проверить является ли данный билет
 *  счастливым (если на билете напечатано шестизначное число, и сумма первых трёх цифр равна сумме последних 
 *  трёх, то этот билет считается счастливым).*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numLuck;
            int summFirst;
            int summSecond;
            Console.WriteLine("Введите шестизначное число: ");
            numLuck = Int32.Parse(Console.ReadLine());
            summFirst = numLuck / 1000;
            summSecond = numLuck % 1000;
            if (summSecond == summFirst)
            {
                Console.WriteLine("Ваш билет является счастливым!!!");
            }
            else
                Console.WriteLine("Ваш билет не является счастливым!!!");
            Console.ReadLine();
        }
    }
}

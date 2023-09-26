using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SavenkovaME.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.SavenkovaME.Sprint0.TaskReview.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число = ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число = ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите третье число = ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Значение данного выражения ({num1} + {num2} + {num3}) * 5 = " + DataService.Calc(num1, num2, num3));
            Console.ReadKey();
        }
    }
}

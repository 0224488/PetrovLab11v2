using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using LabStructura;

namespace PetrovLab11v2
{
    class Program
    {
        //Разработать структуру для решения линейного уравнения 0=kx+b.
        //Коэффициенты уравнения k, b реализовать с помощью полей вещественного типа.
        //Для решения уравнения предусмотреть метод Root. Создать экземпляр разработанной структуры.
        //Осуществить использование экземпляра в программе.
        static void Main(string[] args)
        {
            Boolean fault = true;
            L11 structL11 = new L11();
            try
            {
                Console.Write("Введите коэффициент k: ");
                structL11.ValK = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите коэффициент b: ");
                structL11.ValB = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Работа программы завершена из-за ошибки ввода данных. Для выхода нажмите любую клавишу");
                fault = false; 
            }
            if (fault) // Если ошибка сразу при вводе, то не продолжаем
            {
                structL11.Root();
                Console.WriteLine("Для выхода из программы нажмите любую клавишу");
                Console.ReadKey();
            }
            else
            {
                Console.ReadKey();
            }
        }
    }
}

using System;
using System.ComponentModel.Design;

namespace Delegates__events__and_lambdas
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        
        private static void Menu()
        {
            Console.WriteLine("Выберете операцию:");
            Console.WriteLine("1.Демонстрация делегата");

            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:
                    SimpleDelegates.WhatYime();
                    break;
                default:
                    Console.WriteLine("Неправильный выбор.");
                    break;
            }
            Menu();
        }
    }
}

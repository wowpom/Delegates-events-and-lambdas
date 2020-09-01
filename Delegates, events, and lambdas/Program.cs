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
            Console.WriteLine("2.Делегат с методом из другого класса");
            Console.WriteLine("3.Делегат с несколькими методами");
            Console.WriteLine("4.Пустой делегат");

            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:
                    SimpleDelegates.WhatYime();
                    break;
                case 2:
                    DelegatesMath.DelegatMath();
                    break;
                case 3:
                    TwoMethodsInDelegat.HelloHowAreYou();
                    break;
                default:
                    Console.WriteLine("Неправильный выбор.");
                    break;
            }
            Menu();
        }
    }
}

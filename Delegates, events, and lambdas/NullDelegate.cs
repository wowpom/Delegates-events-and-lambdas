using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates__events__and_lambdas
{
    delegate void ErrorDelegat();
    class NullDelegate
    {
        public static void NullInDelegate() 
        {
            ErrorDelegat errdel = null;
            Console.WriteLine("Вызов оператора");

            errdel?.Invoke();
            Console.WriteLine("Вызов завершен");
        }
    }
}

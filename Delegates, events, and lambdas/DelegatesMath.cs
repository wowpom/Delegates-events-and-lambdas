using System;

namespace Delegates__events__and_lambdas
{
    
    delegate int Operation(int x, int y);
    class DelegatesMath
    {
        public static void DelegatMath() 
        { 
            Math math = new Math();
            Operation operation = math.Sum;
            Console.WriteLine(operation(5, 3)+"\n");
        }

    }
}

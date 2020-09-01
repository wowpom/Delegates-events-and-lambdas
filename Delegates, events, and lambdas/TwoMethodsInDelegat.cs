using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace Delegates__events__and_lambdas
{
    delegate void SMS();
    class TwoMethodsInDelegat
    {
        public static void HelloHowAreYou()
        {
            SMS sms = Hello;
            sms += HowAreYou;
            sms += Hello;

            sms();
        }
        private static void Hello()
        {
            Console.WriteLine("Привет");
        }
        private static void HowAreYou()
        {
            Console.WriteLine("Как дела?");
        }
    }
}

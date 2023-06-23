using System;
using System.Collections.Generic;
using System.Text;

namespace Dotnet
{
    //public,internal,private,protected
    internal class Addition
    {
        public static void DoAddition()
        {
            int num=10, num2=8, result;
            result = num + num2;
            Console.WriteLine(result);
        }
        public int Intmethod()
        {
            int num = 10, num2 = 8, result;
            result = num + num2;
            return result;
        }
        public string stringmethod()
        {
            return "rajashri";
        }
        public bool boolmethod()
        {
            return true;
        }
    }
}

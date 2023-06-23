using System;

namespace Dotnet
{
    internal class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        //.net is software or product that came from microsoft  which
        //can be used to develop various kind of application
        //c,cpp-desktop application----c#
        //php,asp-web application
        //c#-object oriented programming langauge
        static void Main(string[] args)
        {
            Console.WriteLine("enter name");
            string name=Console.ReadLine();
            Console.WriteLine("enter address");
            string address=Console.ReadLine();
            Console.WriteLine("your name is "+name);
            Console.WriteLine("your name is {0} and address is {1}",name,address);
           
        }
    }
}

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
        //classname objectname=new classname();
        //objtname.methodname();
            Addition add=new Addition();
            Console.WriteLine(add.stringmethod());
            //classname.method();
            Addition.DoAddition();
        }
    }
}

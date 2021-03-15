using System;
using CallFunction;
namespace ConsoleApp1_Test
{

    class Program

    {
        public Program()
        {
            Console.WriteLine("Default Constructor.");
        }
        public Program(string a)
        {
            Console.WriteLine("Parameter Constructor." + Convert.ToString(a));
        }
        public static void Main(string[] args)
        {
            int  asd = 10;
            object b = asd;
            double ds;
            ds = (double)(int)b;
            Console.WriteLine(ds);




        }

    }


    public static class MyClass
    {
        public static int iCount;

        static MyClass()
        {

        }
        public static void someMethod()
        {

        }
    }

}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_Test
{

    abstract class AbsBus
    {
        //void Absbreak();

        public void engine()
        { 
        }
    }

    interface Ibus
    {
        void Ibreak();
        public void engine()
        {
        }
         
    }
    class InterfaceDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interface demo");
        }

    }
}

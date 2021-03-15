using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_Test
{

    abstract class student
    {

        public void studentName()
        {
            Console.WriteLine("Sunil Gadakari.");

        }
        public abstract void abstStudName();
    }

     
   
    abstract class bus
    {
        public virtual void breaks()
        {
            Console.WriteLine("break for bus");
        }

        public abstract void engine();
    }
    class volvo : bus

    {
        public   void breaks()
        {
            Console.WriteLine("break for bus");
        }

        public override  void engine()
        {
            Console.WriteLine("volvo engine - 100kmph");
        }

    }
    class tatabus : bus
    {
        public override void engine()
        {
            Console.WriteLine("volvo engine - 200kmph");
        }

    }

    class abstractClass
    {

        static void Main(string[] args)
        {
            //Console.WriteLine("Start Main");
            //abstractClass a = new abstractClass();
            //a.studentName();
            //a.abstStudName();

            volvo v = new volvo();
            v.breaks();
            v.engine();

            //bus b = new bus();




        }


    }
}

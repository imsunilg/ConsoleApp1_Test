using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace ConsoleApp1_Test.Study
{
    class car
    {
        protected string model;
        protected string color;
        protected string price;

        public void printCarInformation()
        {
            Console.WriteLine("Model : " + model);
            Console.WriteLine("Color : " + color);
            Console.WriteLine("Price : " + price);
        }
    }
    class Maruti : car
    {
        float mileage;
        void printMileage()
        {
            Console.WriteLine("Mileage : "+ mileage);

        }
        public static void Main(string[] args)
        {
           // List<dynamic> cars = new List<dynamic>();
            ArrayList cars =new ArrayList();
            cars.Add("Maruti");
            cars.Add("FORD");
            cars.Add("AUDI");
            cars.Add(10);
            cars.Add(10.5f);
            foreach (dynamic listCar in cars)
                Console.WriteLine(listCar);
            #region inheritance
            /*Maruti m = new Maruti();
            m.mileage = 22.5f;
            m.color = "Red";
            m.model = "RXT2842";
            m.price = "20Lac";
            m.printCarInformation();
            m.printMileage();  */
            #endregion inheritance

            #region array
            /*
            string[] carName = new string[5];// { "Maruti","BMW","FORD"};
            carName[0] = "H";
            carName[1] = "E";
            carName[2] = "L";
            carName[3] = "L";
            carName[4] = "O";
            for (int i = 0; i < carName.Length; i++)
            {
                Console.Write(carName[i]);
            }

            foreach (dynamic ch in carName)
            {
                Console.Write(ch);
            }
            */
            #endregion array
        }
    } 
}

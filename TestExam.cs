using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;
namespace ConsoleApp1_Test
{
    class TestExam
    { 
        static void Main(string[] args)
        { 

          char a=FirstNonRepeatedCharInString("ABCDACD");
             

            
            int i, j, diff, value, N;
            
            Console.WriteLine("Please Enter No of input Row's :");
            N=Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= N; i++)
            {
                diff = N - 1;  
                value = i;   
                for (j = 1; j <= i; j++)
                {
                    
                    Console.Write(" " + value);

                    value += diff;  
                    diff--;       
                }

                Console.WriteLine();
            } 
        }
        public static char FirstNonRepeatedCharInString(string str)
        {
            int i, j;
            bool isRepeted = false;
            char[] chars = str.ToCharArray();
            for (i = 0; i < chars.Length; i++)
            {
                isRepeted = false;
                for (j = 0; j < chars.Length; j++)
                {
                    if ((i != j) && (chars[i] == chars[j]))
                    {
                        isRepeted = true;
                        break;
 
                    }
                }
                if (isRepeted == false)
                {
                    return chars[i];
                }
            }
            return ' ';
        }

       
    }

}
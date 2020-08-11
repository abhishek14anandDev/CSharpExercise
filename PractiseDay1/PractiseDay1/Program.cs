using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseDay1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Loopping For
            //WAP to display 1 to n natural numbers

            int lastNaturalNumbers;

            Console.WriteLine("PLease enter the last natural number you want to display");

            lastNaturalNumbers = int.Parse(Console.ReadLine()); //45

            for(/*1.*/ int i = 1; /*2.*/ i <= lastNaturalNumbers; /*4.*/i++)
            {
                /*3.*/

                Console.WriteLine(i); 
            }
           // Console.ReadLine();

            //Looping While

            //WAP to display 1 to n natural numbers

            Addition addition = new Addition();
           Console.WriteLine(addition.AdditionMethod(23, 45));

            //Looping foreach



            Console.ReadKey();

           
        }
    }
}

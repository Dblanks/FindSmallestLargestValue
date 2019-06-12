using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Simple console application to find the smallest and largest number of a given set
 */
namespace FindSmallestValue
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables 
            int index = 10;
            int smallest = 0;
            int largest = 0;
            int inputNum = 0;

            for(int i = 0; i <= index; i++)
            {
                Console.WriteLine("Enter a number: ");
                inputNum = Int32.Parse(Console.ReadLine());

                //check for the first number assume it is the smallest/largest
                //else check if the number input is smaller/larger the previous
                if(i == 0)
                {
                    smallest = inputNum;
                    largest = inputNum;
                }else if(inputNum < smallest)
                {
                    smallest = inputNum;
                }else if(inputNum > largest)
                {
                    largest = inputNum;
                }
            }

            Console.WriteLine(" Smallest: {0} \n Largest:{1}", smallest, largest);
            Console.Read();

            



        }
    }
}

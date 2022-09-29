using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// William
// 09/28/2022
// Assignment 2

namespace Lecture_3_Float
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // float point numbers
            // for floating numbers, end with an f
            float sliceOfPizza = .25f;

            // for decimal, end with an m
            decimal dollarAmount = 1.52m;

            double coordinateX = 52.5;

            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();
            int usersNumber = int.Parse(userInput);

            Console.WriteLine(usersNumber + usersNumber);

            //int userNumber2 = int.Parse(Console.ReadLine());

            // casting

            // try / catch



        } // Main

    } // class

} // namespace

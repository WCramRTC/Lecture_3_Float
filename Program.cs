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


        } // Main

        public static void TryCatch()
        {
            int number = 0;
            try
            {
                // try / catch
                Console.Write("Please enter a whole number: ");
                string userInput = Console.ReadLine();
                number = int.Parse(userInput);

            } // End of try
            catch
            {
                Console.WriteLine("The format was invalid");
            }

            // try / catch

            Console.WriteLine(number);
        } // TryCatch

        public static void FloatAndParseExample()
        {

            // float point numbers
            // for floating numbers, end with an f
            float sliceOfPizza = .25f;

            // for decimal, end with an m
            decimal dollarAmount = 1.52m;

            double coordinateX = 52.5;

            //Console.Write("Enter a number: ");
            //string userInput = Console.ReadLine();
            //float usersNumber = float.Parse(userInput);

            //Console.WriteLine(usersNumber + usersNumber);

            //int userNumber2 = int.Parse(Console.ReadLine());

            // casting
            int a = 500;
            double b = a;
            Console.WriteLine(b);
            // From whole number to decimal is implict casting
            // Because the change is implied

            double c = 500.10;
            int d = (int)c;
            Console.WriteLine(d);

            // Assignment Operators
            int grade = 10;
            grade = grade + 5;
            grade = grade / 3;

            double price = 10;
            price = price + 3;
            price = price - 5;

            int gradeAO = 10;

            //
            double numOfStudents = 3;
            Console.WriteLine(numOfStudents);

            //numOfStudents = numOfStudents - 1;
            numOfStudents -= 1;
            Console.WriteLine(numOfStudents);

            numOfStudents += 3;
            Console.WriteLine(numOfStudents);

            // +=, -=, *=, /=, %=
            numOfStudents++; // This increments by 1
            numOfStudents--; // This decrements ( subtracts ) 1

        } //FloatAndParseExample


    } // class

} // namespace

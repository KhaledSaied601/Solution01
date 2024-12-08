using System;

namespace Project01
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region 1- Write a program that allows the user to enter a number then print it.

            //Console.WriteLine("Enter Number");


            //try
            //{

            //    int n = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine(n);
            //}
            //catch (Exception e)
            //{ Console.WriteLine(e); }

            #endregion


            #region 2- Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen 

            //string s = "Khaled";


            //int num;
            //try
            //{
            //     num = Convert.ToInt32(s);

            //    Console.WriteLine(num);

            //}
            //catch (Exception e) { Console.WriteLine(e); }




            #endregion


            #region 3- Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen

            //float num1 = 5.4f;
            //float num2 = 50.4f;

            //float sum = num1 * num2;
            //float difference = num2 - num1;

            //float product = num1 * num2;
            //float quotient = num2 / num1;


            //Console.WriteLine("Number 1: " + num1);
            //Console.WriteLine("Number 2: " + num2); 
            //Console.WriteLine("Sum: " + sum); 
            //Console.WriteLine("Difference: " + difference); 
            //Console.WriteLine("Product: " + product);
            //Console.WriteLine("Quotient: " + quotient);


            #endregion


            #region 4- Write C# program that Extract a substring from a given string.

            //Console.WriteLine("Enter Any String");
            //string text = Console.ReadLine();


            //Console.WriteLine("Enter start index to get substring");
            //int startIndex = int.Parse( Console.ReadLine());


            //Console.WriteLine("Enter num of characters to get substring");
            //int length = int.Parse(Console.ReadLine());


            //Console.WriteLine( text.Substring(startIndex, length));

            #endregion






            #region 5- Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen

            //int num1 = 5; 
            //int num2 = 10;
            //num1 = num2;
            //num2 = 20;
            //Console.WriteLine(num1);
            //Console.WriteLine(num2);

            // Num1 get the value of Num2 with out being in relation so when num2 changed num1 didn't changed 

            #endregion




            #region 6- Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen

            //Point p1 = new Point(1,1);

            //Point p2 = new Point(2,10);


            //p1 = p2;

            //p2.X = 5;

            //Console.WriteLine("Point1");
            //Console.WriteLine(p1.X);
            //Console.WriteLine(p1.Y);


            //Console.WriteLine("Point2");
            //Console.WriteLine(p2.X);
            //Console.WriteLine(p2.Y);

            // p1 after making it equal to p2 its now reference to the same values that p2 refer to so now P1 and P2 refer to the same values of P1 

            #endregion





            #region 7-  Write C# program that take two string variables and print them as one variable 


            //Console.WriteLine("Enter First String");
            //string firstString = Console.ReadLine();
            //Console.WriteLine("Enter Second String");
            //string secondString = Console.ReadLine();

            //Console.WriteLine($"{firstString} {secondString}");



            #endregion



            #region 8-  Which of the following statements is correct about the C#.NET code snippet given below?

            //int d;
            //d = Convert.ToInt32(!(30 < 20));
            //Console.WriteLine(d);

            /////////////// //        d = 1


            #endregion


            #region 9- Which of the following is the correct output for the C# code given below?


            //Console.WriteLine(13 / 2 + " " + 13 % 2);

            /// Value will be 6 1
            #endregion



            #region 10 - What will be the output of the C# code given below?

            //int num = 1, z = 5;


            //if (!(num <= 0))
            //    Console.WriteLine(++num + z++ + " " + ++z);
            //else
            //    Console.WriteLine(--num + z-- + " " + --z);


            /// Value will be 7  7 
            #endregion


        }
    }
}

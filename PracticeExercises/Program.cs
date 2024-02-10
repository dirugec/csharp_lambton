/*  Course: 2024W CSD 2354 8 Programming C#.NET
    Author: Dumar Ruge
    Id: C0869984
    Date: 01/19/2024
*/
using System.Runtime.Intrinsics.Arm;

namespace PracticeExerciseWeek5
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // ++++++  Set 1    ++++++++
            // ================== Exercise 1 =====================
            /* Write an if if statement that examines two integer variables and exchanges their values 
            if the first is greater than the second one. */

            // Declaring variables to store the numbers and a temporary variable for swapping

            // int number1, number2, temp;


            // // Prompinting the user for the first number
            // System.Console.Write("Enter the First Number: ");
            // //Reading the input and converting into an integer
            // number1 = int.Parse(Console.ReadLine());

            // // Prompinting the user for the second number
            // System.Console.Write("Enter the Second Number: ");
            // //Reading the input and converting into an integer
            // number2 = int.Parse(Console.ReadLine());

            // if (number1 > number2)
            // {
            //     // Swapping the values of number1 and numbert2 when number1 is gratter
            //     temp = number1;
            //     number1 = number2;
            //     number2 = temp;
            //     System.Console.WriteLine($"The numbers sorted in ascending {number1}, {number2}");

            // }
            // else
            // {
            //     // Printing the number1 is less than number2
            //     System.Console.WriteLine($"The numbers sorted in ascending {number1}, {number2}");
            // }

            // ===================================================
            // ================== Exercise 2 =====================
            /* Write a program tht shows the sign of the product of three real numbers 
                without calculating it. Use a sequence of if statements.
            */

            //Declaring the three variables to store numbers
            // double num1, num2, num3;

            // //Promting the user
            // System.Console.WriteLine("Enter three real numbers");

            // //Prompting the user for the numbers and converting to stage it
            // System.Console.Write("Enter the First number: ");
            // num1 = double.Parse(Console.ReadLine());
            // System.Console.Write("Enter the Second number: ");
            // num2 = double.Parse(Console.ReadLine());
            // System.Console.Write("Enter the Third number: ");
            // num3 = double.Parse(Console.ReadLine());

            // // evaluating for product == 0
            // if (num1 == 0 || num2 == 0 || num3 == 0)
            // {
            //     System.Console.WriteLine("The product is 0");
            // }
            // // evaluating with the xor operator for a negative product
            // else if ((num1 < 0) ^ (num2 < 0) ^ (num3 < 0))
            // {
            //     System.Console.WriteLine("The product is negative");
            // }
            // else
            // {
            //     // If neither two previous conditions is false, then the product is positive
            //     System.Console.WriteLine("The product is positive");
            // }


            // ===================================================
            // ================== Exercise 3 =====================
            /* Write a program that finds the biggest of three integers 
                using nested if statements.
            */

            // // Declariang variables to store numbers
            // int num1, num2, num3, biggest;

            // //Promting the user
            // System.Console.WriteLine("Enter three integers");

            // //Prompting the user for the numbers and converting to stage it
            // System.Console.Write("Enter the First number: ");
            // num1 = int.Parse(Console.ReadLine());
            // System.Console.Write("Enter the Second number: ");
            // num2 = int.Parse(Console.ReadLine());
            // System.Console.Write("Enter the Third number: ");
            // num3 = int.Parse(Console.ReadLine());



            // // Nested if statements to find the biggest number
            // if (num1 >= num2)
            // {
            //     if (num1 >= num3)
            //     {
            //         biggest = num1;
            //     }
            //     else
            //     {
            //         biggest = num3;
            //     }
            // }
            // else
            // {
            //     if (num2 >= num3)
            //     {
            //         biggest = num2;
            //     }
            //     else
            //     {
            //         biggest = num3;
            //     }
            // }

            // Console.WriteLine($"The biggest number is: {biggest}");


            // ===================================================
            // ================== Exercise 4 =====================
            /* Sort 3 real values in descending order using nested if 
            nested if statements.
            */

            // Declariang variables to store numbers
            // int num1, num2, num3, first, second, third;


            // //Promting the user for the numbers
            // System.Console.WriteLine("Enter three integers to be sorted in ascending");

            // //Prompting the user for the numbers and converting to stage it
            // System.Console.Write("Enter the First number: ");
            // num1 = int.Parse(Console.ReadLine());
            // System.Console.Write("Enter the Second number: ");
            // num2 = int.Parse(Console.ReadLine());
            // System.Console.Write("Enter the Third number: ");
            // num3 = int.Parse(Console.ReadLine());

            // // Nested if statements to find the biggest number

            // if (num1 >= num2 && num1 >= num3)
            // {
            //     first = num1;
            //     if (num2 >= num3)
            //     {
            //         second = num2;
            //         third = num3;
            //     }
            //     else
            //     {
            //         second = num3;
            //         third = num2;
            //     }
            // }
            // else if (num2 >= num1 && num2 >= num3)
            // {
            //     first = num2;
            //     if (num1 >= num3)
            //     {
            //         second = num1;
            //         third = num3;

            //     }
            //     else
            //     {
            //         second = num3;
            //         third = num1;
            //     }


            // }
            // else
            // {
            //     first = num3;
            //     if (num1 >= num2)
            //     {
            //         second = num1;
            //         third = num2;

            //     }
            //     else
            //     {
            //         second = num2;
            //         third = num1;
            //     }
            // }

            // Console.WriteLine($"Sorted numbers in descending order: {first}, {second}, {third}");


            // ++++++  Set 2    ++++++++
            // ================== Exercise 1 =====================           
            /* 
            Write program that ask for a digit and depending
            on the input shows the name of that digit (in
            English) using a switch statement..
            */

            // System.Console.WriteLine("Enter a digit beteween 0 and 9:  ");
            // int digit = int.Parse(Console.ReadLine());

            // Usong a switch estructure to select the result depending the case
            // switch (digit)
            // {
            //     case 0:
            //         System.Console.WriteLine("Zero");
            //         break;
            //     case 1:
            //         System.Console.WriteLine("One");
            //         break;
            //     case 2:
            //         System.Console.WriteLine("Two");
            //         break;
            //     case 3:
            //         Console.WriteLine("Three");
            //         break;
            //     case 4:
            //         Console.WriteLine("Four");
            //         break;
            //     case 5:
            //         Console.WriteLine("Five");
            //         break;
            //     case 6:
            //         Console.WriteLine("Six");
            //         break;
            //     case 7:
            //         Console.WriteLine("Seven");
            //         break;
            //     case 8:
            //         Console.WriteLine("Eight");
            //         break;
            //     case 9:
            //         Console.WriteLine("Nine");
            //         break;
            //     default:
            //            // default case is using to prevent a wrong input like a character
            //         Console.WriteLine("Invalid digit");
            //         break;
            // }




            // ================== Exercise 2 =====================           
            /* 
            Write a program that enters the coefficients a, b and c of a quadratic equation
            a*x^2 + b*x + c = 0 and calculates and prints its real roots. Note that quadratic equations 
            may have 0,1 or 2 real roots.
            */
            // prompting the user to input the coefficients and convert them into a double

            // System.Console.WriteLine(" Welcome to Quadratics Ecuations Solution App");
            // System.Console.WriteLine("Please enter the coefficeint a: ");
            // double a = double.Parse(Console.ReadLine());
            // System.Console.WriteLine("Please enter the coefficeint b: ");
            // double b = double.Parse(Console.ReadLine());
            // System.Console.WriteLine("Please enter the coefficeint c: ");
            // double c = double.Parse(Console.ReadLine());

            // double discriminant = b * b - 4 * a * c;

            // Evauate the discrimintant to know the number of roots
            // if (discriminant > 0)
            // {
            //     double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            //     double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            //     System.Console.WriteLine("The quadratic equation for this coefficients has two real roots:");
            //     System.Console.WriteLine($"Root 1: {root1}");
            //     System.Console.WriteLine($"Root 2: {root2}");
            // }
            // else if (discriminant == 0)
            // {
            //     double root = -b / (2 * a);
            //     Console.WriteLine("The quadratic equation for this coefficients has one real root:");
            //     Console.WriteLine($"Root 1: {root}");

            // }
            // else
            // {

            //     System.Console.WriteLine("The quadratic equation for this coefficients has not real roots");
            // }

            // ================== Exercise 3 =====================           
            /* 
            Write a program that fnds the greatest of given 5 variables.
            */
            // // prompt the message to request the input of a number
            // System.Console.WriteLine("Enter five number: ");
            // double[] numbers = new double[5];


            // for (int i = 0; i < 5; i++)
            // {
            //     // Display a message to indicate what number or position should input
            //     System.Console.Write($"Enter number {i + 1}: ");
            //     // Reading the input and storing the value in each index
            //     numbers[i] = double.Parse(Console.ReadLine());

            // }

            // // Variable to store the greatest number
            // double greatestNumber = numbers[0];

            // // for loop to read and compare each number in the array
            // for (int i = 1; i < 5; i++)
            // {
            //     if (numbers[i] > greatestNumber)
            //     {
            //         greatestNumber = numbers[i];
            //     }
            // }
            // // Printing the result greatestNumber
            // System.Console.WriteLine($"The greatest number is: {greatestNumber}");
        }
    }
}


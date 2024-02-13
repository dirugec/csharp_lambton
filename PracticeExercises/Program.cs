/*  Course: 2024W CSD 2354 8 Programming C#.NET
    Author: Dumar Ruge
    Id: C0869984
    Date: 02/12/2024
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

            // System.Console.WriteLine($"The biggest number is: {biggest}");


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

            // System.Console.WriteLine($"Sorted numbers in descending order: {first}, {second}, {third}");


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
            //         System.Console.WriteLine("Three");
            //         break;
            //     case 4:
            //         System.Console.WriteLine("Four");
            //         break;
            //     case 5:
            //         System.Console.WriteLine("Five");
            //         break;
            //     case 6:
            //         System.Console.WriteLine("Six");
            //         break;
            //     case 7:
            //         System.Console.WriteLine("Seven");
            //         break;
            //     case 8:
            //         System.Console.WriteLine("Eight");
            //         break;
            //     case 9:
            //         System.Console.WriteLine("Nine");
            //         break;
            //     default:
            //            // default case is using to prevent a wrong input like a character
            //         System.Console.WriteLine("Invalid digit");
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



            // ++++++  Set 3    ++++++++
            // ================== Exercise 1 =====================           
            /* 
                Write a program that, depending on the user's
                choice inputs int, double or string variable. If the
                variable is integer or doublle, increase it with 1. If
                the variable is string, appends "*" at its end. The
                program must show the value of that variable as a
                console output. Use switch statement.
            */

            // System.Console.WriteLine("Choose the type of the variable:");
            // System.Console.WriteLine("1. Integer");
            // System.Console.WriteLine("2. Duble");
            // System.Console.WriteLine("3. String");
            // System.Console.Write("Enter your chois (1,2 or 3): ");

            // int selection = int.Parse(Console.ReadLine());

            // switch (selection)
            // {
            //     case 1:
            //         System.Console.Write("Enter an Integer: ");
            //         int intValue = int.Parse(Console.ReadLine());
            //         intValue++;
            //         System.Console.WriteLine($"The new integer is {intValue}");
            //         break;
            //     case 2:
            //         System.Console.Write("Enter an Integer: ");
            //         double doubleValue = double.Parse(Console.ReadLine());
            //         doubleValue++;
            //         System.Console.WriteLine($"The new integer is {doubleValue}");
            //         break;
            //     case 3:
            //         System.Console.WriteLine(" Enter a String: ");
            //         string strValue = Console.ReadLine();
            //         strValue += "*";
            //         System.Console.WriteLine($"The new string is {strValue}");
            //         break;
            //     default:
            //         System.Console.WriteLine("Invalid Choice");
            //         break;
            // }


            // ================== Exercise 2 =====================           
            //     /* 
            //         We are given 5 integer numbers. Write a program
            //         that checks if the sum of some subset of them is 0.
            //         Example: 3,-2,1,1,8 =>1+1-2=0.
            //     */

            //     // This is the list with five numbers that we will use as an input
            //     int[] nums = { -4, 1, 1, 2, 8 };

            //     // Recursive function to find subsets with sum 0.
            //     static void SubsetSum(int[] nums, int target, int index, List<int> subset)
            //     {
            //         // If we have processed all elements in the array
            //         if (index == nums.Length)
            //         {
            //             // If the sum of the current subset equals the target, print the subset
            //             if (subset.Sum() == target)
            //             {
            //                 // Print the answer when the subset get the target sum or 0 in this case
            //                 System.Console.WriteLine("Subset with sum 0 found: [" + string.Join(",", subset) + "]");
            //             }
            //             return;
            //         }

            //         // Include current number in the subset and recursively call SubsetSum with next index
            //         subset.Add(nums[index]);
            //         SubsetSum(nums, target, index + 1, subset);


            //         // Exclude current number from the subset and recursively call SubsetSum with next index
            //         subset.RemoveAt(subset.Count - 1);
            //         SubsetSum(nums, target, index + 1, subset);

            //     }
            //     // call the function
            //     SubsetSum(nums, 0, 0, new List<int>());

            // ++++++  Set 4    ++++++++
            // ================== Exercise 1 =====================        
            /*
            Write a program that applies bonus scores to given
            scores in the range [1..9]. The program reads a digit
            as an input. If the digit is between 1 and 3, the
            program multiplies it by 10; if it is between 4 and 6,
            multiplies it by 100; if it is between 7 and 9,
            multiplies it by 1000. If it is zero or if the value is not
            a digit, the program must report an error.
            Use a switch statement and at the end print the
            calculated new value in the console.
            */

            // System.Console.WriteLine("Enter a digit between 1 and 9:");
            // // Declaring the variable to store the user input
            // int input;

            // // Try to parse the input as an integer
            // if (!int.TryParse(Console.ReadLine(), out input))
            // {
            //     // If parsing fails, print an error message
            //     System.Console.WriteLine("Error: Invalid input. Please enter a digit between 1 and 9.");
            //     return;
            // }
            // // Decalring a variable to store the bonus to apply
            // int bonusScore;

            // // Use a switch statement to handle different cases
            // switch (input)
            // {
            //     //If input is between 1 and 3 then multiply by 10
            //     case 1:
            //     case 2:
            //     case 3:
            //         bonusScore = input * 10;
            //         break;
            //     //If input is between 4 and 6 then multiply by 100
            //     case 4:
            //     case 5:
            //     case 6:
            //         bonusScore = input * 100;
            //         break;
            //     //If input is between 7 and 9 then multiply by 1000
            //     case 7:
            //     case 8:
            //     case 9:
            //         bonusScore = input * 1000;
            //         break;
            //     default:
            //         // If the input is not between 1 and 9, print an error message
            //         System.Console.WriteLine("Error: Input out of range. Please enter a digit between 1 and 9.");
            //         return;
            // }

            // // Print the calculated bonus score
            // System.Console.WriteLine("Calculated new value: " + bonusScore);


            // ++++++  Set 5    ++++++++
            // ================== Exercise 1 =====================        
            /*
            Write a program that converts a number in the
            range [0...999] to a text corresponding to its
            English pronunciation. Examples:
            0 => "Zero"
            273 => "Two hundred seventy three"
            400 => "Four hundred"
            501 => "Five hundred and one"
            711 => "Severn hundred and eleven"
            */

            System.Console.WriteLine("Enter a number between 0 and 999:");
            int number = int.Parse(Console.ReadLine());

            // Checking the range
            if (number < 0 || number > 999)
            {
                System.Console.WriteLine("Number out of range.");
                return;
            }


            // Declaring the variable to store the return of the function
            string result = ConvertNumberToWords(number);
            // Printing the console output
            System.Console.WriteLine($"The English pronunciation of {number} is: {result}");
        }


        // Function to evaluate the input
        static string ConvertNumberToWords(int number)
        {
            // If number is zero
            if (number == 0)
            {
                return "Zero";
            }

            // List of string to use when the number has ones, teens or tens
            string[] ones = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            string[] teens = { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            string[] tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

            // Declaring the variable to store the concatenation
            string words = "";

            // Add hundreds place if present
            if (number / 100 > 0)
            {
                //  dividing the number by 100 to find the ones[index}] + hundred
                words += ones[number / 100] + " hundred";

                // if the number has tens ore ones  
                number %= 100;
                if (number > 0)
                {
                    words += " and ";
                }
            }

            // Add tens place if present
            if (number >= 10 && number <= 19)
            {
                words += teens[number % 10];
            }
            else if (number >= 20)
            {
                words += tens[number / 10];
                if (number % 10 > 0)
                {
                    words += " ";
                }
            }

            // Add ones place if present
            if (number % 10 > 0 && number >= 10)
            {
                words += ones[number % 10];
            }

            return words;

        }
    }
}


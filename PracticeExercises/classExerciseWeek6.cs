/*  Course: 2024W CSD 2354 8 Programming C#.NET
    Author: Dumar Ruge
    Id: C0869984
    Date: 02/12/2024
    Class Excercise Week 6
*/

using System;

// Using a for loop

// Prompt the user for a number

System.Console.Write("Enter an integer positive an less than 10: ");
// Store the input into a variable data type integer
int number = int.Parse(Console.ReadLine());


// while loop to validate if input number is positive and less than 10
while (number >= 10 || number <= 0)
{
    System.Console.WriteLine(" Invalid value");
    // propmt a neaw input
    System.Console.Write("Enter an integer positive an less than 10: ");
    number = int.Parse(Console.ReadLine());
}

//Printing in console the title
System.Console.WriteLine($"Timestable of number {number}: ");

// For loop to iterate nine times and get the times table
for (int i = 1; i < 10; i++)
{
    int result = i * number;
    // printing a string concatenation with number, iteration and result
    System.Console.WriteLine($"{i} * {number} = {result}");

}
System.Console.WriteLine("-----------------");


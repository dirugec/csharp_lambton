

/*  Course: 2024W CSD 2354 8 Programming C#.NET
    Author: Dumar Ruge
    Id: C0869984
    Date: 02/09/2024
*/
using System;

class Interval
{
    static void Main(string[] args)
    {
        // Ask the user to enter a real number
        Console.Write("Enter a real number: ");
        double x = double.Parse(Console.ReadLine());

        // Test x in the given intervals
        if ((x < 3 && x >= 2) || (x >= 0 && x <= 1) || (x >= -10 && x < -2))
        {
            Console.WriteLine("x belongs to I");
        }
        else
        {
            Console.WriteLine("x does not belong to I");
        }
    }
}
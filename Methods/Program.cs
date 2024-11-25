using System;


class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int squaredNumber = SquareNumber(number);
        Console.WriteLine("The squared value is: " + squaredNumber);
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }
}
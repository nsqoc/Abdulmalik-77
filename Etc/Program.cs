using System;

class Program
{
    static void Main()
    {
        Console.Write("enter a number between 1 and 7: ");
        int dayNumber = Convert.ToInt32(Console.ReadLine());


        switch  (dayNumber)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("tuesday");
                break;
            case 3:
                Console.WriteLine("wednesday");
                break;
            case 4:
                Console.WriteLine("thursday");
                break;
            case 5:
                Console.WriteLine("friday");
                break;
            case 6:
                Console.WriteLine("saturday");
                break;
            case 7:
                Console.WriteLine("sunday");
                break;
            default:
                Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
                break;
        }
    }
}
using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number.");
        int limit1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter another number.");
        int limit2 = Convert.ToInt32(Console.ReadLine());
        int min, max;
        if (limit1 > limit2)
        {
            max = limit1;
            min = limit2;
        } else
        {
            min = limit1;
            max = limit2;
        }

        Console.WriteLine("Enter a number between " + min + " and " + max + ".");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number < min)
        {
            Console.WriteLine("You have entered " + number + " which is lower than " + min + " which is the minimum.");
            number = min;
            Console.WriteLine("Your number has automatically set to " + number + ".");
        }
        else if (number > max)
        {
            Console.WriteLine("You have entered " + number + " which is higher than " + max + " which is the maximum.");
            number = max;
            Console.WriteLine("Your number has automatically set to " + number + ".");
        } else
        {
            Console.WriteLine("You have entered a correct number.");
        }

    }
}
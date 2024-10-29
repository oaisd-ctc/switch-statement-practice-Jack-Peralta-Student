using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Give me a number from 1-10");
        int x = int.Parse(Console.ReadLine());
        switch (x)
        {
            case 1:
                Console.WriteLine("Your number is One");
                break;

            case 2:
                Console.WriteLine("Your number is Two");
                break;

            case 3:
                Console.WriteLine("Your number is Three");
                break;

            case 4:
                Console.WriteLine("Your number is Four");
                break;

            case 5:
                Console.WriteLine("Your number is Five");
                break;

            case 6:
                Console.WriteLine("Your number is Six");
                break;

            case 7:
                Console.WriteLine("Your number is Seven");
                break;

            case 8:
                Console.WriteLine("Your number is Eight");
                break;

            case 9:
                Console.WriteLine("Your number is Nine");
                break;

            case 10:
                Console.WriteLine("Your number is Ten");
                break;

            default:
                Console.WriteLine("That number is not in range.");
                break;
        }
    }
}
using System.Transactions;
using System.Xml.Schema;

public class Program
{

    public static void Main(string[] args)
    {

        Console.WriteLine("ShowChar for ShowCharacter, RETAIL for CalcualteRetail, CELS for Celsius, or PRIME for IsPrime.");
        string input = Console.ReadLine();  

        Console.Clear();
        switch (input.Trim().ToUpper())
        {
            case "SHOWCHAR":
                Main();
                break;
            case "RETAIL":
                CalculateRetail();
                break;
            case "CELS":
                Celsius();
                break;
            case "PRIME":
                IsPrime();
                break;
            default:
                Console.WriteLine("That isn't one of the options.");
                break;


        }


        static char ShowCharacter(string str, int index)
        {
            return str[index - 1];
        }
        static void Main()
        {
            Console.Write("Enter Input ");
            string str = Console.ReadLine();
            Console.Write("Enter Char Number ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(ShowCharacter(str, number));
        }

        static void CalculateRetail()
        {
            Console.Write("What is the item's cost? ");
            double cost = double.Parse(Console.ReadLine());
            Console.Write("What is the makeup percentage? ");
            double percentage = double.Parse(Console.ReadLine());

            double total = cost +(cost * (percentage/100));
            Console.WriteLine($"Total amount paid is {Math.Round(total,2)}");

        }
        
        static void Celsius()
        {
            Console.Write("Enter Fahrenheit: ");
            double Fahrenheit = double.Parse(Console.ReadLine());

            double Celsius = (Fahrenheit - 32) * 5/9;
            Console.WriteLine($"For the Fahrenheit {Fahrenheit}, the temperture in Celsius will be {Math.Round(Celsius,2)}");

            for (double i = 80; i <= 100; i++)
            {
                double c = (i - 32) * 5 / 9;
                Console.WriteLine($"F = {i}      C = {Math.Round(c, 2)}");
            }


        }
        
        static void IsPrime()
        {
           
            Console.Write("Enter Number to check if Prime: ");
            int number = int.Parse(Console.ReadLine());
            int numberHalf = number / 2;
            for (int i = 2; i <= numberHalf; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine($"Your number, {number}, is not Prime!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Your number, {number}, is  Prime!");
                    break;
                }   
            }


        }
    }
}


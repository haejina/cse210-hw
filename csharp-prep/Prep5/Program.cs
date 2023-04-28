using System;

class Program
{
    static void Main(string[] args)
    {

        DisplayWelcome();
        string userName = PromptUserName();
        int userNumbers = PromptUserNumber();
        int squareRoot = SquareNumber(userNumbers);
        DisplayResult(userName, squareRoot);

        

    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }


    static string PromptUserName()
    {
        Console.Write("Please enter your name:");
        string user = Console.ReadLine();
        
        return user;
    }


    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number:");
        int num = int.Parse(Console.ReadLine());

        return num;
    }


    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }


    static void DisplayResult(string userName, int square)
    {
        Console.WriteLine($"{userName}, the square of your number is {square}");   
    }
        
    
}
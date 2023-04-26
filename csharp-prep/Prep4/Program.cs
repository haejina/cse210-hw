using System;

class Program
{
    static void Main(string[] args)
    {
        
        List<int> numbers = new List<int>();
        
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int userNum = -1;
        while(userNum != 0)
        {
            Console.WriteLine("Enter number:");
            string response = Console.ReadLine();
            userNum = int.Parse(response);

            if(userNum != 0)
            {
               numbers.Add(userNum);
            }


        }

        int sum = 0;
        foreach(int number in numbers)
        {
            sum = sum + number;
        }
        Console.WriteLine("The sum is: " + sum);

        
        float average = (float)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach(int number in numbers)
        {
            if(number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number is: {max}");



        


       
        

    }
}
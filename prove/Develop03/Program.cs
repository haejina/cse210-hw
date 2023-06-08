using System;
using System.Windows.Input;

class Program
{
    static void Main(string[] args)
    {   
        
            Scripture scripture = new Scripture();
            Console.WriteLine("Please enter to continue or type 'quit' to finish");
            Console.WriteLine();
           
            

            while(!scripture.HideAllWords())
            {
                 scripture.Display();
                 string user = Console.ReadLine();

                 if(user.Trim() == " ")
                 {
                    
                    scripture.HideRandomWord();
                    scripture.Display();
                    Console.WriteLine();
                    

                 }
                 else if(user == "quit")
                 {
                    break;
                 }
            }

            
    }
}
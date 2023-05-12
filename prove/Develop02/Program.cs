using System.Collections.Generic;
using System;
using System.IO; 


namespace Develop02
{
    class Program
   {
       static void Main(string[] args)
       {
         
         List<String> prompts = new List<string>()
         {
           "Who was the most interesting person I interacted with today?",
           "What was the best part of my day?",
           "How did I see the hand of the Lord in my life today?",
           "What was the strongest emotion I felt today?",
           "If I had one thing I could do over today, what would it be?"

         };
         
         Random random = new Random();
         DateTime theCurrentTime = DateTime.Now;
         Journal journal= new Journal();
         

         List<Entry> entries = journal.GetEntries();
         while(true)
         {

            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            string inputString = Console.ReadLine();
            int input = Int32.Parse(inputString);
            int index = random.Next(prompts.Count);
            string prompt = prompts[index];
            

            switch(input)
            {
              
              case 1:

                  Console.WriteLine(prompt);
                  string response = Console.ReadLine();
                  string dateText = theCurrentTime.ToShortDateString();

                  Entry newEntry = new Entry();
                  newEntry.StorePrompt(prompt);
                  newEntry.StoreResponse(response);
                  newEntry.StoreDate(dateText);

                  journal.StoreEntry(newEntry);

                  

                  break;

              case 2:

                  foreach(Entry entry in journal.entries)
                  {
                    Console.WriteLine($"Date: {entry.GetDate()} - Prompt: {entry.GetPrompt()}");
                    Console.WriteLine(entry.GetResponse());
                  }

                  break;

              
              case 3:

                string filename = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(filename);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(",");

                    string Prompt = parts[0];
                    string Response = parts[1];
                    string date = parts[2];

                    Entry loadEntry = new Entry();
                    loadEntry.StorePrompt(Prompt);
                    loadEntry.StoreResponse(Response);
                    loadEntry.StoreDate(date);

                    journal.StoreEntry(loadEntry);


                }

                break;


              case 4:
                
                string fileName = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    // You can add text to the file with the WriteLine method
                    
                    foreach(Entry entry in journal.entries)
                    {
                       outputFile.WriteLine($"{entry.GetPrompt()},{entry.GetResponse()},{entry.GetDate()}");
                    }
                    
              
                }

                break;

                 

              case 5:
                  
                  return; // out of the function 


            }

           
         }
       }
    }

}

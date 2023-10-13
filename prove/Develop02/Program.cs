using System;

class Program
{
    static void Main(string[] args)
    {
        string fileName = "daily_events.txt";

        // Get the current date
        string currentDate = DateTime.Now.ToString("yyyy-MM-dd");

        //Create or open the file for appending
        using (StreamWriter file = file.AppendText(fileName))
        {
            //Write the current date to the file
            file.WriteLine($"Date: {currentDate}");

            //Startrecording events
            while (true)
            {
                console.Write("Enter an event of your day (or type 'exit' to finish): ");
                string eventDescription = Console.ReadLine();

                if (eventDescription.ToLower() == "exit")
                {
                    break;
                }
                Console.Write("Enter a question related to the event: ");
                string question = Console.ReadLine();

                file.WriteLine($"Question: {question}");
                file.WriteLine($"Event: {eventDescription}");
                file.WriteLine();
            }

            
            
        

            
             

        }
    }
    Console.WriteLine("Events recorded and saved to daily_events.txt.");
}
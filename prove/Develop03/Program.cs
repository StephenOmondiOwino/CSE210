using System;


class Program

{
    static void Main(string[] args)
    {
        Scripture scripture= new Scripture();
    

        Console.Write("John 2:3");
        scripture.Referance = Console.ReadLine();
        Console.Write("And hereby we do know that we know him, if we keep his commandments");
        scripture.Text = Console.ReadLine();

        Console.Clear();
        DisplayScripture(scripture);

        while(true)
        {
            Console.Write("\nPress Enter to hide random words or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            break;

            scripture.Text = scripture.HideRandomWords();
            Console.Clear();
            DisplayScripture(scripture);
        }
        }

        static void DisplayScripture(Scripture scripture)
        {

    

        Console.WriteLine($"Scripture Reference: {scripture.Reference}");
        Console.WriteLine($"Scripture Text: {scripture.Text}");
        

        Console.WriteLine();
    }
}

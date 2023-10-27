using Develop03

class program 
{
    static string verse = @"And hereby we do know him, if we keep his commandments;";

    static string reference = "JOHN 1:2-3";

    static void Main(string[] args);
    {
        //Instantiate aScripture with verse and reference
        Scripture scripture = new Scripture(verse,new reference(reference, 3))
        string input = "";

        do
        {
           //Clear the screen before displaying scripture
           Console.Clear();
           //Write out scripture and verse
           Console.Write(scripture.ToString());
           //Get user's input
           input = Console.ReadLine(); 
        } while (!input.ToUpper().Equals("QUIT")& !scripture.isFinished());
    }


}
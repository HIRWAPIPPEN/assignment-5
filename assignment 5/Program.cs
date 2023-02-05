// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

namespace Journal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 'start' to start writing into the journal, 'stop' to stop.");
            string input = Console.ReadLine();
            string journal = "";
            bool writing = false;

            while (input != "stop")
            {
                if (input == "start")
                {
                    writing = true;
                }
                else if (writing)
                {
                    journal += input + "\n";
                }

                input = Console.ReadLine();
            }

            if (journal.Length > 0)
            {
                string fileName = DateTime.Now.ToString("yyyy-MM-dd") + ".txt";
                File.WriteAllText(fileName, "Captain's log\nStardate " + DateTime.Now.ToString("yyyy-MM-dd") + "\n" + journal + "Jean-Luc Picard");
                Console.WriteLine("Journal written to file " + fileName);
            }
        }
    }
}



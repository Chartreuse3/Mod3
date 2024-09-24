class Program
{
    static string csvFilePath = "mario.csv";

    static void Main()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Display all characters");
            Console.WriteLine("2. Add a new character");
            Console.WriteLine("3. Exit");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                DisplayCharacters();
            }
            else if (choice == "2")
            {
                AddCharacter();
            }
            else if (choice == "3")
            {
                running = false;
                Console.WriteLine("Application ended.");
            }
            else
            {
                Console.WriteLine("Invalid option, please try again.");
            }
        }
    }

    static void DisplayCharacters()
    {
        try
        {
            if (System.IO.File.Exists(csvFilePath))
            {
                string[] characters = System.IO.File.ReadAllLines(csvFilePath);
                foreach (var character in characters)
                {
                    Console.WriteLine(character);
                }
            }
            else
            {
                Console.WriteLine("Character file not found!");
            }
        }
        catch
        {
            Console.WriteLine("An error occurred while reading the file.");
        }
    }

    static void AddCharacter()
    {
        try
        {
            Console.WriteLine("Enter character details:");

            Console.Write("ID: ");
            string id = Console.ReadLine();

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Description: ");
            string description = Console.ReadLine();

            Console.Write("Species: ");
            string species = Console.ReadLine();

            Console.Write("First Appearance: ");
            string firstAppearance = Console.ReadLine();

            Console.Write("Year Created: ");
            string yearCreated = Console.ReadLine();

            string newCharacter = id + "," + name + "," + description + "," + species + "," + firstAppearance + "," + yearCreated;
            
            System.IO.File.AppendAllText(csvFilePath, newCharacter + System.Environment.NewLine);

            Console.WriteLine("Character added successfully!");
        }
        catch
        {
            Console.WriteLine("An error occurred while adding the character.");
        }
    }
}
